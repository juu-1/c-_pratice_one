using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalclulate_Click(object sender, EventArgs e)
        {
            //creating variable

            double hours_worked, payrate, grosspay;
            double validation;

            //prevent exception data converstion using try parse method


            if (double.TryParse(hourseworkedTexetbox.Text, out validation) & double.TryParse(hourspayratetxtbox.Text, out validation))
            {
                //assigning variable

                hours_worked = double.Parse(hourseworkedTexetbox.Text);
                payrate=double.Parse(hourspayratetxtbox.Text);

                //checking valdiation
                if (hours_worked > 0 & payrate > 0)
                {
                    // calculate the gross pay
                    grosspay = hours_worked * payrate;
                    grosspaylebel1.Text = grosspay.ToString("c");


                }

                else
                {
                    MessageBox.Show("hours worked or pay rate must be grate than 0");

                }


            }
            else
            {
                MessageBox.Show("txt hours , txtpayrate only accept double");

            }



        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            hourseworkedTexetbox.Clear();
            hourspayratetxtbox.Clear();
            grosspaylebel1.Text = string.Empty;  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

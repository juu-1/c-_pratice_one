using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example_nasted_loop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnqualification_Click(object sender, EventArgs e)
        {
            //creating variables

            double salary, years;

            try
            {

                //assigning variables

                salary = double.Parse(txtsalary.Text);
                years = double.Parse(txtyears.Text);

                //checking qualification using decisnon structure 
                if (salary > 300 && years >= 2)
                {


                    lblresult.Text = "qualify on loan";
                }
                else
                {

                    MessageBox.Show("mishaarkada &exp midkooda ayaa kugu yar");
                }








            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace example3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalclulate_Click(object sender, EventArgs e)
        {
            //creating variables

            string string1, string2;

            //assigning variables

            string1 = txtstringone.Text;
            string2 = txtstringtwo.Text;

            //compare using string with == equal opreator

            if (string1 == string2)
            {

                lblstringcompare.Text = "same string";

            }
            else
            {
                lblstringcompare.Text = "not same";


            }
        }
    }
    }


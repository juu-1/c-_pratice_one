using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_csharp_one
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnshowinfo_Click(object sender, EventArgs e)
        {
            string student_name = textname.Text;
            int studentid = int.Parse(textstudentid.Text);
            string department = textdepartement.Text;
            int semester = int.Parse(textsemester.Text);

            lbloutput.Text = "Name: " + student_name +
                   "\nStudent ID: " + studentid +
                   "\nDepartment: " + department +
                   "\nSemester: " + semester;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textname.Clear();
            textstudentid.Clear();
            textdepartement.Clear();
            textsemester.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

            Application.Exit();
        }
    }
}

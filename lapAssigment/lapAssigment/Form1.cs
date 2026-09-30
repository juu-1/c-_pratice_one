using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapAssigment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            //creating vriables
            string food1, food2;
         double price_food1, price_food2, subtotal, tips, total_amount,sales_texet;

            //constatnt variable
            const double sales_texet_price = 7;
            const double tips_precentage = 15;

            food1 = txtnamefood1.Text;
            price_food1 = double.Parse(txtpricefood1.Text);
            food2 = txtnamefood2.Text;
            price_food2 = double.Parse(txtpricefood2.Text);

            //process calculte the total amount
            subtotal = price_food1 + price_food2;

            //how to calculate  the salextex  precentage
            

            sales_texet = subtotal + (sales_texet_price / 100);

            //how to cal culate tips

            tips = subtotal * (tips_precentage / 100);

            //how to calculate the amount

            total_amount = subtotal + sales_texet - tips;


            //display  the text

            // Display results
            txtSalesTax.Text = sales_texet.ToString("C");
            txtTips.Text = tips.ToString("C");
            txtTotalAmount.Text = total_amount.ToString("C");



        }
    }
}

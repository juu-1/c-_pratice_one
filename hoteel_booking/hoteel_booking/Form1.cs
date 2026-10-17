using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoteel_booking
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

        private void button1_Click(object sender, EventArgs e)
        {
            string guestName = txtGuestName.Text.Trim();

            int age;
            int nights;
            int guests;

            if (guestName == "")
            {
                MessageBox.Show("Please enter guest name.");
                txtGuestName.Focus();
                return;
            }

            if (!int.TryParse(txtGuestAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers for Age, Nights and Guests.");
                return;
            }

            if (age <= 0 || nights <= 0 || guests <= 0)
            {
                MessageBox.Show("Age, nights and guests must be greater than zero.");
                return;
            }

            string roomType;
            decimal roomRate;
            int capacity;

            if (rdoStandard.Checked)
            {
                roomType = "Standard";
                roomRate = 50;
                capacity = 2;
            }
            else if (rdoNormal.Checked)
            {
                roomType = "Normal";
                roomRate = 80;
                capacity = 4;
            }
            else if (rdoHight.Checked)
            {
                roomType = "Suite";
                roomRate = 130;
                capacity = 6;
            }
            else
            {
                MessageBox.Show("Please select a room type.");
                return;
            }

            if (guests > capacity)
            {
                MessageBox.Show(
                    "This room can accommodate only " +
                    capacity + " guests.");
                return;
            }

            decimal roomCost = roomRate * nights;
            decimal breakfastCost = 0;

            if (chkBreakfast.Checked)
            {
                breakfastCost = 10 * guests * nights;
            }

            decimal subtotal = roomCost + breakfastCost;
            decimal discount = 0;

            if (nights >= 7)
            {
                discount = subtotal * 0.10m;
            }

            decimal total = subtotal - discount;

            // Display booking details in ListBox
            listBox1.Items.Clear();

            listBox1.Items.Add("HOTEL ROOM BOOKING");
            listBox1.Items.Add("--------------------------");
            listBox1.Items.Add("Guest Name: " + guestName);
            listBox1.Items.Add("Guest Age: " + age);
            listBox1.Items.Add("Room Type: " + roomType);
            listBox1.Items.Add("Number of Guests: " + guests);
            listBox1.Items.Add("Number of Nights: " + nights);
            listBox1.Items.Add("Room Cost: $" + roomCost);
            listBox1.Items.Add("Breakfast: $" + breakfastCost);
            listBox1.Items.Add("Subtotal: $" + subtotal);
            listBox1.Items.Add("Discount: $" + discount);
            listBox1.Items.Add("--------------------------");
            listBox1.Items.Add("TOTAL: $" + total);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            listBox1.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

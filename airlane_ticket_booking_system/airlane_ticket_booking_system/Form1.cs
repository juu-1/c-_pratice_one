using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace airlane_ticket_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1. Check Passenger Name

            string name = txtName.Text;

            if (name == "")

            {

                MessageBox.Show("Please enter passenger name.");

                return;

            }

            // 2. Read Age, Tickets and Baggage

            int age, tickets;

            double baggage;

            if (!int.TryParse(txtAge.Text, out age))

            {

                MessageBox.Show("Enter a valid age.");

                return;

            }

            if (!int.TryParse(txtTickets.Text, out tickets))

            {

                MessageBox.Show("Enter a valid number of tickets.");

                return;

            }

            if (!double.TryParse(txtBaggage.Text, out baggage))

            {

                MessageBox.Show("Enter a valid baggage weight.");

                return;

            }

            // 3. Validate Age

            if (age < 1 || age > 100)

            {

                MessageBox.Show("Age must be between 1 and 100.");

                return;

            }

            // 4. Validate Number of Tickets

            if (tickets < 1 || tickets > 5)

            {

                MessageBox.Show("Tickets must be between 1 and 5.");

                return;

            }

            // 5. Validate Baggage

            if (baggage < 0 || baggage > 50)

            {

                MessageBox.Show(

                    "Baggage must be between 0 and 50 kg per passenger."

                );

                return;

            }

            // 6. Check Travel Class

            double price = 0;

            string travelClass = "";

            if (rdoFirst.Checked)

            {

                if (age < 12)

                {

                    MessageBox.Show(

                        "Passengers below 12 cannot book First Class."

                    );

                    return;

                }

                price = 500;

                travelClass = "First Class";

            }

            else if (rdoNormal.Checked)

            {

                price = 200;

                travelClass = "Normal Class";

            }

            else if (rdoBusiness.Checked)

            {

                price = 350;

                travelClass = "Business Class";

            }

            else

            {

                MessageBox.Show("Please select a travel class.");

                return;

            }

            // 7. Calculate Basic Cost

            double total = price * tickets;

            // 8. Ticket Discount

            if (tickets >= 3 && tickets <= 4)

            {

                total = total - (total * 0.05);

            }

            else if (tickets == 5)

            {

                total = total - (total * 0.10);

            }

            // 9. Child Discount

            if (age < 12)

            {

                total = total - (total * 0.20);

            }

            // 10. Senior Discount

            if (age >= 60)

            {

                total = total - (total * 0.10);

            }

            // 11. Travel Insurance

            double insurance = 0;

            if (chkInsurance.Checked)

            {

                insurance = 25 * tickets;

                total = total + insurance;

            }

            // 12. Baggage Cost

            double baggageCost = 0;

            if (baggage > 20)

            {

                baggageCost = (baggage - 20) * 10;

                total = total + baggageCost;

            }

            // 13. Booking Approved

            bool bookingApproved = true;

            // 14. Display Booking Details in ListBox

            listBox1.Items.Clear();

            listBox1.Items.Add("AIRLINE BOOKING DETAILS");

            listBox1.Items.Add("------------------------------");

            listBox1.Items.Add("Passenger Name: " + name);

            listBox1.Items.Add("Passenger Age: " + age);

            listBox1.Items.Add("Number of Tickets: " + tickets);

            listBox1.Items.Add("Travel Class: " + travelClass);

            listBox1.Items.Add("Baggage Weight: " + baggage + " kg");

            listBox1.Items.Add("Ticket Price: $" + price);

            listBox1.Items.Add("Insurance Cost: $" + insurance);

            listBox1.Items.Add("Baggage Cost: $" + baggageCost);

            listBox1.Items.Add("------------------------------");

            listBox1.Items.Add("Total Cost: $" + total.ToString("0.00"));

            listBox1.Items.Add("Booking Approved: " + bookingApproved);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();

            txtAge.Clear();

            txtTickets.Clear();

            txtBaggage.Clear();

            listBox1.Items.Clear();

        
    }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

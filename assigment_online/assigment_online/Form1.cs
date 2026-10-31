using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace assigment_online
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (File.Exists("Ayan.doc"))
            {
                foreach (string line in File.ReadLines("juu.doc"))
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("juu.doc"))
            {
                string[] allLines = File.ReadAllLines("juu.doc");

                foreach (string line in allLines)
                {
                    listBox1.Items.Add(line);
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            // Create the file
            StreamWriter lines = File.CreateText("juu.doc");

            lines.WriteLine("Other functions of reading include:");
            lines.WriteLine("ReadLines().");
            lines.WriteLine("ReadAllLines().");
            lines.WriteLine("ReadBlock().");

            // Close the file
            lines.Close();

            MessageBox.Show("File created successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists("juu.doc"))
            {
                using (StreamReader input_file =
                    File.OpenText("juu.doc"))
                {
                    char[] buffer = new char[5];
                    int count;

                    while ((count = input_file.ReadBlock(
                        buffer, 0, buffer.Length)) > 0)
                    {
                        listBox1.Items.Add(
                            new string(buffer, 0, count));
                    }
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            File.Delete("juu.doc");

            listBox1.Items.Clear();

            MessageBox.Show("File deleted successfully");
        }
    


        private void button5_Click(object sender, EventArgs e)
        {
            File.WriteAllText("juu.doc", "");

            listBox1.Items.Clear();

            MessageBox.Show("All items deleted");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
    }
    
    


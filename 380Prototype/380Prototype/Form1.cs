using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _380Prototype
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("THIS IS THE QUIZ AND SURVEY PAGE TO DETERMINE YOUR INTERESTS!");
                checkBox1.Checked = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // Clear the listbox to display fresh information
            listBox2.Items.Clear();

            // Select the date and display it on the schedule label
            textBox1.Text = monthCalendar1.SelectionStart.Date.ToShortDateString();

            string[] listOfClasses = { "COMP 110", "COMP 222", "COMP 322", "COMP 482", "COMP333", "COMP310" };

            Random r = new Random();

            // How many classes to show per day
            int randomNumberOfClasses = r.Next(1, 4);

            // Add a variable number of classes randomly to daily schedule
            // TODO: remove duplicates
            for (int i = 0; i <= randomNumberOfClasses; i++)
            {
                int randomClassPicker = r.Next(listOfClasses.Length);
                listBox2.Items.Add(listOfClasses[randomClassPicker].ToString() + "\tFrom:\tTo:\tRoom:");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // retrieve more classes from the database of classes later
            string[] listOfClasses = { "COMP 110", "COMP 222", "COMP 322", "COMP 482", "COMP333", "COMP310" };

            for (int i = 0; i < listOfClasses.Length; i++) // add each class to the listbox
                listBox1.Items.Add(listOfClasses[i]);

            button2.Enabled = false;  // disable the button to disable adding the same list of classes more than once

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Cet133Assessment_2
{
    public partial class Rentals : Form
    {
        public Rentals()
        {
            InitializeComponent();
        }

      //load Summary with personal Details
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String sText;
            try
            {
                using (StreamReader sr = new StreamReader("WeAreCars.txt"))
                {
                    while (sr.Peek() != -1)
                    {
                        sText = sr.ReadLine();
                        if (sText == "")
                        {
                            txtBox.Text += Environment.NewLine;
                        }
                        else
                        {
                            txtBox.Text += sText;
                            txtBox.Text += Environment.NewLine;
                        }

                    }
                }
            }
            catch
            {
                MessageBox.Show("Error - no text file", "Missing file",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult drReply = MessageBox.Show("Exit program?", "Confirmation",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Rentals_Load(object sender, EventArgs e)
        {
            String sText;
            try
            {
                using (StreamReader sr = new StreamReader("WeAreCars.txt"))
                {
                    while (sr.Peek() != -1)
                    {
                        sText = sr.ReadLine();
                        if (sText == "")
                        {
                            txtBox.Text += Environment.NewLine;
                        }
                        else
                        {
                            txtBox.Text += sText;
                            txtBox.Text += Environment.NewLine;
                        }

                    }
                }

            }
            catch
            {
                MessageBox.Show("Error - no text file", "Missing file",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     // Go back to the booking Area
        private void btnBack_Click(object sender, EventArgs e)
        {

            DialogResult drReply = MessageBox.Show("Want to go Back?", "Confirmation",
                                                      MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Booking book = new Booking();
                book.Show();
                this.Hide();
            }

         
        }
    }
}



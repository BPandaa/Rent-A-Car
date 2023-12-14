using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cet133Assessment_2
{
    public partial class Login : Form
    {
        // Initialise 3 Attemps to login
        
        int attempt = 4;
        public Login()
        {
            InitializeComponent();
        }





        // Exit button with confirmation

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult drReply = MessageBox.Show("Exit program?", "Confirmation",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        // Login button

        private void btnLogin_Click(object sender, EventArgs e)
        {


            string username = txtUsername.Text;
            string password = txtPassWord.Text;


            // The right Username and Password 

            if ((this.txtUsername.Text == "sta001") && (this.txtPassWord.Text == "givemethekeys123"))
            {


                MessageBox.Show("You are granted with access!");
                Booking book = new Booking();
                book.Show();
                this.Hide();
            }

            // The wrong Username and Password 

            else if ((this.txtUsername.Text != "sta001") || (this.txtPassWord.Text != "givemethekeys123"))
            {

                // Empty Username 
                if (this.txtUsername.Text == "")
                {
                    MessageBox.Show("fill in the UserName please !");

                }

                // Empty Password

                else if (this.txtPassWord.Text == "")
                {
                    MessageBox.Show("fill in the Password please !");

                }

                else 
                {
                    attempt--;
                    if (attempt == 0)
                    {
                        Application.Exit();
                    }
                    MessageBox.Show("You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
                
                    txtUsername.Clear();
                    txtPassWord.Clear();
                }
                
            }

           
        }

        // Show Password

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (lbPassword.Text == "Show") 
            {
                    txtPassWord.PasswordChar = '\0';
                    lbPassword.Text = "Hide"; 
            }
            else
                {
                    txtPassWord.PasswordChar = '*';
                    lbPassword.Text = "Show";
                }
        }

       
    }
}

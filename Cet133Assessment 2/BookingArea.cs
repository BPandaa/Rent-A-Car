using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Cet133Assessment_2
{
    public partial class Booking : Form
    {
        public Booking()
        {
            InitializeComponent();
        }
        //File Directory 
        string Path = Environment.CurrentDirectory + "/" + "WeAreCars.txt";

        public static ListBox lstPublic;
        public static double dTotalPrice;


        //constant for number of type of car
        const int iCARTYPES = 4;
        //constant for number of fuel
        const int iFUELTYPES = 4;
        //constant for number of type of Optional Extras
        const int iOptionalExtras = 3;

        //initialise variables for name , surname , address , age and driving license.

        string sUserName, sAddress, sSurName;
        int iAge;

        string sDrivingLicense;



        //constants for prices

        //constants for Cars
        const int iCityCar = 0;
        const int iFamilyCar = 50;
        const int iSportCar = 75;
        const int iSUV = 65;


        //constants for fuel
        const int iPetrol = 0;
        const int iDiesel = 0;
        const int iHybrid = 30;
        const int iFullElectric = 50;

        //constants for Optional Extra
        const int iUnlimitedMileage = 10;
        const int iBreakdownCover = 2;
        const int inothing = 0;




        //class variables

        //array to hold prices for the car 
        int[] dPrices = new int[iCARTYPES];
        //array to hold prices for the fuel
        int[] iFuelType = new int[iFUELTYPES];
        //array to hold prices for optional extras
        int[] OptionalExtras = new int[iOptionalExtras];
        //array to hold images for the Car
        Image[] pPics = new Image[iCARTYPES];       
        //load images into image array





        private void Form3_Load(object sender, EventArgs e)
        {


            //Disable Add order, Get Total Price , cancel order , number of days
            //and all the Lists : car,fuel and Optional Extras
            DisableButtons();

            //create file If doesn't Exists
            if (!File.Exists(Path))
            {

                File.CreateText(Path);
            }

            //load images into image array
            pPics[0] = Cet133Assessment_2.Properties.Resources.CityCar;
            pPics[1] = Cet133Assessment_2.Properties.Resources.FamilyCar;
            pPics[2] = Cet133Assessment_2.Properties.Resources.SportCar;
            pPics[3] = Cet133Assessment_2.Properties.Resources.SUV;

           //load prices for the car
            dPrices[0] = iCityCar;
            dPrices[1] = iFamilyCar;
            dPrices[2] = iSportCar;
            dPrices[3] = iSUV;

            //load prices for the fuel
            iFuelType[0] = iPetrol;
            iFuelType[1] = iDiesel;
            iFuelType[2] = iHybrid;
            iFuelType[3] = iFullElectric;

            //load prices for the Optinal Extra
            OptionalExtras[0] = iUnlimitedMileage;
            OptionalExtras[1] = iBreakdownCover;
            OptionalExtras[2] = inothing;

            // function to reset all choices to unchosen
            ResetForm();         
    
        }


        //reset button
        private void ResetForm()
        {
            //reset controls
            picSelection.Image = global::Cet133Assessment_2.Properties.Resources.CityCar;
            lstTypeOfCar.SelectedIndex = -1;
            lstFuel.SelectedIndex = -1;
            cboDays.SelectedIndex = -1;
            lstOptionalExtras.SelectedIndex = -1;
            
        }

        // Exit button with confirmation
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            DialogResult drReply = MessageBox.Show("Exit program?", "Confirmation",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (drReply == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        //total button
        private void btnGetTotal_Click(object sender, EventArgs e)
        {
            //copy list box to public list box
            lstPublic = lstSummary;

            //display summary form
            Summary thisSummary = new Summary();
            thisSummary.ShowDialog();

            //reset form for new order
            ResetForm();
            lstSummary.Items.Clear();
            btnGetTotal.Enabled = false;
           
        }


        //Add order button
        private void btnAdd_Click(object sender, EventArgs e)
        {

            try
            {
                //type of car
                string sCar = lstTypeOfCar.SelectedItem.ToString();    

                int iCar = lstTypeOfCar.SelectedIndex;



                int iQuantity = Convert.ToInt32(cboDays.Text);


                int days = 25;
                int iday;
                //calculate price of current order line
                iday = days * iQuantity;


                //get fuel
                int ifuel = lstFuel.SelectedIndex;
                int iOx = lstOptionalExtras.SelectedIndex;





                double dPrice;

                dPrice = dPrices[iCar] + iFuelType[ifuel] + iday;

                //no optinal extras
                if (lstOptionalExtras.SelectedIndex == -1)
                {
                     dPrice = dPrices[iCar] + iFuelType[ifuel] + iday;
                    
                    lstSummary.Items.Add("**********************************");
                    lstSummary.Items.Add("Number of days : " + iQuantity);
                    lstSummary.Items.Add("Type of car : " + sCar );
                    lstSummary.Items.Add("Type of fuel : " + lstFuel.SelectedItem);
                    lstSummary.Items.Add("Total Price :  " + dPrice.ToString("C"));
                    lstSummary.Items.Add("**********************************");
                }
                //with optinal extras

                else if ((lstOptionalExtras.SelectedIndex == 0) || (lstOptionalExtras.SelectedIndex == 1) || (lstOptionalExtras.SelectedIndex == 2))
                {
                     dPrice = dPrices[iCar] + iFuelType[ifuel] + iday + OptionalExtras[iOx] * iQuantity;


                    lstSummary.Items.Add("**********************************");
                    lstSummary.Items.Add("Number of days : " + iQuantity);
                    lstSummary.Items.Add("Type of car : " + sCar);
                    lstSummary.Items.Add("Type of fuel : " + lstFuel.SelectedItem);
                    lstSummary.Items.Add("Optional Extras : " + lstOptionalExtras.SelectedItem);
                    lstSummary.Items.Add("Total Price :  " + dPrice.ToString("C"));
                    lstSummary.Items.Add("**********************************");
                }





                //increment total price of order
                dTotalPrice += dPrice;

                //reset form for new order line
                ResetForm();
                //allow user to complete order
                btnGetTotal.Enabled = true;

            }
            catch
            {
                if (lstTypeOfCar.SelectedIndex == -1)   
                {
                    //user has not selected a type of car
                    MessageBox.Show("Please choose your car type", "Car type?");
                }
                else if (lstFuel.SelectedIndex == -1)
                {
                    //user has not selected a type of fuel
                    MessageBox.Show("Please choose your Fuel Type", "Fuel type?");
                }
                else if (cboDays.SelectedIndex == -1)
                {
                    //user has not selected number of days
                    MessageBox.Show("Please choose the number of days", "Number?");
                }

          

            }

            btnBook.Enabled = true;


        }


        //cancel button
        private void btnNew_Click(object sender, EventArgs e)
        {
            //reset form for new order
            ResetForm();
            dTotalPrice = 0;
            lstSummary.Items.Clear();
            btnGetTotal.Enabled = false;
        }



        //save button
        private void btnSave_Click(object sender, EventArgs e)
        {


            if (this.txtUserName.Text == "")
            {
                //user has not typed first name
                MessageBox.Show("Please , fill in the First Name!");

            }

            else if (this.txtSurName.Text == "")
            {
                //user has not typed surname
                MessageBox.Show("Please , fill in the SurName");

            }
            else if (this.txtAddress.Text == "")
            {
                //user has not typed address
                MessageBox.Show("Please , fill in the Address");

            }
            else if (this.txtAge.Text == "")
            {
                //user has not typed age
                MessageBox.Show("Please , fill in the Age");

            }


            //if the user is a minor Program exits
            else if (iAge < 16)
            {

                DialogResult drReply = MessageBox.Show("Sorry, you're still a minor?", "Are you a minor?",
                                              MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (drReply == DialogResult.Yes)
                {
                    Application.Exit();
                }

                else
                {
                    txtAge.Clear();
                }

            }
            //if the user above 100 Program exits
            else if (iAge > 100)
            {

                DialogResult drReply = MessageBox.Show("A human over 100 can't Rent A car", "Confirmation?",
                                              MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (drReply == DialogResult.OK)
                {
                    Application.Exit();
                }

                else
                {
                    txtAge.Clear();
                }

            }




            //user has not typed Driving License

            else if (!Regex.Match(txtDrivingLicense.Text, @"^[a-zA-Z0-9]{16}$").Success)
            {
                if (this.txtDrivingLicense.Text == "")
                {
                    MessageBox.Show("Please , fill in the Driving License");

                }
                else
                {
                    MessageBox.Show("Invalid Driving License", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDrivingLicense.Clear();
                }
            }

            //file Saved
            else
            {
                using (StreamWriter sw = File.AppendText(Path))
                {
                    sw.WriteLine("**********************************");
                    sw.WriteLine("Hello! " + sSurName + " " + sUserName + ", Your are  " + iAge + " old "); 
                    sw.WriteLine("You have booked on " + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss"));
                    sw.WriteLine("With Address " + sAddress + " And your Driving License " + sDrivingLicense);
                    sw.WriteLine("**********************************");
                    MessageBox.Show("File saved!");
                    //Enable Add order, Get Total Price , cancel order , number of days
                    //and all the Lists : car,fuel and Optional Extras
                    EnableButtons();
                    btnSave.Enabled = false;
                }
            
            }

            

        }

        private void cboDrivingLisence_SelectedIndexChanged(object sender, EventArgs e)
        {

            //user has a Driving License
            if (cboDrivingLisence.Text == "Yes")
            {

                txtDrivingLicense.Visible = true;
                lblDrivingLisence1.Visible = true;
            }
            //user doesn't have a Driving License
            else if (cboDrivingLisence.Text == "No")
            {
                txtDrivingLicense.Visible = false;
                lblDrivingLisence1.Visible = false;

                DialogResult drReply = MessageBox.Show("Sorry , we can't proceed with the booking since you don't have a valid driving license ?", "Confirmation",
                                                       MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (drReply == DialogResult.OK)
                {
                    Application.Exit();
                }

                cboDrivingLisence.SelectedIndex = -1;
                
            }

        }


        //Go to rentals
        private void BtnRented_Click(object sender, EventArgs e)
        {
            Rentals Rent = new Rentals();
            Rent.Show();
            this.Hide();
        }


        //UserName Check
        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(txtUserName.Text, @"^[a-zA-Z\s]*$").Success)
            {
                sUserName = txtUserName.Text;
            }
            else
            {
                MessageBox.Show("Invalid name", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Clear();
            }
        }

        //SurName Check
        private void txtSurName_TextChanged(object sender, EventArgs e)
        {
            if (Regex.Match(txtSurName.Text, @"^[a-zA-Z\s]*$").Success)
            {
                sSurName = txtSurName.Text;
            }
            else
            {
                MessageBox.Show("Invalid SurName", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSurName.Clear();
            }
        }

        //Address Check
        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

            if (Regex.Match(txtAddress.Text, @"^[a-zA-Z0-9\s]*$").Success)
            {
                sAddress = txtAddress.Text;
            }
            else
            {
                MessageBox.Show("Invalid Address", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAddress.Clear();
            }
        }

        //Age Check
        private void txtAge_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (Regex.Match(txtAge.Text, "^[0-9]*$").Success)
                {
                    iAge = Convert.ToInt32(txtAge.Text);


                }
                else
                {
                    txtAge.Clear();
                }

            }

            catch
            {
                MessageBox.Show("Invalid Age", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //Driving License Check

        private void txtDrivingLisence_TextChanged(object sender, EventArgs e)
        {

            if (Regex.Match(txtDrivingLicense.Text, @"^[a-zA-Z0-9]*$").Success) 
            {
                sDrivingLicense = txtDrivingLicense.Text;

            }
            else
            {
                MessageBox.Show("Invalid Driving License", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDrivingLicense.Clear();
            }

        }

        //logout button
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login lgn = new Login();
            lgn.Show();
        }

       

        

      

        private void lstType_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            if (lstTypeOfCar.SelectedIndex != -1)
            {
                //display image of selected car type
                picSelection.Image = pPics[lstTypeOfCar.SelectedIndex];
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
           
            using (StreamWriter sw = File.AppendText(Path)) 
            {
                sw.WriteLine("--------------------------------------------------");
                sw.WriteLine("Total cost of order...... " + Booking.dTotalPrice.ToString("C"));
                sw.WriteLine("--------------------------------------------------");
                MessageBox.Show("Booked!");
            }

            Rentals Rent = new Rentals();
            Rent.Show();
            this.Hide();

        }


        //Enable button
        private void EnableButtons()
        {
            lstTypeOfCar.Enabled = true;
            lstFuel.Enabled = true;
            cboDays.Enabled = true;
            lstOptionalExtras.Enabled = true;
            btnNew.Enabled = true;
            btnGetTotal.Enabled = true;
            btnAdd.Enabled = true;
            

        }

        //Disable button
        private void DisableButtons()
        {
             lstTypeOfCar.Enabled = false;
             lstFuel.Enabled = false;
             cboDays.Enabled = false;
             lstOptionalExtras.Enabled = false;
             btnNew.Enabled = false;
             btnGetTotal.Enabled = false;
             btnAdd.Enabled = false;
             btnBook.Enabled= false;

        }



     }
}










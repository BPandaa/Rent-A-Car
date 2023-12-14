
namespace Cet133Assessment_2
{
    partial class Booking
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking));
            this.cboDays = new System.Windows.Forms.ComboBox();
            this.lstTypeOfCar = new System.Windows.Forms.ListBox();
            this.lstFuel = new System.Windows.Forms.ListBox();
            this.lstOptionalExtras = new System.Windows.Forms.ListBox();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.cboDrivingLisence = new System.Windows.Forms.ComboBox();
            this.BtnRented = new System.Windows.Forms.Button();
            this.lblDrivingLisence1 = new System.Windows.Forms.Label();
            this.txtDrivingLicense = new System.Windows.Forms.TextBox();
            this.txtSurName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.picboxLogo = new System.Windows.Forms.PictureBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblDrivingLisence = new System.Windows.Forms.Label();
            this.lvlAge = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblSurName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTypeCar = new System.Windows.Forms.Label();
            this.lblFuel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnGetTotal = new System.Windows.Forms.Button();
            this.lblOptional = new System.Windows.Forms.Label();
            this.lstSummary = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lvldays = new System.Windows.Forms.Label();
            this.picSelection = new System.Windows.Forms.PictureBox();
            this.btnBook = new System.Windows.Forms.Button();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).BeginInit();
            this.SuspendLayout();
            // 
            // cboDays
            // 
            this.cboDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDays.FormattingEnabled = true;
            this.cboDays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28"});
            this.cboDays.Location = new System.Drawing.Point(398, 295);
            this.cboDays.Name = "cboDays";
            this.cboDays.Size = new System.Drawing.Size(52, 24);
            this.cboDays.TabIndex = 6;
            this.cboDays.Text = "1";
            // 
            // lstTypeOfCar
            // 
            this.lstTypeOfCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTypeOfCar.FormattingEnabled = true;
            this.lstTypeOfCar.ItemHeight = 16;
            this.lstTypeOfCar.Items.AddRange(new object[] {
            "City car ",
            "Family car ",
            "Sports car ",
            "SUV "});
            this.lstTypeOfCar.Location = new System.Drawing.Point(395, 44);
            this.lstTypeOfCar.Name = "lstTypeOfCar";
            this.lstTypeOfCar.Size = new System.Drawing.Size(125, 68);
            this.lstTypeOfCar.TabIndex = 20;
            this.lstTypeOfCar.SelectedIndexChanged += new System.EventHandler(this.lstType_SelectedIndexChanged_2);
            // 
            // lstFuel
            // 
            this.lstFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFuel.FormattingEnabled = true;
            this.lstFuel.ItemHeight = 16;
            this.lstFuel.Items.AddRange(new object[] {
            "Petrol ",
            "Diesel ",
            "Hybrid ",
            "Full electric "});
            this.lstFuel.Location = new System.Drawing.Point(398, 165);
            this.lstFuel.Name = "lstFuel";
            this.lstFuel.Size = new System.Drawing.Size(76, 68);
            this.lstFuel.TabIndex = 21;
            // 
            // lstOptionalExtras
            // 
            this.lstOptionalExtras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstOptionalExtras.FormattingEnabled = true;
            this.lstOptionalExtras.ItemHeight = 16;
            this.lstOptionalExtras.Items.AddRange(new object[] {
            "Unlimited mileage ",
            "Breakdown cover ",
            "No Optional Extras"});
            this.lstOptionalExtras.Location = new System.Drawing.Point(398, 387);
            this.lstOptionalExtras.Name = "lstOptionalExtras";
            this.lstOptionalExtras.Size = new System.Drawing.Size(125, 84);
            this.lstOptionalExtras.TabIndex = 22;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.btnLogout);
            this.panelLogo.Controls.Add(this.lblFirstName);
            this.panelLogo.Controls.Add(this.cboDrivingLisence);
            this.panelLogo.Controls.Add(this.BtnRented);
            this.panelLogo.Controls.Add(this.lblDrivingLisence1);
            this.panelLogo.Controls.Add(this.txtDrivingLicense);
            this.panelLogo.Controls.Add(this.txtSurName);
            this.panelLogo.Controls.Add(this.txtAge);
            this.panelLogo.Controls.Add(this.txtAddress);
            this.panelLogo.Controls.Add(this.picboxLogo);
            this.panelLogo.Controls.Add(this.txtUserName);
            this.panelLogo.Controls.Add(this.btnSave);
            this.panelLogo.Controls.Add(this.lblDrivingLisence);
            this.panelLogo.Controls.Add(this.lvlAge);
            this.panelLogo.Controls.Add(this.lblAddress);
            this.panelLogo.Controls.Add(this.lblSurName);
            this.panelLogo.Location = new System.Drawing.Point(0, 1);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(389, 652);
            this.panelLogo.TabIndex = 23;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(249, 513);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(98, 51);
            this.btnLogout.TabIndex = 42;
            this.btnLogout.Text = "&Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.BackColor = System.Drawing.Color.DarkRed;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFirstName.Location = new System.Drawing.Point(12, 170);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(180, 18);
            this.lblFirstName.TabIndex = 40;
            this.lblFirstName.Text = "Customer First Name :";
            // 
            // cboDrivingLisence
            // 
            this.cboDrivingLisence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDrivingLisence.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDrivingLisence.FormattingEnabled = true;
            this.cboDrivingLisence.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cboDrivingLisence.Location = new System.Drawing.Point(276, 342);
            this.cboDrivingLisence.Name = "cboDrivingLisence";
            this.cboDrivingLisence.Size = new System.Drawing.Size(96, 24);
            this.cboDrivingLisence.TabIndex = 37;
            this.cboDrivingLisence.SelectedIndexChanged += new System.EventHandler(this.cboDrivingLisence_SelectedIndexChanged);
            // 
            // BtnRented
            // 
            this.BtnRented.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRented.Location = new System.Drawing.Point(129, 513);
            this.BtnRented.Name = "BtnRented";
            this.BtnRented.Size = new System.Drawing.Size(98, 51);
            this.BtnRented.TabIndex = 38;
            this.BtnRented.Text = "Show &Rented Cars";
            this.BtnRented.UseVisualStyleBackColor = true;
            this.BtnRented.Click += new System.EventHandler(this.BtnRented_Click);
            // 
            // lblDrivingLisence1
            // 
            this.lblDrivingLisence1.AutoSize = true;
            this.lblDrivingLisence1.BackColor = System.Drawing.Color.DarkRed;
            this.lblDrivingLisence1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingLisence1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDrivingLisence1.Location = new System.Drawing.Point(33, 421);
            this.lblDrivingLisence1.Name = "lblDrivingLisence1";
            this.lblDrivingLisence1.Size = new System.Drawing.Size(304, 18);
            this.lblDrivingLisence1.TabIndex = 39;
            this.lblDrivingLisence1.Text = "Please Provide a valid Driving Lisence :";
            this.lblDrivingLisence1.Visible = false;
            // 
            // txtDrivingLicense
            // 
            this.txtDrivingLicense.Location = new System.Drawing.Point(103, 463);
            this.txtDrivingLicense.Name = "txtDrivingLicense";
            this.txtDrivingLicense.Size = new System.Drawing.Size(160, 20);
            this.txtDrivingLicense.TabIndex = 37;
            this.txtDrivingLicense.Visible = false;
            this.txtDrivingLicense.TextChanged += new System.EventHandler(this.txtDrivingLisence_TextChanged);
            // 
            // txtSurName
            // 
            this.txtSurName.Location = new System.Drawing.Point(212, 212);
            this.txtSurName.Name = "txtSurName";
            this.txtSurName.Size = new System.Drawing.Size(160, 20);
            this.txtSurName.TabIndex = 12;
            this.txtSurName.TextChanged += new System.EventHandler(this.txtSurName_TextChanged);
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(212, 296);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(160, 20);
            this.txtAge.TabIndex = 16;
            this.txtAge.TextChanged += new System.EventHandler(this.txtAge_TextChanged);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(212, 258);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(160, 20);
            this.txtAddress.TabIndex = 15;
            this.txtAddress.TextChanged += new System.EventHandler(this.txtAddress_TextChanged);
            // 
            // picboxLogo
            // 
            this.picboxLogo.BackColor = System.Drawing.Color.White;
            this.picboxLogo.Image = ((System.Drawing.Image)(resources.GetObject("picboxLogo.Image")));
            this.picboxLogo.Location = new System.Drawing.Point(36, 9);
            this.picboxLogo.Name = "picboxLogo";
            this.picboxLogo.Size = new System.Drawing.Size(311, 141);
            this.picboxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxLogo.TabIndex = 1;
            this.picboxLogo.TabStop = false;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(212, 170);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(160, 20);
            this.txtUserName.TabIndex = 11;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(12, 513);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 51);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblDrivingLisence
            // 
            this.lblDrivingLisence.AutoSize = true;
            this.lblDrivingLisence.BackColor = System.Drawing.Color.DarkRed;
            this.lblDrivingLisence.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrivingLisence.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDrivingLisence.Location = new System.Drawing.Point(12, 342);
            this.lblDrivingLisence.Name = "lblDrivingLisence";
            this.lblDrivingLisence.Size = new System.Drawing.Size(232, 18);
            this.lblDrivingLisence.TabIndex = 19;
            this.lblDrivingLisence.Text = "Do you have Driving Lisence :";
            // 
            // lvlAge
            // 
            this.lvlAge.AutoSize = true;
            this.lvlAge.BackColor = System.Drawing.Color.DarkRed;
            this.lvlAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvlAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lvlAge.Location = new System.Drawing.Point(12, 295);
            this.lvlAge.Name = "lvlAge";
            this.lvlAge.Size = new System.Drawing.Size(124, 18);
            this.lvlAge.TabIndex = 13;
            this.lvlAge.Text = "Customer age :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.DarkRed;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddress.Location = new System.Drawing.Point(12, 257);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(158, 18);
            this.lblAddress.TabIndex = 14;
            this.lblAddress.Text = "Customer Address :";
            // 
            // lblSurName
            // 
            this.lblSurName.AutoSize = true;
            this.lblSurName.BackColor = System.Drawing.Color.DarkRed;
            this.lblSurName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSurName.Location = new System.Drawing.Point(12, 214);
            this.lblSurName.Name = "lblSurName";
            this.lblSurName.Size = new System.Drawing.Size(164, 18);
            this.lblSurName.TabIndex = 9;
            this.lblSurName.Text = "Customer Surname :";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(622, 433);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 51);
            this.btnAdd.TabIndex = 28;
            this.btnAdd.Text = "&Add To Order";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTypeCar
            // 
            this.lblTypeCar.AutoSize = true;
            this.lblTypeCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTypeCar.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTypeCar.Location = new System.Drawing.Point(392, 12);
            this.lblTypeCar.Name = "lblTypeCar";
            this.lblTypeCar.Size = new System.Drawing.Size(123, 16);
            this.lblTypeCar.TabIndex = 24;
            this.lblTypeCar.Text = "Select Type of car :";
            // 
            // lblFuel
            // 
            this.lblFuel.AutoSize = true;
            this.lblFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuel.ForeColor = System.Drawing.SystemColors.Window;
            this.lblFuel.Location = new System.Drawing.Point(395, 135);
            this.lblFuel.Name = "lblFuel";
            this.lblFuel.Size = new System.Drawing.Size(125, 16);
            this.lblFuel.TabIndex = 27;
            this.lblFuel.Text = "Select Type of fuel :";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.White;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(794, 514);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(98, 51);
            this.btnExit.TabIndex = 31;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.White;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(622, 514);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 51);
            this.btnNew.TabIndex = 30;
            this.btnNew.Text = "&Cancel Order";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnGetTotal
            // 
            this.btnGetTotal.BackColor = System.Drawing.Color.White;
            this.btnGetTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetTotal.Location = new System.Drawing.Point(430, 514);
            this.btnGetTotal.Name = "btnGetTotal";
            this.btnGetTotal.Size = new System.Drawing.Size(98, 51);
            this.btnGetTotal.TabIndex = 29;
            this.btnGetTotal.Text = "&Get Total Price";
            this.btnGetTotal.UseVisualStyleBackColor = false;
            this.btnGetTotal.Click += new System.EventHandler(this.btnGetTotal_Click);
            // 
            // lblOptional
            // 
            this.lblOptional.AutoSize = true;
            this.lblOptional.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOptional.ForeColor = System.Drawing.SystemColors.Window;
            this.lblOptional.Location = new System.Drawing.Point(395, 351);
            this.lblOptional.Name = "lblOptional";
            this.lblOptional.Size = new System.Drawing.Size(103, 16);
            this.lblOptional.TabIndex = 32;
            this.lblOptional.Text = "Optional extras :";
            // 
            // lstSummary
            // 
            this.lstSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSummary.FormattingEnabled = true;
            this.lstSummary.ItemHeight = 16;
            this.lstSummary.Location = new System.Drawing.Point(539, 176);
            this.lstSummary.Name = "lstSummary";
            this.lstSummary.Size = new System.Drawing.Size(355, 196);
            this.lstSummary.TabIndex = 34;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(477, 696);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(135, 48);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(57, 13);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(68, 22);
            this.txtPrice.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Price";
            // 
            // lvldays
            // 
            this.lvldays.AutoSize = true;
            this.lvldays.BackColor = System.Drawing.Color.Transparent;
            this.lvldays.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvldays.ForeColor = System.Drawing.SystemColors.Window;
            this.lvldays.Location = new System.Drawing.Point(389, 260);
            this.lvldays.Name = "lvldays";
            this.lvldays.Size = new System.Drawing.Size(150, 16);
            this.lvldays.TabIndex = 37;
            this.lvldays.Text = "Select Number of days :";
            // 
            // picSelection
            // 
            this.picSelection.BackColor = System.Drawing.Color.White;
            this.picSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSelection.ErrorImage = null;
            this.picSelection.Location = new System.Drawing.Point(677, 22);
            this.picSelection.Name = "picSelection";
            this.picSelection.Size = new System.Drawing.Size(215, 129);
            this.picSelection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picSelection.TabIndex = 35;
            this.picSelection.TabStop = false;
            // 
            // btnBook
            // 
            this.btnBook.BackColor = System.Drawing.Color.White;
            this.btnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBook.Location = new System.Drawing.Point(796, 433);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(98, 51);
            this.btnBook.TabIndex = 38;
            this.btnBook.Text = "&Book";
            this.btnBook.UseVisualStyleBackColor = false;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // Booking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(904, 586);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.lvldays);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.picSelection);
            this.Controls.Add(this.lstSummary);
            this.Controls.Add(this.lblOptional);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnGetTotal);
            this.Controls.Add(this.lblFuel);
            this.Controls.Add(this.lstFuel);
            this.Controls.Add(this.lstOptionalExtras);
            this.Controls.Add(this.cboDays);
            this.Controls.Add(this.lblTypeCar);
            this.Controls.Add(this.lstTypeOfCar);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Booking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking Area";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSelection)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picboxLogo;
        private System.Windows.Forms.ComboBox cboDays;
        private System.Windows.Forms.ListBox lstTypeOfCar;
        private System.Windows.Forms.ListBox lstFuel;
        private System.Windows.Forms.ListBox lstOptionalExtras;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label lblTypeCar;
        private System.Windows.Forms.Label lblFuel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnGetTotal;
        private System.Windows.Forms.Label lblOptional;
        private System.Windows.Forms.ListBox lstSummary;
        private System.Windows.Forms.PictureBox picSelection;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboDrivingLisence;
        private System.Windows.Forms.Button BtnRented;
        private System.Windows.Forms.Label lblDrivingLisence1;
        private System.Windows.Forms.TextBox txtDrivingLicense;
        private System.Windows.Forms.TextBox txtSurName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblDrivingLisence;
        private System.Windows.Forms.Label lvlAge;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblSurName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lvldays;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBook;
    }
}
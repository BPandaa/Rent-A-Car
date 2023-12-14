
namespace Cet133Assessment_2
{
    partial class Splash_Screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash_Screen));
            this.LblLoading = new System.Windows.Forms.Label();
            this.picboxLoading = new System.Windows.Forms.PictureBox();
            this.lblWeAreCars = new System.Windows.Forms.Label();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.center_panel = new System.Windows.Forms.Panel();
            this.progressBar = new System.Windows.Forms.Panel();
            this.TimerSplashScreen = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoading)).BeginInit();
            this.panelLogo.SuspendLayout();
            this.center_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblLoading
            // 
            this.LblLoading.AutoSize = true;
            this.LblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoading.ForeColor = System.Drawing.Color.Silver;
            this.LblLoading.Location = new System.Drawing.Point(33, 153);
            this.LblLoading.Name = "LblLoading";
            this.LblLoading.Size = new System.Drawing.Size(107, 29);
            this.LblLoading.TabIndex = 4;
            this.LblLoading.Text = "Loading";
            // 
            // picboxLoading
            // 
            this.picboxLoading.BackColor = System.Drawing.Color.Transparent;
            this.picboxLoading.Image = ((System.Drawing.Image)(resources.GetObject("picboxLoading.Image")));
            this.picboxLoading.Location = new System.Drawing.Point(137, 153);
            this.picboxLoading.Name = "picboxLoading";
            this.picboxLoading.Size = new System.Drawing.Size(45, 29);
            this.picboxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxLoading.TabIndex = 6;
            this.picboxLoading.TabStop = false;
            // 
            // lblWeAreCars
            // 
            this.lblWeAreCars.AutoSize = true;
            this.lblWeAreCars.BackColor = System.Drawing.Color.Transparent;
            this.lblWeAreCars.Font = new System.Drawing.Font("MV Boli", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWeAreCars.ForeColor = System.Drawing.Color.Black;
            this.lblWeAreCars.Location = new System.Drawing.Point(5, 21);
            this.lblWeAreCars.Name = "lblWeAreCars";
            this.lblWeAreCars.Size = new System.Drawing.Size(214, 49);
            this.lblWeAreCars.TabIndex = 7;
            this.lblWeAreCars.Text = "WeAreCars";
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.LblLoading);
            this.panelLogo.Controls.Add(this.picboxLoading);
            this.panelLogo.Controls.Add(this.center_panel);
            this.panelLogo.Controls.Add(this.lblWeAreCars);
            this.panelLogo.Location = new System.Drawing.Point(-7, -8);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 299);
            this.panelLogo.TabIndex = 8;
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.White;
            this.center_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.center_panel.Controls.Add(this.progressBar);
            this.center_panel.Location = new System.Drawing.Point(19, 77);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(185, 10);
            this.center_panel.TabIndex = 9;
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            this.progressBar.Location = new System.Drawing.Point(-8, 0);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(30, 15);
            this.progressBar.TabIndex = 6;
            // 
            // TimerSplashScreen
            // 
            this.TimerSplashScreen.Enabled = true;
            this.TimerSplashScreen.Interval = 15;
            this.TimerSplashScreen.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Splash_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 286);
            this.Controls.Add(this.panelLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spalsh Screen";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form4_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picboxLoading)).EndInit();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.center_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblLoading;
        private System.Windows.Forms.PictureBox picboxLoading;
        private System.Windows.Forms.Label lblWeAreCars;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel center_panel;
        private System.Windows.Forms.Panel progressBar;
        private System.Windows.Forms.Timer TimerSplashScreen;
    }
}
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
    public partial class Splash_Screen : Form
    {
        public Splash_Screen()
        {
            InitializeComponent();
        }

        //Movements of the Splash Screen


        //Initialise Variables
        int second = 0;
        int x, y;
        bool move; 
      

        private void Form4_MouseUp(object sender, MouseEventArgs e)
        {
            move = false;
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            move = true;
            x = e.X;
            y = e.Y;
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            if (move)
                SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
        }

        //Timer For The Progress Bar

        private void timer1_Tick(object sender, EventArgs e)
        {
            second++;
            progressBar.Left += 2;

            if (progressBar.Left + progressBar.Width > center_panel.Width + 50)
                progressBar.Left = 0;


            if (second == 300){


              
                TimerSplashScreen.Stop();
                this.Close();
            


            }

        } 
    }
}

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
    public partial class Summary : Form
    {
        public Summary()
        {
            InitializeComponent();
        }


        //Load Total Price
        private void Form5_Load(object sender, EventArgs e)
        {
            int iLength = Booking.lstPublic.Items.Count;

            for (int i = 0; i < iLength; i++)
            {
                lstOrderTotal.Items.Add(Booking.lstPublic.Items[i]);
            }

            //display order total in list box
            lstOrderTotal.Items.Add("--------------------------------------------------");
            lstOrderTotal.Items.Add("Total cost of order...... " + Booking.dTotalPrice.ToString("C"));
            lstOrderTotal.Items.Add("--------------------------------------------------");


        }

      
        //ok button
        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

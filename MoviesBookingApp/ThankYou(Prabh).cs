using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class ThankYou_Prabh_: Form
    {
        public ThankYou_Prabh_()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Dashboard_Sujal_().Show(); // Open the Dashboard form when the button is clicked
            this.Close(); // Close the Thank You form
        }
    }
}

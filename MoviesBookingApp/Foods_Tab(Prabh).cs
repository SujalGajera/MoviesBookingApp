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
    public partial class Foods_Tab_Prabh_ : Form
    {
        public Foods_Tab_Prabh_()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering for smoother rendering
            this.WindowState = FormWindowState.Normal; // Set the initial window state to normal
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(159, 75, 35); // Custom brown-orange color
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(159, 75, 35); // Custom brown-orange color
        }

        private void label5_Click(object sender, EventArgs e)
        {
             
        }

        private void Foods_Tab_Prabh__Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal; // Ensure the form is not maximized
        }
    }
}

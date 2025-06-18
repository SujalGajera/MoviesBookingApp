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
    public partial class Movies_Tab_Prabh_ : Form
    {
        public Movies_Tab_Prabh_() 
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering for smoother rendering
            this.WindowState = FormWindowState.Normal; // Set the initial window state to normal
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
     
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            


        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {

        }

        private void Movies_Tab_Prabh__Load(object sender, EventArgs e)
        {
          
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
           // this.WindowState = FormWindowState.Normal; 
        }

        private void label8_Click_1(object sender, EventArgs e)
        {

        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            new Foods_Tab_Prabh_().Show(); // Open the Foods tab when the button is clicked
            this.Hide(); // Hide the current Movies tab
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Foods_Tab_Prabh_().Show(); // Open the Foods tab when the button is clicked
            this.Hide(); // Hide the current Movies tab
        }
    }
}

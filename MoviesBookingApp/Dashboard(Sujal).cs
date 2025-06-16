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
    public partial class Dashboard_Sujal_ : Form
    {
        public Dashboard_Sujal_()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering to reduce flickering
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true); // Set optimized double buffering
            this.UpdateStyles(); // Apply the styles
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnMovies_Click(object sender, EventArgs e)
        {
            Movies_Tab_Prabh_ form = new Movies_Tab_Prabh_();
            form.Show(); // Use ShowDialog() if you want it to block interaction with the current form


        }

        private void btnFoods_Click(object sender, EventArgs e)
        {
            Foods_Tab_Prabh_ form = new Foods_Tab_Prabh_();
            form.Show(); // Use ShowDialog() if you want it to block interaction with the current form
        }


        private void btnSignin_Click(object sender, EventArgs e)
        {
            // Open the Login form when the Sign In button is clicked
            new Login_Sijan_().Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            // Open the SignUp form when the Sign Up button is clicked
            new SignUp_Sujal_().Show();
        }

        private void btnM1_Click(object sender, EventArgs e)
        {
            // Open the SignUp form when the M1 button is clicked
            new SignUp_Sujal_().Show();
        }

        private void btnM2_Click(object sender, EventArgs e)
        {
            // Open the SignUp form when the M2 button is clicked
            new SignUp_Sujal_().Show();
        }

        private void btnF1_Click(object sender, EventArgs e)
        {
            // Open the SignUp form when the F1 button is clicked
            new SignUp_Sujal_().Show();
        }

        private void btnF2_Click(object sender, EventArgs e)
        {
            // Open the SignUp form when the F2 button is clicked
            new SignUp_Sujal_().Show();
        }
    }
}
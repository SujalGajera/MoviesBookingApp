﻿using System;
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
    public partial class BookingConfirmation : Form
    {
        public BookingConfirmation()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Normal;
            this.DoubleBuffered = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BookingConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new ThankYou_Prabh_().Show(); // Open the Thank You form when the button is clicked
            this.Hide(); // Hide the current Booking Confirmation form  
        }
    }
}

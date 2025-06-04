using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class Login_Sijan_ : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "users.txt");

        public Login_Sijan_()
        {
            InitializeComponent();
            Password.UseSystemPasswordChar = true;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = Email.Text.Trim();
            string password = Password.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both email and password.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("User database not found.");
                return;
            }

            bool foundUser = false;
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 2 && parts[0] == email)
                {
                    foundUser = true;
                    string storedPassword = parts[1];

                    if (password == storedPassword)
                    {
                        MessageBox.Show("Login successful!");
                        // Redirect to your main form or dashboard here
                    }
                    else
                    {
                        MessageBox.Show("Incorrect password.");
                    }

                    return;
                }
            }

            if (!foundUser)
            {
                MessageBox.Show("Email not found. Please sign up.");
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form1 signUpForm = new Form1();
            signUpForm.ShowDialog();
        }

        private void lblForgotPassword_Click(object sender, EventArgs e)
        {
            FormResetPassword resetForm = new FormResetPassword();
            resetForm.Show();
            this.Close();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
        }
    }
}


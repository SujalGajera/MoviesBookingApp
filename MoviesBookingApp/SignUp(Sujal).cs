using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class SignUp_Sujal_ : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "users.txt");
        public SignUp_Sujal_()
        {
            InitializeComponent();

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close(); // Ensure the file exists
            }

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all details");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Passwords do not match");
                return;
            }

            if (!chkTerms.Checked)
            {
                MessageBox.Show("You must agree to the terms and conditions.");
                return;
            }

            string[] existingUsers = File.ReadAllLines(filePath);
            foreach (string line in existingUsers)
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 1 && parts[0] == email)
                {  
                    MessageBox.Show("Email already registered. Please use a different email.");
                    return;
                }
            }

            using (StreamWriter writer = new StreamWriter(filePath, true))
            { 
                writer.WriteLine($"{email},{password}");
            }

            MessageBox.Show("Registration successful! You can now log in.");
            this.Close(); // Close the sign-up form after successful registration
        }

        private bool IsValidEmail(string email)
        { 
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase);
        }
    }
}

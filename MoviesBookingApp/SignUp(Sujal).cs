using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions; // Regex for email validation
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class SignUp_Sujal_ : Form
    {
        // Define the file path for storing user data
        private string filePath = Path.Combine(Application.StartupPath, "users.txt");
        public SignUp_Sujal_()
        {
            InitializeComponent();

            // Ensure the users.txt file exists
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
            string email = txtEmail.Text.Trim(); // Trim whitespace from email input
            string password = txtPassword.Text; // Get the password input
            string confirmPassword = txtConfirmPass.Text; // Get the confirm password input

            // Validate inputs 
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                // Check if any of the fields are empty
                MessageBox.Show("Please fill in all details");
                return;
            }

            // Validate email format using a regular expression
            if (!IsValidEmail(email))
            {
                // Show an error message if the email format is invalid
                MessageBox.Show("Please enter a valid email address");
                return;
            }

            // Check if the password meets the criteria (at least 6 characters)
            if (password != confirmPassword)
            {
                // Show an error message if the passwords do not match
                MessageBox.Show("Passwords do not match");
                return;
            }

            // Check if the password is at least 6 characters long
            if (!chkTerms.Checked)
            {
                // Show an error message if the terms and conditions are not agreed to
                MessageBox.Show("You must agree to the terms and conditions.");
                return;
            }

            // Check if the email already exists in the file
            string[] existingUsers = File.ReadAllLines(filePath);
            foreach (string line in existingUsers) // Iterate through each line in the file
            {
                // Split the line by comma to get email and password
                string[] parts = line.Split(',');
                // Check if the first part (email) matches the input email
                if (parts.Length >= 1 && parts[0] == email)
                {
                    // Show an error message if the email is already registered
                    MessageBox.Show("Email already registered. Please use a different email.");
                    return;
                }
            }

            // If all validations pass, write the new user data to the file
            using (StreamWriter writer = new StreamWriter(filePath, true))
            { 
                writer.WriteLine($"{email},{password}");
            }

            MessageBox.Show("Registration successful! You can now log in.");
            this.Close(); // Close the sign-up form after successful registration
        }

        private bool IsValidEmail(string email) // Method to validate email format using a regular expression
        {
            // Regular expression pattern for validating email format
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPattern, RegexOptions.IgnoreCase); // Check if the email matches the pattern
        } 
    }
}

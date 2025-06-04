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
    public partial class FormResetPassword : Form
    {
        private string filePath = Path.Combine(Application.StartupPath, "users.txt");

        public FormResetPassword()
        {
            InitializeComponent();
            NewPass.UseSystemPasswordChar = true;
            ConfirmPass.UseSystemPasswordChar = true;
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            string email = Email1.Text.Trim();
            string newPassword = NewPass.Text;
            string confirmPassword = ConfirmPass.Text;

            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.");
                return;
            }

            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Passwords do not match.");
                return;
            }

            if (!File.Exists(filePath))
            {
                MessageBox.Show("User file not found.");
                return;
            }

            var lines = File.ReadAllLines(filePath).ToList();
            bool userFound = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] parts = lines[i].Split(',');
                if (parts.Length >= 2 && parts[0] == email)
                {
                    lines[i] = $"{email},{newPassword}";
                    userFound = true;
                    break;
                }
            }

            if (userFound)
            {
                File.WriteAllLines(filePath, lines);
                MessageBox.Show("Password reset successful!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Email not found.");
            }

            new Login_Sijan_().Show();
        }

        private bool IsValidEmail(string email)
        {
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void FormResetPassword_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

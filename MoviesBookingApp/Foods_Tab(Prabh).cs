using CinemaSeatBooking;
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
    public partial class Foods_Tab_Prabh_ : Form
    {
        public Foods_Tab_Prabh_()
        {
            InitializeComponent();
            this.DoubleBuffered = true; // Enable double buffering for smoother rendering
            this.WindowState = FormWindowState.Normal; // Set the initial window state to normal
        }

        private void cartHandler(string item, decimal price)
        {
            string fileName = "cart.txt";
            string folderPath = Application.StartupPath;
            string fullPath = Path.Combine(folderPath, fileName);

            // Format: ItemName [Price]
            string newLineText = $"{item} [{price}]";

            // If file doesn't exist, create it
            if (!File.Exists(fullPath))
            {
                File.Create(fullPath).Close();
            }

            // Append the formatted item and price
            File.AppendAllText(fullPath, newLineText + Environment.NewLine);

            MessageBox.Show($"{item} added to cart!");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartHandler("Fries", 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string fileName = "cart.txt";
            string folderPath = Application.StartupPath;
            string fullPath = Path.Combine(folderPath, fileName);

            if (!File.Exists(fullPath))
            {
                MessageBox.Show("Cart empty");
                return;
            }

            string[] lines = File.ReadAllLines(fullPath);

            if (lines.Length == 0)
            {
                MessageBox.Show("Cart empty");
                return;
            }

            decimal totalPrice = 0;
            foreach (string line in lines)
            {
                // Find the number in brackets using Regex
                Match match = Regex.Match(line, @"\[(.*?)\]");
                if (match.Success)
                {
                    if (decimal.TryParse(match.Groups[1].Value, out decimal price))
                    {
                        totalPrice += price;
                    }
                }
            }

            string content = string.Join(Environment.NewLine, lines);
            content += $"{Environment.NewLine}{Environment.NewLine}Total price: {totalPrice:C}"; // :C adds currency symbol

            MessageBox.Show("Cart contents:\n" + content);
        }


        private void button7_Click(object sender, EventArgs e)
        {
            string fileName = "cart.txt";
            string folderPath = Application.StartupPath;
            string fullPath = Path.Combine(folderPath, fileName);

            if (File.Exists(fullPath))
            {
                // Clear file content
                File.WriteAllText(fullPath, string.Empty);
                MessageBox.Show("Cart cleared!");
            }
            else
            {
                MessageBox.Show("Cart is already empty.");
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cartHandler("Popcorn", 10);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cartHandler("Ice Cream", 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cartHandler("Chicken Nuggets", 15);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cartHandler("Coke", 2);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            new NewSeatSelectionForm().Show(); // Open the Seat Selection form when the button is clicked
            this.Hide(); // Hide the current Foods tab
        }
    }
}

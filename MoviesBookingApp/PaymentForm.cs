using MoviesBookingApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSeatBooking
{
    public partial class PaymentForm : Form
    {
        public PaymentForm(string movieDetails)
        {
            InitializeComponent();
            this.Text = "Bill Summary";
            this.Size = new Size(600, 450);
            this.BackColor = Color.Black;
            this.DoubleBuffered = true; // Enable double buffering for smoother rendering
            this.WindowState = FormWindowState.Normal; // Set the initial window state to normal

            InitUI(movieDetails);
        }

        private void InitUI(string details)
        {
            Label titleLabel = new Label
            {
                Text = "Bill Summary",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Location = new Point(20, 20),
                AutoSize = true,
                ForeColor = Color.OrangeRed
            };
            this.Controls.Add(titleLabel);

            Label detailsLabel = new Label
            {
                Text = details,
                Font = new Font("Segoe UI", 10),
                Location = new Point(20, 70),
                Size = new Size(500, 80),
                ForeColor = Color.White
            };
            this.Controls.Add(detailsLabel);

            Label cardLabel = new Label
            {
                Text = "Card:",
                Location = new Point(20, 160),
                Size = new Size(50, 25),
                ForeColor = Color.White
            };
            this.Controls.Add(cardLabel);

            TextBox cardPart1 = CreateDarkTextBox(80, 160);
            this.Controls.Add(cardPart1);
            TextBox cardPart2 = CreateDarkTextBox(250, 160);
            this.Controls.Add(cardPart2);

            Label upiLabel = new Label
            {
                Text = "UPI:",
                Location = new Point(20, 200),
                Size = new Size(50, 25),
                ForeColor = Color.White
            };
            this.Controls.Add(upiLabel);

            TextBox upiBox = CreateDarkTextBox(80, 200, 320);
            this.Controls.Add(upiBox);

            Label promoLabel = new Label
            {
                Text = "Promo Code:",
                Location = new Point(20, 240),
                Size = new Size(100, 25),
                ForeColor = Color.White
            };
            this.Controls.Add(promoLabel);

            TextBox promoBox = CreateDarkTextBox(130, 240, 270);
            this.Controls.Add(promoBox);

            Button payButton = new Button
            {
                Text = "Pay Now",
                Location = new Point(200, 300),
                Size = new Size(150, 40),
                BackColor = Color.IndianRed,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            payButton.Click += (s, e) =>
            {
                MessageBox.Show("Payment processed successfully!", "Success");
                new BookingConfirmation().Show(); // Assuming BookingConfirmation is another form to show after payment 
                this.Close(); // Close the payment form after processing
            };
            this.Controls.Add(payButton);
        }

        private TextBox CreateDarkTextBox(int x, int y, int width = 150)
        {
            return new TextBox
            {
                Location = new Point(x, y),
                Width = width,
                BackColor = Color.FromArgb(30, 30, 30),
                ForeColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };
        }
    }
}


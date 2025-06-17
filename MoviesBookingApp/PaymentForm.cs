using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class PaymentForm : Form
    {
        private decimal pricePerSeat = 15;

        public PaymentForm(string movie, string date, string cinema, int seatCount, string seats)
        {
            SetupUI(movie, date, cinema, seatCount, seats);
        }

        private void SetupUI(string movie, string date, string cinema, int seatCount, string seats)
        {
            this.Size = new Size(500, 400);
            this.Text = "Bill Summary";

            Label title = new Label() { Text = "Bill Summary", Font = new Font("Segoe UI", 16, FontStyle.Bold), Location = new Point(20, 20), AutoSize = true };
            this.Controls.Add(title);

            Label movieDetails = new Label()
            {
                Text = $"Movie: {movie}\nDate: {date}\nCinema: {cinema}\nSeats: {seats}",
                Location = new Point(20, 60),
                AutoSize = true
            };
            this.Controls.Add(movieDetails);

            Label lblCard = new Label() { Text = "Card Number:", Location = new Point(20, 140) };
            TextBox txtCard = new TextBox() { Location = new Point(140, 140), Width = 300 };
            this.Controls.Add(lblCard);
            this.Controls.Add(txtCard);

            Label lblUpi = new Label() { Text = "UPI ID:", Location = new Point(20, 180) };
            TextBox txtUpi = new TextBox() { Location = new Point(140, 180), Width = 300 };
            this.Controls.Add(lblUpi);
            this.Controls.Add(txtUpi);

            Label lblPromo = new Label() { Text = "Promo Code:", Location = new Point(20, 220) };
            TextBox txtPromo = new TextBox() { Location = new Point(140, 220), Width = 300 };
            this.Controls.Add(lblPromo);
            this.Controls.Add(txtPromo);

            decimal total = seatCount * pricePerSeat;
            Label lblTotal = new Label() { Text = $"Total Amount: ${total}", Location = new Point(20, 260), AutoSize = true };
            this.Controls.Add(lblTotal);

            Button btnPay = new Button()
            {
                Text = "Pay Now",
                Location = new Point(300, 300),
                Width = 120
            };
            btnPay.Click += (s, e) =>
            {
                MessageBox.Show("Payment Successful! Enjoy your movie.");
                this.Close();
            };
            this.Controls.Add(btnPay);
        }
    }
}

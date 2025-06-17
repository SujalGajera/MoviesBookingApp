using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class SeatSelectionForm : Form
    {
        private Dictionary<Button, string> seatTypes = new Dictionary<Button, string>();
        private List<Button> selectedSeats = new List<Button>();

        public SeatSelectionForm()
        {
            SetupUI(); // Setup layout and seats
        }

        private void SetupUI()
        {
            this.Size = new Size(900, 600);
            this.Text = "Select Seats";

            // Movie info label
            Label movieInfo = new Label()
            {
                Text = "From the World of John Wick: Ballerina\nThu 12 Jun 8:00pm | Roxy Cinema - Cinema 2",
                Location = new Point(20, 20),
                AutoSize = true,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };
            this.Controls.Add(movieInfo);

            // Legend for seat types
            string[] labels = { "Your seat", "Available", "Wheelchair", "Companion", "Sofa", "Sold" };
            Color[] colors = { Color.Red, Color.Gray, Color.Blue, Color.Navy, Color.DimGray, Color.LightGray };

            for (int i = 0; i < labels.Length; i++)
            {
                Panel box = new Panel { BackColor = colors[i], Size = new Size(20, 20), Location = new Point(30 + i * 120, 80) };
                Label lbl = new Label { Text = labels[i], Location = new Point(55 + i * 120, 78), AutoSize = true };
                this.Controls.Add(box);
                this.Controls.Add(lbl);
            }

            // Screen label and line
            Label screenLabel = new Label
            {
                Text = "SCREEN",
                Location = new Point(380, 120),
                AutoSize = true,
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            this.Controls.Add(screenLabel);

            Panel screen = new Panel { BackColor = Color.WhiteSmoke, Size = new Size(700, 5), Location = new Point(100, 140) };
            this.Controls.Add(screen);

            // Seats grid
            int rows = 5, cols = 12;
            int seatSize = 30, margin = 5;
            Point start = new Point(100, 170);

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Button seat = new Button();
                    seat.Size = new Size(seatSize, seatSize);
                    seat.Location = new Point(start.X + c * (seatSize + margin), start.Y + r * (seatSize + margin));

                    if ((r == 1 && c < 2) || (r == 0 && c > 9))
                        seat.BackColor = Color.LightGray; // sold
                    else if (r == 0 && c < 2)
                        seat.BackColor = Color.Blue; // wheelchair
                    else
                        seat.BackColor = Color.Gray; // available

                    seat.Click += Seat_Click;
                    seatTypes[seat] = seat.BackColor.ToString();
                    this.Controls.Add(seat);
                }
            }

            // Next button
            Button nextBtn = new Button
            {
                Text = "Next",
                BackColor = Color.Goldenrod,
                Location = new Point(700, 500),
                Size = new Size(100, 40)
            };
            nextBtn.Click += NextBtn_Click;
            this.Controls.Add(nextBtn);

            // Bind panel paint (for example if you want to draw something later)
            Panel samplePanel = new Panel
            {
                Name = "panel4",
                BackColor = Color.Transparent,
                Size = new Size(100, 100),
                Location = new Point(50, 500)
            };
            samplePanel.Paint += panel4_Paint; // bind your paint method here
            this.Controls.Add(samplePanel);
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            Button seat = sender as Button;
            if (seat.BackColor == Color.Gray)
            {
                seat.BackColor = Color.Red;
                selectedSeats.Add(seat);
            }
            else if (seat.BackColor == Color.Red)
            {
                seat.BackColor = Color.Gray;
                selectedSeats.Remove(seat);
            }
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (selectedSeats.Count == 0)
            {
                MessageBox.Show("Please select at least one seat.");
                return;
            }

            PaymentForm pay = new PaymentForm("John Wick: Ballerina", "Thu 12 Jun 8:00pm", "Cinema 2", selectedSeats.Count, "Seats selected");
            pay.Show();
            this.Hide();
        }

        // Your custom paint method for panel4
        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, 10, 10, 80, 80); // example draw square inside panel
            pen.Dispose();
        }
    }
}
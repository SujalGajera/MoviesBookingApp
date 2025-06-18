using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSeatBooking
{
    public partial class NewSeatSelectionForm : Form
    {
        private Panel seatPanel;
        private FlowLayoutPanel showtimePanel;
        private Button paymentButton;
        private HashSet<string> selectedSeats = new HashSet<string>();

        public NewSeatSelectionForm()
        {
            InitializeComponent();
            this.Text = "Prime Cinema - Seat Selection";
            this.Size = new Size(1200, 700);
            this.BackColor = Color.Black;
            InitUI();
        }

        private void InitUI()
        {
            Label title = new Label
            {
                Text = "PRIME CINEMA",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                AutoSize = true,
                ForeColor = Color.HotPink,
                Location = new Point(20, 10)
            };
            this.Controls.Add(title);

            PictureBox poster = new PictureBox
            {
                Location = new Point(20, 50),
                Size = new Size(100, 140),
                BackColor = Color.DarkGray,
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            try
            {
                poster.Image = Image.FromFile("movie.jpg");
            }
            catch
            {
                MessageBox.Show("图片加载失败，请确认 movie.jpg 文件是否存在于 bin\\Debug\\net48 目录。");
            }
            this.Controls.Add(poster);

            Label movieDetails = new Label
            {
                Text = "Movie: Ballerina\nGenre: Action\nDuration: 2h\nRated: R18+",
                Location = new Point(130, 50),
                Size = new Size(300, 100),
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.White
            };
            this.Controls.Add(movieDetails);

            Label screenLabel = new Label
            {
                Text = "[ SCREEN ]",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Location = new Point(20, 210),
                AutoSize = true,
                ForeColor = Color.White
            };
            this.Controls.Add(screenLabel);

            seatPanel = new Panel
            {
                Location = new Point(20, 240),
                Size = new Size(800, 250),
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.DimGray
            };
            this.Controls.Add(seatPanel);
            GenerateSeats();

            showtimePanel = new FlowLayoutPanel
            {
                Location = new Point(850, 50),
                Size = new Size(300, 400),
                BorderStyle = BorderStyle.FixedSingle,
                FlowDirection = FlowDirection.TopDown,
                AutoScroll = true,
                BackColor = Color.FromArgb(30, 30, 30)
            };
            this.Controls.Add(showtimePanel);
            GenerateShowtimes();

            paymentButton = new Button
            {
                Text = "Proceed Payment",
                Location = new Point(20, 520),
                Size = new Size(180, 40),
                BackColor = Color.RoyalBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            paymentButton.Click += OpenPaymentPage;
            this.Controls.Add(paymentButton);
        }

        private void GenerateSeats()
        {
            string[] rows = { "A", "B", "C", "D" };
            int cols = 10;
            int buttonSize = 40;
            int padding = 10;

            for (int i = 0; i < rows.Length; i++)
            {
                Label rowLabel = new Label
                {
                    Text = rows[i],
                    Location = new Point(0, i * (buttonSize + padding) + 10),
                    Size = new Size(20, buttonSize),
                    Font = new Font("Segoe UI", 10, FontStyle.Bold),
                    ForeColor = Color.White
                };
                seatPanel.Controls.Add(rowLabel);

                for (int j = 0; j < cols; j++)
                {
                    Button seatBtn = new Button
                    {
                        Size = new Size(buttonSize, buttonSize),
                        Location = new Point(j * (buttonSize + padding) + 30, i * (buttonSize + padding) + 10),
                        BackColor = Color.SkyBlue,
                        Tag = $"{rows[i]}{j + 1}",
                        FlatStyle = FlatStyle.Flat
                    };

                    if ((i == 1 && j == 4) || (i == 2 && j == 2) || (i == 3 && j == 8))
                    {
                        seatBtn.BackColor = Color.MediumPurple;
                        seatBtn.Enabled = false;
                    }

                    seatBtn.Click += (s, e) =>
                    {
                        Button btn = s as Button;
                        string tag = btn.Tag.ToString();

                        if (btn.BackColor == Color.Red)
                        {
                            btn.BackColor = Color.SkyBlue;
                            selectedSeats.Remove(tag);
                        }
                        else
                        {
                            btn.BackColor = Color.Red;
                            selectedSeats.Add(tag);
                        }
                    };

                    seatPanel.Controls.Add(seatBtn);
                }
            }
        }

        private void GenerateShowtimes()
        {
            string[] times = { "8:00 PM", "9:30 PM", "10:15 PM" };

            foreach (string time in times)
            {
                Button btn = new Button
                {
                    Text = time,
                    Width = 250,
                    Height = 40,
                    Margin = new Padding(10),
                    BackColor = Color.MediumVioletRed,
                    ForeColor = Color.White,
                    FlatStyle = FlatStyle.Flat
                };
                btn.Click += (s, e) =>
                {
                    MessageBox.Show("Selected time: " + time);
                };
                showtimePanel.Controls.Add(btn);
            }
        }

        private void OpenPaymentPage(object sender, EventArgs e)
        {
            string seatList = string.Join(", ", selectedSeats);
            string summary = $"Movie: Ballerina\nDate: 12 Jun\nTime: 8:00 PM\nSeats: {seatList}";
            PaymentForm payForm = new PaymentForm(summary);
            payForm.ShowDialog();
        }
    }
}



using System;
using System.Drawing;
using System.Windows.Forms;

namespace MoviesBookingApp
{
    public partial class Prabh_s_thankyou_page : UserControl
    {
        private const int BOX_WIDTH = 180;
        private const int BOX_HEIGHT = 250;
        private const int SPACING = 30;
        private static readonly Color THEME_COLOR = Color.FromArgb(159, 75, 35);

        public Prabh_s_thankyou_page()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.Resize += Prabh_s_thankyou_page_Resize;
        }

        private void Prabh_s_thankyou_page_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            panel1.BackColor = THEME_COLOR;
            panel3.BackColor = THEME_COLOR;

            // Configure UserControl for auto-sizing
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            this.Size = new Size(800, 650);
            this.MinimumSize = new Size(600, 500);
            this.MaximumSize = new Size(1000, 800);

            // Adjust picture box sizes
            foreach (Control control in this.Controls)
            {
                if (control is PictureBox pb)
                {
                    pb.Size = new Size(BOX_WIDTH, BOX_HEIGHT);
                }
            }

            CenterElements();

            // Notify parent form to resize
            if (this.Parent is Form parentForm)
            {
                parentForm.WindowState = FormWindowState.Normal;
                parentForm.StartPosition = FormStartPosition.CenterScreen;
            }
        }

        private void Prabh_s_thankyou_page_Resize(object sender, EventArgs e)
        {
            CenterElements();
        }

        private void CenterElements()
        {
            // Center main labels
            labelThankYou.Left = (this.Width - labelThankYou.Width) / 2;
            labelSuggestion.Left = (this.Width - labelSuggestion.Width) / 2;
            labelYoureAwesome.Left = (this.Width - labelYoureAwesome.Width) / 2;

            // Position labels vertically with better spacing
            labelThankYou.Top = panel1.Bottom + 20;
            labelSuggestion.Top = labelThankYou.Bottom + 15;

            // Movie box layout (2x2) with better spacing
            int totalRowWidth = (BOX_WIDTH * 2) + SPACING;
            int startX = (this.Width - totalRowWidth) / 2;
            int startY = labelSuggestion.Bottom + 20;

            // Top row
            pictureBox1.Left = startX;
            pictureBox1.Top = startY;
            pictureBox1.Size = new Size(BOX_WIDTH, BOX_HEIGHT);

            pictureBox2.Left = pictureBox1.Right + SPACING;
            pictureBox2.Top = startY;
            pictureBox2.Size = new Size(BOX_WIDTH, BOX_HEIGHT);

            // Bottom row
            pictureBox3.Left = startX;
            pictureBox3.Top = pictureBox1.Bottom + 20;
            pictureBox3.Size = new Size(BOX_WIDTH, BOX_HEIGHT);

            pictureBox4.Left = pictureBox3.Right + SPACING;
            pictureBox4.Top = pictureBox3.Top;
            pictureBox4.Size = new Size(BOX_WIDTH, BOX_HEIGHT);

            // Position "You're Awesome" label
            labelYoureAwesome.Top = pictureBox3.Bottom + 15;

            // Position bottom panel
            panel3.Top = labelYoureAwesome.Bottom + 15;

            // Adjust total height based on content
            int totalHeight = panel3.Bottom;
            if (this.Height != totalHeight)
            {
                this.Height = totalHeight;
            }

            // Ensure panels span full width
            panel1.Width = this.Width;
            panel3.Width = this.Width;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Paint event can be removed as color is set in Load event
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Paint event can be removed as color is set in Load event
        }

        // Click events - implement if needed
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Add navigation logic for movie 1
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // Add navigation logic for movie 2
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // Add navigation logic for movie 3
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            // Add navigation logic for movie 4
        }

        private void labelThankYou_Click(object sender, EventArgs e) { }
        private void labelYoureAwesome_Click(object sender, EventArgs e) { }
        private void labelSuggestion_Click(object sender, EventArgs e) { }
    }
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaSeatBooking
{
    public partial class SeatSelectionForm : Form
    {
        private Panel seatPanel;
        private Button nextButton;

        // 座位的行和列数量
        private int rows = 5;
        private int cols = 14;

        // 特殊座位（模拟数据）
        private HashSet<(int, int)> wheelchairSeats = new HashSet<(int, int)> { (0, 4), (0, 5) };
        private HashSet<(int, int)> companionSeats = new HashSet<(int, int)> { (0, 6) }; 
        private HashSet<(int, int)> sofaSeats = new HashSet<(int, int)> { (4, 0), (4, 1), (4, 2) };
        private HashSet<(int, int)> soldSeats = new HashSet<(int, int)> { (2, 6), (2, 7), (2, 8), (2, 9) };

        public SeatSelectionForm()
        {
            InitializeComponent();
            this.Text = "Select Seats";
            this.Size = new Size(900, 600);  // 设置窗体大小
            this.DoubleBuffered = true; // 启用双缓冲以减少闪烁
            this.WindowState = FormWindowState.Normal; // 设置初始窗口状态为正常
            InitializeControls();  // 添加面板和按钮
            GenerateSeats();       // 生成座位按钮
        }

        private void InitializeControls()
        {
            // 创建可滚动面板用于容纳座位按钮
            seatPanel = new Panel
            {
                Location = new Point(20, 50),
                Size = new Size(820, 400),
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle
            };
            this.Controls.Add(seatPanel);

            // 创建“下一步”按钮
            nextButton = new Button
            {
                Text = "Next",
                Location = new Point(750, 470),
                Size = new Size(100, 40),
                BackColor = Color.Goldenrod,
                ForeColor = Color.White
            };
            nextButton.Click += NextButton_Click;
            this.Controls.Add(nextButton);
        }

        private void GenerateSeats()
        {
            int seatSize = 40;  // 单个座位宽高
            int padding = 5;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Button seatButton = new Button();
                    seatButton.Width = seatSize;
                    seatButton.Height = seatSize;
                    seatButton.Location = new Point(col * (seatSize + padding), row * (seatSize + padding));
                    seatButton.Tag = (row, col);  // 用来存储坐标信息

                    // 设置不同座位类型的颜色和外观
                    if (wheelchairSeats.Contains((row, col)))
                    {
                        seatButton.BackColor = Color.Blue;
                        seatButton.Text = "♿";
                        seatButton.ForeColor = Color.White;
                    }
                    else if (companionSeats.Contains((row, col)))
                    {
                        seatButton.BackColor = Color.Transparent;
                        seatButton.FlatStyle = FlatStyle.Flat;
                        seatButton.FlatAppearance.BorderColor = Color.Blue;
                        seatButton.Text = "C";
                    }
                    else if (sofaSeats.Contains((row, col)))
                    {
                        seatButton.BackColor = Color.DimGray;
                    }
                    else if (soldSeats.Contains((row, col)))
                    {
                        seatButton.BackColor = Color.LightGray;
                        seatButton.Enabled = false;
                        seatButton.Text = "X";
                    }
                    else
                    {
                        seatButton.BackColor = Color.Gray;
                    }

                    seatButton.Click += SeatButton_Click;
                    seatPanel.Controls.Add(seatButton); // 加入面板
                }
            }
        }

        // 点击座位时切换颜色
        private void SeatButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackColor == Color.Red)
            {
                btn.BackColor = Color.Gray;  // 取消选择
            }
            else if (btn.BackColor == Color.Gray)
            {
                btn.BackColor = Color.Red;   // 选择
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Proceed to next step...");
        }
    }
}


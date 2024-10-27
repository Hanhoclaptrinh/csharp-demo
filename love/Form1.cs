using System;
using System.Drawing;
using System.Media;
using System.Reflection.Emit;
using System.Threading;
using System.Windows.Forms;

namespace love
{
    public partial class Form1 : Form
    {

        private SoundPlayer playerBackground;
        private System.Windows.Forms.Timer timer;
        private string txtToType = "Xin chao cong chua nho ❤️";
        private int idx = 0;

        public Form1()
        {
            InitializeComponent();
            timer = new System.Windows.Forms.Timer();

            // thiết lập thời gian sự kiện xảy ra (lặp vô tận đơn vị ms)
            timer.Interval = 100; 

            // sự kiện xảy ra trong mỗi tick
            timer.Tick += Timer_Tick;

            timer.Start();
            playerBackground = new SoundPlayer("D:\\CSharp-Test\\love\\helper\\phai_chang_em_da_yeu.wav");
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // tăng dần 1 kí tự sau mỗi tick (100ms)
            if (idx < txtToType.Length)
            {
                lbTxt.Text += txtToType[idx];
                idx++;
            }
            else
            {
                // ngắt khi đã viết hết câu
                timer.Stop();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // nhạc nền được phát (lặp) kể từ lúc form chạy
            playerBackground.PlayLooping();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // đóng form dừng nhạc
            playerBackground.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbAsk.Text = "I love you too😘";
            playerButtonYes.URL = "D:\\CSharp-Test\\love\\helper\\ting.wav";
            playerButtonYes.Ctlcontrols.play();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Random random = new Random();
            int newX, newY;
            do
            {
                // tạo tọa độ mới (ngẫu nhiên) cho button khi di chuột vào (không vượt quá tầm nhìn của form)
                newX = random.Next(0, this.ClientSize.Width - btnNo.Width);
                newY = random.Next(0, this.ClientSize.Height - btnNo.Height);
                btnNo.Location = new Point(newX, newY);
                playerButtonNo.URL = "D:\\CSharp-Test\\love\\helper\\quack.wav";
                playerButtonNo.Ctlcontrols.play();
            } while (Overlapping(newX, newY));
        }

        // kiểm tra vị trí của button có bị label đè lên không
        private bool Overlapping(int x, int y)
        {
            Rectangle btnRect = new Rectangle(x, y, btnNo.Width, btnNo.Height);
            Rectangle labelRect = new Rectangle(lbTxt.Location, lbTxt.Size);

            return btnRect.IntersectsWith(labelRect);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            btnNoClick.URL = "D:\\CSharp-Test\\love\\helper\\jonnydang.wav";
            btnNoClick.Ctlcontrols.play();
        }
    }
}

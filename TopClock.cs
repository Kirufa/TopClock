using System;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;

using Timer = System.Timers.Timer;

namespace Clock
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private const int interval = 10;
        private bool isDown;
        private Point point;

        public MainForm()
        {

            InitializeComponent();
            timer = new Timer();
            timer.Interval = interval;
            timer.Elapsed += new ElapsedEventHandler(Timer_Elapsed);
            timer.SynchronizingObject = this;

            timer.Start();

            this.TopMost = true;
            isDown = false;

            point = new Point();

        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            string timestamp = DateTime.Now.ToString("HH:mm:ss.f");
            timeLbl.Text = timestamp;           
        }

        private void timeLbl_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                timer.Stop();
                this.Close();
                Application.Exit();
            }            
        }

     

        private void timeLbl_SizeChanged(object sender, EventArgs e)
        {
            this.Size = timeLbl.Size;           
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            timeLbl_SizeChanged(null, null);
        }

        private void timeLbl_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDown)
                this.Location = Point.Subtract(Cursor.Position, new Size(point));
        }

        private void timeLbl_MouseLeave(object sender, EventArgs e)
        {
            isDown = false;
        }

        private void timeLbl_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void timeLbl_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            point.X = Cursor.Position.X - this.Location.X;
            point.Y = Cursor.Position.Y - this.Location.Y;

        }

        private void timeLbl_DoubleClick(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.FromControl(this).Bounds.Width - this.Width) / 2, this.Location.Y);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();
        }
    }
}

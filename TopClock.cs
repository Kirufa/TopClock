using System;
using System.Windows.Forms;
using System.Timers;
using System.Drawing;
using System.Text;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;

using Timer = System.Timers.Timer;

namespace Clock
{
    public partial class MainForm : Form
    {
        private Timer timer;
        private const int interval = 10;
        private bool isDown;
        private Point point;
        private Size labelSize;

        private Color[] colors;
        private Color backcolor;

        private readonly string path;   

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

            labelSize = Size.Empty;

            colors = new Color[3];

            colors[0] = Color.FromArgb(176, 210, 237);
            colors[1] = Color.FromArgb(83, 109, 127);
            colors[2] = Color.FromArgb(46, 74, 97);

            backcolor = Color.FromArgb(33, 42, 58);

            this.Opacity = 0.75;

            path = Directory.GetCurrentDirectory() + @"\config.xml";    
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
                rightCMS.Show((Control)sender, e.Location);
            }            
        }

     

        private void timeLbl_SizeChanged(object sender, EventArgs e)
        {
            this.Size = timeLbl.Size;
            pictureBoxBack.Size = timeLbl.Size;

            if (pictureBoxBack.Image != null)
                pictureBoxBack.Image.Dispose();
            pictureBoxBack.Image = new Bitmap(pictureBoxBack.Width, pictureBoxBack.Height);                  
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBoxBack.Controls.Add(timeLbl);
            timeLbl.Location = Point.Empty;
            pictureBoxBack.Location = Point.Empty;

            timeLbl_SizeChanged(null, null);
            timeLbl.BackColor = Color.Transparent;

            pictureBoxBack.Image = new Bitmap(pictureBoxBack.Width, pictureBoxBack.Height);
          
            TransparencyKey = Color.White;

            if (File.Exists(path))
            {
                using (FileStream fs = new FileStream(path, FileMode.Open))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Point));
                    this.Location = (Point)xs.Deserialize(fs);
                    fs.Close();
                }
            }
            else
            {
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    XmlSerializer xs = new XmlSerializer(typeof(Point));
                    xs.Serialize(fs, Point.Empty);
                    fs.Close();
                }
            }
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

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer.Stop();

            using (FileStream fs = new FileStream(path, FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(Point));
                xs.Serialize(fs, this.Location);
                fs.Close();
            }
        }



        private void DrawBorder(Graphics g,Size border)
        {
            Bitmap back = TempClass.Bitmap;
            
            g.Clear(backcolor);

           
            for (int i = 0; i != colors.Length; ++i)
            {
                using (Pen pen = new Pen(colors[i], 1))
                    g.DrawLines(pen, new Point[] {
                        Point.Add(Point.Empty,new Size(i, i)),
                        Point.Add(new Point(0, border.Height-1),new Size(i, -i)),
                        Point.Add(new Point(border),new Size(-i-1, -i-1)),
                        Point.Add(new Point(border.Width-1, 0),new Size(-i, i)),
                        Point.Add( Point.Empty,new Size(i, i)) });
            }

            g.DrawImage(back, Point.Empty);
            back.RotateFlip(RotateFlipType.Rotate90FlipNone);
            g.DrawImage(back, new Point(border.Width - back.Width, 0));
            back.RotateFlip(RotateFlipType.Rotate90FlipNone);
            g.DrawImage(back, new Point(border.Width - back.Width, border.Height - back.Height));
            back.RotateFlip(RotateFlipType.Rotate90FlipNone);
            g.DrawImage(back, new Point(0, border.Height - back.Height));
            back.RotateFlip(RotateFlipType.Rotate90FlipNone);

        }

        private void timeLbl_Paint(object sender, PaintEventArgs e)
        {
            using (Graphics g = Graphics.FromImage(pictureBoxBack.Image))
                DrawBorder(g, e.ClipRectangle.Size);
        }

        private void moveToCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.FromControl(this).Bounds.Width - this.Width) / 2, this.Location.Y);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer.Stop();
            this.Close();
            Application.Exit();
        }

        

        private void toolStripTextBox_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox textBox = sender as ToolStripTextBox;
            float number;

            if (float.TryParse(textBox.Text, out number) &&
                number >= 0 &&
                number <= 1)
            {
                if (number < 0.2)
                    this.Opacity = 0.2;
                else
                    this.Opacity = number;
            }
        }

        private void toolStripTextBox_TopMost_TextChanged(object sender, EventArgs e)
        {
            ToolStripTextBox textBox = sender as ToolStripTextBox;
            string text = textBox.Text.ToLower();

            List<string> trueList = new List<string>(new string[] { "true", "t" });
            List<string> falseList = new List<string>(new string[] { "false", "f" });

            if (trueList.Contains(text))
                TopMost = true;

            if (falseList.Contains(text))
                TopMost = false;
        }
    }

    public class TempClass
    {
        public byte[] BmpArray;

        [XmlIgnore]
        private static string bmpString =
            "<?xml version=\"1.0\"?>" + Environment.NewLine +
            "<TempClass xmlns:xsi=\"http://www.w3.org/2001/XMLSchema-instance\" xmlns:xsd=\"http://www.w3.org/2001/XMLSchema\">" + Environment.NewLine +
            "<BmpArray>iVBORw0KGgoAAAANSUhEUgAAAAsAAAALCAIAAAAmzuBxAAAABGdBTUEAALGPC/xhBQAAAAlwSFlzAAAOwgAADsIBFShKgAAAAKZJREFUK" + 
            "FNj+A8D3379vfL829F7n7Zefbfh0ls4gqp48v7H5gsva7pnh2VVesUXBGRWB+fWQxBIBVB68e4LHqFpfukVVr7x+i6ROk4Ruh7xel6JQMQANHzu9nOB" + 
            "cXmKWlZYEQPQbqDhQN1oEnDEAHRacFoZ0HA0CThiALoc6DSg3WgScMQA9A/Q5UCnoUnAEUgF0EtAl6NJwBFUBdBXaBJwREiFlhUAtbGIhXZ2WMUAAAA" + 
            "ASUVORK5CYII=</BmpArray>" + Environment.NewLine +
            "</TempClass>";

        [XmlIgnore]
        public static Bitmap Bitmap
        {
            get
            {
                if (savedBmp == null)
                {
                    TempClass tmp;

                    XmlSerializer xs = new XmlSerializer(typeof(TempClass));

                    using (MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(TempClass.bmpString)))
                        tmp = (TempClass)xs.Deserialize(ms);

                    using (MemoryStream ms = new MemoryStream(tmp.BmpArray))
                        savedBmp = new Bitmap(ms);
                }

                return savedBmp;
            }

        }

        private static Bitmap savedBmp;    
    }
}

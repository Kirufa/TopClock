using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace BitmapToString
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(@"C:\Users\NTPUNSL-P35\Pictures\background.png");

            TempClass cla = new TempClass();
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Png);
                cla.BmpArray = ms.ToArray();
            }

            using (FileStream fs = new FileStream("temp.txt", FileMode.Create))
            {
                XmlSerializer xs = new XmlSerializer(typeof(TempClass));
                xs.Serialize(fs, cla);
                fs.Close();
            }
        }

        public class TempClass
        {
            public byte[] BmpArray;
        }
    }
}

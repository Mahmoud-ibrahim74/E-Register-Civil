using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Emgu.CV.Structure;
using Emgu.CV;
using System.Data.SqlClient;
using System.Drawing.Printing;

namespace governmental_interests
{
    public partial class temp : Form
    {
        static readonly CascadeClassifier classifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");

        public temp()
        {
            InitializeComponent();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pic.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            // Detect Image
            Graphics gr;
            Pen pen = new Pen(Color.Red, 5);
            pic.Image = Image.FromFile(openFileDialog.FileName);
            Bitmap img = new Bitmap(pic.Image);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(img);
            Rectangle[] rectangles = classifier.DetectMultiScale(grayImage, 1.4, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                gr = Graphics.FromImage(img);
                gr.DrawRectangle(pen, rectangle);
            }
            pic.Image = img;


            if (rectangles.Length == 1)
            {
                Rectangle rectCropArea = rectangles[0];
                Rectangle targetRect = face.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(pic.Image,
                                             pic.Image.Width, pic.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (face.Image != null) face.Dispose();
                face.Image = targetBitmap;
            }
            else if (rectangles.Length == 2)
            {
                Rectangle rectCropArea = rectangles[1];
                Rectangle targetRect = face.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(pic.Image,
                                             pic.Image.Width, pic.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (face.Image != null) face.Dispose();
                face.Image = targetBitmap;
            }
            else if (rectangles.Length == 3)
            {
                Rectangle rectCropArea = rectangles[2];
                Rectangle targetRect = face.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(pic.Image,
                                             pic.Image.Width, pic.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (face.Image != null) face.Dispose();
                face.Image = targetBitmap;
            }


        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            MemoryStream stream = new MemoryStream();
            pic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            byte[] img = stream.GetBuffer();

            string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
            SqlConnection cn = new SqlConnection(sqlConn);
            cn.Open();
            SqlCommand command = new SqlCommand("update RegisterCivil set Photo1 =@img ,Photo2 =@img where OrderCivilId = 176 ", cn);
            command.Parameters.AddWithValue("@img", img);
            command.ExecuteNonQuery();




            //MemoryStream stream = new MemoryStream();
            //pic.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
            //byte[] img = stream.GetBuffer();




            //FileInfo imgInfo = new FileInfo(openFileDialog.FileName);

            //double getSizeFraction = Convert.ToDouble(imgInfo.Length);
            //Console.WriteLine(getSizeFraction/1024/1024); // File Size With MB Ya 3olba





        }
    }
}

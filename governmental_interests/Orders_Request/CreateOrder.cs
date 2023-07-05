using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace governmental_interests.Orders_Request
{
    public partial class CreateOrder : Form
    {
        string path = Application.StartupPath + @"\Images\front.png";
        string path2 = Application.StartupPath + @"\Images\back.png";

        DataTable dt = new DataTable();
        public string FullName { get; set; }
        public string Address { get; set; }
        public string ID { get; set; }

        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Date { get; set; }
        public string OrderDate { get; set; }
        public string Qualification { get; set; }

        public string Gender { get; set; }
        public string Religion { get; set; }
        public string SocialStatus { get; set; }
        public string OrderDuration { get; set; }



        static readonly CascadeClassifier classifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");


        public byte[] Photo { get; set; }

        public CreateOrder()
        {
            InitializeComponent();
        }
        public CreateOrder(string getName, string getAddress, string id, string Date, byte[] img, string orderDate, string qualification, string gender, string religion, string status)
        {
            InitializeComponent();
            this.FullName = getName;
            this.Address = getAddress.Split('-').First() + "\n" + getAddress.Split('-').Last();
            this.Fname = this.FullName.Split('-').First();
            this.Lname = this.FullName.Split('-').Last();
            this.Date = Date.Replace('-', '/');
            this.Photo = img;
            this.OrderDate = orderDate.Substring(0, 7).Replace('-', '/');
            this.Qualification = qualification.Split('-').First() + "\n" + qualification.Split('-').Last();
            this.Gender = gender;
            this.Religion = religion;
            this.SocialStatus = status;

            this.ID = id;
            DateTime orderTime = Convert.ToDateTime(orderDate);
            this.OrderDuration = orderTime.AddYears(6).AddMonths(3).ToString("yyyy-MM-dd").Substring(0, 7).Replace('-', '/'); ;
            MemoryStream ms1 = new MemoryStream(img);
            FaceID.Image = Image.FromStream(ms1);





        }

        private void RemoveBackGround()
        {

        }

        public Image RoundCorners(Image StartImage, int CornerRadius, Color BackgroundColor)
        {
            CornerRadius *= 2;
            Bitmap RoundedImage = new Bitmap(StartImage.Width, StartImage.Height);
            using (Graphics g = Graphics.FromImage(RoundedImage))
            {
                g.Clear(BackgroundColor);
                g.SmoothingMode = SmoothingMode.AntiAlias;
                Brush brush = new TextureBrush(StartImage);
                GraphicsPath gp = new GraphicsPath();
                gp.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
                gp.AddArc(0 + RoundedImage.Width - CornerRadius, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                gp.AddArc(0, 0 + RoundedImage.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                g.FillPath(brush, gp);
                return RoundedImage;
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (FaceDetection.Image != null)
            {
                Image rounded;
                Image img = Bitmap.FromFile(path);
                Graphics graphicsImg = Graphics.FromImage(img);
                StringFormat format = new StringFormat();
                format.Alignment = StringAlignment.Far;
                Color Strcolor = ColorTranslator.FromHtml("#000000");
                Color StrcolorDate = ColorTranslator.FromHtml("#858585");


                string name = this.Fname + "\n" + this.Lname;
                graphicsImg.DrawString(name, new Font("Times New Roman", 28, FontStyle.Bold), new SolidBrush(Strcolor), new Point(960, 165), format);

                graphicsImg.DrawString(this.Address, new Font("Times New Roman", 28, FontStyle.Bold), new SolidBrush(Strcolor), new Point(960, 315), format);
                graphicsImg.DrawString(this.Date, new Font("Segoe UI", 28, FontStyle.Bold), new SolidBrush(StrcolorDate), new Point(280, 450), format);
                graphicsImg.DrawString(this.ID, new Font("Segoe UI", 28, FontStyle.Bold), new SolidBrush(Strcolor), new Point(960, 480), format);
                rounded = RoundCorners(FaceDetection.Image, 5, Color.Transparent);

                Image resizeRounded = new Bitmap(rounded, new Size(235, 331));
                graphicsImg.DrawImage(resizeRounded, new Point(28, 55));


                img.Save(@"Images\newFront.png");
                MessageBox.Show("تم اضافة البيانات");
                Thread.Sleep(1000);
                ID_Front.Image = null;
                ID_Front.Image = img;

            }
            else
            {
                MessageBox.Show("لا يمكن انشاء بطاقة بدون صورة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            Image img = Bitmap.FromFile(path2);
            Graphics graphicsImg = Graphics.FromImage(img);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Far;
            Color Strcolor = ColorTranslator.FromHtml("#000000");


            graphicsImg.DrawString(this.ID, new Font("Segoe UI", 15, FontStyle.Bold), new SolidBrush(Strcolor), new Point(500, 10), format);
            graphicsImg.DrawString(this.OrderDate, new Font("Segoe UI", 15, FontStyle.Bold), new SolidBrush(Strcolor), new Point(250, 10), format);
            graphicsImg.DrawString(this.Qualification, new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Strcolor), new Point(500, 50), format);
            graphicsImg.DrawString(this.Gender, new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Strcolor), new Point(500, 130), format);
            graphicsImg.DrawString(this.Religion, new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Strcolor), new Point(380, 130), format);
            graphicsImg.DrawString(this.SocialStatus, new Font("Times New Roman", 15, FontStyle.Bold), new SolidBrush(Strcolor), new Point(230, 130), format);
            graphicsImg.DrawString("البطاقة سارية حتي", new Font("Times New Roman", 16, FontStyle.Bold), new SolidBrush(Strcolor), new Point(500, 190), format);
            graphicsImg.DrawString(OrderDuration, new Font("Segoe UI", 14, FontStyle.Bold), new SolidBrush(Strcolor), new Point(350, 190), format);


    



            img.Save(@"Images\newBack.png");
            MessageBox.Show("تم اضافة البيانات");
            Thread.Sleep(1000);
            ID_Back.Image = null;
            ID_Back.Image = img;
        }

        private void AddFaceID_Click(object sender, EventArgs e)
        {

        }

        private void FaceDetector_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                FaceLoader.Visible = true;
                backgroundWorker.RunWorkerAsync("FaceDetection");
            }
        }

        private void FaceDetectors()
        {
            Graphics gr;
            Pen pen = new Pen(Color.Red, 2);
            Bitmap img = new Bitmap(FaceID.Image);
            Image<Bgr, byte> grayImage = new Image<Bgr, byte>(img);
            Rectangle[] rectangles = classifier.DetectMultiScale(grayImage, 1.4, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                gr = Graphics.FromImage(img);
                gr.DrawRectangle(pen, rectangle);
            }
            FaceID.Image = img;




            if (rectangles.Length == 1)
            {
                Rectangle rectCropArea = rectangles[0];
                Rectangle targetRect = FaceDetection.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(FaceID.Image,
                                             FaceID.Image.Width, FaceID.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (FaceDetection.Image != null) FaceDetection.Dispose();
                FaceDetection.Image = targetBitmap;
                printBtnFront.Visible = true;
                printBtnBack.Visible = true;


            }
            else if (rectangles.Length == 2)
            {
                Rectangle rectCropArea = rectangles[1];
                Rectangle targetRect = FaceDetection.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(FaceID.Image,
                                             FaceID.Image.Width, FaceID.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (FaceDetection.Image != null) FaceDetection.Dispose();
                FaceDetection.Image = targetBitmap;
                printBtnFront.Visible = true;
                printBtnBack.Visible = true;

            }
            else if (rectangles.Length == 3)
            {
                Rectangle rectCropArea = rectangles[2];
                Rectangle targetRect = FaceDetection.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(FaceID.Image,
                                             FaceID.Image.Width, FaceID.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (FaceDetection.Image != null) FaceDetection.Dispose();
                FaceDetection.Image = targetBitmap;
                printBtnFront.Visible = true;
                printBtnBack.Visible = true;

            }
            else if (rectangles.Length == 4)
            {
                Rectangle rectCropArea = rectangles[3];
                Rectangle targetRect = FaceDetection.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(FaceID.Image,
                                             FaceID.Image.Width, FaceID.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (FaceDetection.Image != null) FaceDetection.Dispose();
                FaceDetection.Image = targetBitmap;
                printBtnBack.Visible = true;
                printBtnFront.Visible = true;

            }
            else if (rectangles.Length == 5)
            {
                Rectangle rectCropArea = rectangles[4];
                Rectangle targetRect = FaceDetection.ClientRectangle;
                Bitmap targetBitmap = new Bitmap(targetRect.Width, targetRect.Height);
                using (Bitmap sourceBitmap = new Bitmap(FaceID.Image,
                                             FaceID.Image.Width, FaceID.Image.Height))
                using (Graphics g = Graphics.FromImage(targetBitmap))
                    g.DrawImage(sourceBitmap, targetRect, rectCropArea, GraphicsUnit.Pixel);
                if (FaceDetection.Image != null) FaceDetection.Dispose();
                FaceDetection.Image = targetBitmap;
                printBtnFront.Visible = true;
                printBtnBack.Visible = true;


            }
            else
            {
                MessageBox.Show("لا يمكن تحديد وجه لهذه الصورة", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void materialButton1_Click_1(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument document = new PrintDocument();

            document.PrintPage += Document_PrintPage; 

            print.Document = document;

            if (print.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }

        }

        private void Document_PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(ID_Front.ClientSize.Width, ID_Front.ClientSize.Height);

            float tgtWidthMM = 50;  // 5cm
            float tgtHeightMM = 35;  // 3.5cm
            float tgtWidthInches = tgtWidthMM / 25.4f;
            float tgtHeightInches = tgtHeightMM / 25.4f;
            float srcWidthPx = bmp.Width; //  633
            float srcHeightPx = bmp.Height; //  381
            float dpiX = srcWidthPx / tgtWidthInches;
            float dpiY = srcHeightPx / tgtHeightInches;

            bmp.SetResolution(dpiX, dpiY);

            ID_Front.DrawToBitmap(bmp, ID_Front.ClientRectangle);
            e.Graphics.DrawImage((Image)bmp, x, y);
        }
        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string ControlName = (string)e.Argument;

            if(ControlName == "FaceDetection")
            {
                FaceDetectors();
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            FaceLoader.Visible = false;

        }

        private void printBtnBack_Click(object sender, EventArgs e)
        {
            PrintDialog print = new PrintDialog();
            PrintDocument document = new PrintDocument();

            document.PrintPage += Document_PrintPage1; ;

            print.Document = document;

            if (print.ShowDialog() == DialogResult.OK)
            {
                document.Print();
            }
        }

        private void Document_PrintPage1(object sender, PrintPageEventArgs e)
        {
            //Bitmap bitmap2 = new Bitmap(ID_Back.Width, ID_Back.Height);
            //ID_Back.DrawToBitmap(bitmap2, new Rectangle(0, 0, ID_Back.Width, ID_Back.Height));
            //e.Graphics.DrawImage(bitmap2, 0, 0);



            float x = e.MarginBounds.Left;
            float y = e.MarginBounds.Top;
            Bitmap bmp = new Bitmap(ID_Back.ClientSize.Width, ID_Back.ClientSize.Height);

            float tgtWidthMM = 50;  // 5cm
            float tgtHeightMM = 35;  // 3.5cm
            float tgtWidthInches = tgtWidthMM / 25.4f;
            float tgtHeightInches = tgtHeightMM / 25.4f;
            float srcWidthPx = bmp.Width; //  633
            float srcHeightPx = bmp.Height; //  381
            float dpiX = srcWidthPx / tgtWidthInches;
            float dpiY = srcHeightPx / tgtHeightInches;

            bmp.SetResolution(dpiX, dpiY);

            ID_Back.DrawToBitmap(bmp, ID_Back.ClientRectangle);
            e.Graphics.DrawImage((Image)bmp, x, y);

        }

      











    }
}

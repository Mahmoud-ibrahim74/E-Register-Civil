namespace governmental_interests.Orders_Request
{
    partial class CreateOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateOrder));
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.FaceID = new System.Windows.Forms.PictureBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnFront = new MaterialSkin.Controls.MaterialButton();
            this.ID_Front = new System.Windows.Forms.PictureBox();
            this.ID_Back = new System.Windows.Forms.PictureBox();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.btnBack = new MaterialSkin.Controls.MaterialButton();
            this.AddFaceID = new MaterialSkin.Controls.MaterialButton();
            this.FaceDetection = new System.Windows.Forms.PictureBox();
            this.FaceDetector = new MaterialSkin.Controls.MaterialButton();
            this.printBtnFront = new MaterialSkin.Controls.MaterialButton();
            this.FaceLoader = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.printBtnBack = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Front)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceDetection)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // FaceID
            // 
            this.FaceID.Location = new System.Drawing.Point(1059, 369);
            this.FaceID.Name = "FaceID";
            this.FaceID.Size = new System.Drawing.Size(289, 316);
            this.FaceID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FaceID.TabIndex = 2;
            this.FaceID.TabStop = false;
            this.ToolTip.SetToolTip(this.FaceID, "الشخص صورة");
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // btnFront
            // 
            this.btnFront.AutoSize = false;
            this.btnFront.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFront.Depth = 0;
            this.btnFront.DrawShadows = true;
            this.btnFront.HighEmphasis = true;
            this.btnFront.Icon = null;
            this.btnFront.Location = new System.Drawing.Point(388, 415);
            this.btnFront.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnFront.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnFront.Name = "btnFront";
            this.btnFront.Size = new System.Drawing.Size(277, 42);
            this.btnFront.TabIndex = 1;
            this.btnFront.Text = "إضافة بيانات الصورة الأمامية";
            this.btnFront.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnFront.UseAccentColor = false;
            this.btnFront.UseVisualStyleBackColor = true;
            this.btnFront.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // ID_Front
            // 
            this.ID_Front.Image = ((System.Drawing.Image)(resources.GetObject("ID_Front.Image")));
            this.ID_Front.Location = new System.Drawing.Point(774, 2);
            this.ID_Front.Name = "ID_Front";
            this.ID_Front.Size = new System.Drawing.Size(574, 361);
            this.ID_Front.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ID_Front.TabIndex = 2;
            this.ID_Front.TabStop = false;
            // 
            // ID_Back
            // 
            this.ID_Back.Image = ((System.Drawing.Image)(resources.GetObject("ID_Back.Image")));
            this.ID_Back.Location = new System.Drawing.Point(12, 2);
            this.ID_Back.Name = "ID_Back";
            this.ID_Back.Size = new System.Drawing.Size(578, 361);
            this.ID_Back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ID_Back.TabIndex = 2;
            this.ID_Back.TabStop = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSize = false;
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Depth = 0;
            this.materialButton2.DrawShadows = true;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(-483, 540);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.Size = new System.Drawing.Size(186, 42);
            this.materialButton2.TabIndex = 1;
            this.materialButton2.Text = "إضافة البيانات";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // btnBack
            // 
            this.btnBack.AutoSize = false;
            this.btnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBack.Depth = 0;
            this.btnBack.DrawShadows = true;
            this.btnBack.HighEmphasis = true;
            this.btnBack.Icon = null;
            this.btnBack.Location = new System.Drawing.Point(13, 415);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(271, 42);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "إضافة بيانات الصورة الخلفية";
            this.btnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBack.UseAccentColor = false;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // AddFaceID
            // 
            this.AddFaceID.AutoSize = false;
            this.AddFaceID.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddFaceID.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddFaceID.Depth = 0;
            this.AddFaceID.DrawShadows = true;
            this.AddFaceID.HighEmphasis = true;
            this.AddFaceID.Icon = null;
            this.AddFaceID.Location = new System.Drawing.Point(7, 501);
            this.AddFaceID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddFaceID.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddFaceID.Name = "AddFaceID";
            this.AddFaceID.Size = new System.Drawing.Size(277, 42);
            this.AddFaceID.TabIndex = 4;
            this.AddFaceID.Text = "اضافة الصورة الي البطاقة";
            this.AddFaceID.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.AddFaceID.UseAccentColor = false;
            this.AddFaceID.UseVisualStyleBackColor = true;
            this.AddFaceID.Click += new System.EventHandler(this.AddFaceID_Click);
            // 
            // FaceDetection
            // 
            this.FaceDetection.Location = new System.Drawing.Point(738, 380);
            this.FaceDetection.Name = "FaceDetection";
            this.FaceDetection.Size = new System.Drawing.Size(300, 300);
            this.FaceDetection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FaceDetection.TabIndex = 2;
            this.FaceDetection.TabStop = false;
            // 
            // FaceDetector
            // 
            this.FaceDetector.AutoSize = false;
            this.FaceDetector.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.FaceDetector.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FaceDetector.Depth = 0;
            this.FaceDetector.DrawShadows = true;
            this.FaceDetector.HighEmphasis = true;
            this.FaceDetector.Icon = null;
            this.FaceDetector.Location = new System.Drawing.Point(388, 501);
            this.FaceDetector.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.FaceDetector.MouseState = MaterialSkin.MouseState.HOVER;
            this.FaceDetector.Name = "FaceDetector";
            this.FaceDetector.Size = new System.Drawing.Size(277, 42);
            this.FaceDetector.TabIndex = 5;
            this.FaceDetector.Text = "تحديد الوجه";
            this.FaceDetector.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.FaceDetector.UseAccentColor = false;
            this.FaceDetector.UseVisualStyleBackColor = true;
            this.FaceDetector.Click += new System.EventHandler(this.FaceDetector_Click);
            // 
            // printBtnFront
            // 
            this.printBtnFront.AutoSize = false;
            this.printBtnFront.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printBtnFront.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtnFront.Depth = 0;
            this.printBtnFront.DrawShadows = true;
            this.printBtnFront.HighEmphasis = true;
            this.printBtnFront.Icon = null;
            this.printBtnFront.Location = new System.Drawing.Point(388, 587);
            this.printBtnFront.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printBtnFront.MouseState = MaterialSkin.MouseState.HOVER;
            this.printBtnFront.Name = "printBtnFront";
            this.printBtnFront.Size = new System.Drawing.Size(277, 42);
            this.printBtnFront.TabIndex = 7;
            this.printBtnFront.Text = "طباعة صورة البطاقة الأمامية";
            this.printBtnFront.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printBtnFront.UseAccentColor = false;
            this.printBtnFront.UseVisualStyleBackColor = true;
            this.printBtnFront.Visible = false;
            this.printBtnFront.Click += new System.EventHandler(this.materialButton1_Click_1);
            // 
            // FaceLoader
            // 
            this.FaceLoader.AutoStart = true;
            this.FaceLoader.BackColor = System.Drawing.Color.Transparent;
            this.FaceLoader.CircleSize = 1F;
            this.FaceLoader.Location = new System.Drawing.Point(609, 90);
            this.FaceLoader.Name = "FaceLoader";
            this.FaceLoader.ProgressColor = System.Drawing.Color.Black;
            this.FaceLoader.Size = new System.Drawing.Size(150, 150);
            this.FaceLoader.TabIndex = 42;
            this.FaceLoader.Visible = false;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // printBtnBack
            // 
            this.printBtnBack.AutoSize = false;
            this.printBtnBack.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.printBtnBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtnBack.Depth = 0;
            this.printBtnBack.DrawShadows = true;
            this.printBtnBack.HighEmphasis = true;
            this.printBtnBack.Icon = null;
            this.printBtnBack.Location = new System.Drawing.Point(7, 587);
            this.printBtnBack.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.printBtnBack.MouseState = MaterialSkin.MouseState.HOVER;
            this.printBtnBack.Name = "printBtnBack";
            this.printBtnBack.Size = new System.Drawing.Size(277, 42);
            this.printBtnBack.TabIndex = 43;
            this.printBtnBack.Text = "طباعة صورة البطاقة الخلفية";
            this.printBtnBack.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.printBtnBack.UseAccentColor = false;
            this.printBtnBack.UseVisualStyleBackColor = true;
            this.printBtnBack.Visible = false;
            this.printBtnBack.Click += new System.EventHandler(this.printBtnBack_Click);
            // 
            // CreateOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1360, 697);
            this.Controls.Add(this.printBtnBack);
            this.Controls.Add(this.FaceLoader);
            this.Controls.Add(this.printBtnFront);
            this.Controls.Add(this.FaceDetector);
            this.Controls.Add(this.AddFaceID);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.materialButton2);
            this.Controls.Add(this.ID_Back);
            this.Controls.Add(this.btnFront);
            this.Controls.Add(this.FaceDetection);
            this.Controls.Add(this.FaceID);
            this.Controls.Add(this.ID_Front);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CreateOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إنشاء بطاقة الرقم القومي";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Front)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ID_Back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FaceDetection)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private MaterialSkin.Controls.MaterialButton btnFront;
        private System.Windows.Forms.PictureBox ID_Front;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private System.Windows.Forms.PictureBox ID_Back;
        private MaterialSkin.Controls.MaterialButton btnBack;
        private MaterialSkin.Controls.MaterialButton AddFaceID;
        private System.Windows.Forms.PictureBox FaceID;
        private MaterialSkin.Controls.MaterialButton FaceDetector;
        private System.Windows.Forms.PictureBox FaceDetection;
        private MaterialSkin.Controls.MaterialButton printBtnFront;
        private Guna.UI2.WinForms.Guna2ProgressIndicator FaceLoader;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private MaterialSkin.Controls.MaterialButton printBtnBack;
    }
}
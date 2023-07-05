namespace governmental_interests
{

    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            Guna.UI2.AnimatorNS.Animation animation2 = new Guna.UI2.AnimatorNS.Animation();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.start = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.panelLoader = new System.Windows.Forms.Panel();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.txt_loader = new System.Windows.Forms.Label();
            this.user = new Guna.UI2.WinForms.Guna2RadioButton();
            this.admin = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.remeberMe = new Guna.UI2.WinForms.Guna2CustomCheckBox();
            this.gotoLogin = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2ToggleSwitch1 = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.password = new Guna.UI2.WinForms.Guna2TextBox();
            this.username = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panelAnimator_Left = new Guna.UI2.WinForms.Guna2Transition();
            this.panelAnimator_Right = new Guna.UI2.WinForms.Guna2Transition();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.xuiObjectAnimator = new XanderUI.XUIObjectAnimator();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.panelRight.SuspendLayout();
            this.panelLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.guna2Panel1);
            this.panelAnimator_Left.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 600);
            this.panel1.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            this.guna2Panel1.Controls.Add(this.panelLeft);
            this.guna2Panel1.Controls.Add(this.panelRight);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.Gray;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.panelAnimator_Left.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.guna2Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2Panel1.Location = new System.Drawing.Point(59, 68);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(873, 486);
            this.guna2Panel1.TabIndex = 2;
            // 
            // panelLeft
            // 
            this.panelLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLeft.BackgroundImage")));
            this.panelLeft.Controls.Add(this.start);
            this.panelLeft.Controls.Add(this.label2);
            this.panelLeft.Controls.Add(this.guna2PictureBox1);
            this.panelLeft.Controls.Add(this.label1);
            this.panelAnimator_Left.SetDecoration(this.panelLeft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.panelLeft, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(310, 486);
            this.panelLeft.TabIndex = 0;
            // 
            // start
            // 
            this.start.Animated = true;
            this.start.AutoRoundedCorners = true;
            this.start.BackColor = System.Drawing.Color.Transparent;
            this.start.BorderRadius = 29;
            this.start.CheckedState.Parent = this.start;
            this.start.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start.CustomImages.Parent = this.start;
            this.panelAnimator_Left.SetDecoration(this.start, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.start, Guna.UI2.AnimatorNS.DecorationType.None);
            this.start.FillColor = System.Drawing.Color.DodgerBlue;
            this.start.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.start.ForeColor = System.Drawing.Color.White;
            this.start.HoverState.Parent = this.start;
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.start.ImageSize = new System.Drawing.Size(30, 30);
            this.start.Location = new System.Drawing.Point(37, 376);
            this.start.Name = "start";
            this.start.ShadowDecoration.Parent = this.start;
            this.start.Size = new System.Drawing.Size(242, 61);
            this.start.TabIndex = 3;
            this.start.Text = "ابدأ";
            this.start.UseTransparentBackground = true;
            this.start.Click += new System.EventHandler(this.guna2Button3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator_Left.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.label2, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 75);
            this.label2.TabIndex = 2;
            this.label2.Text = "نظام السجل المدني الإلكتروني \r\nهو نظام خاص بالحكومة لتنفيذ\r\nعمليات وطلبات المواطن" +
    "ين";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 90;
            this.panelAnimator_Left.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.guna2PictureBox1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.Location = new System.Drawing.Point(63, 17);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.ShadowDecoration.Parent = this.guna2PictureBox1;
            this.guna2PictureBox1.Size = new System.Drawing.Size(176, 172);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 1;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator_Left.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.label1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(45, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "مرحبا بكم في نظامنا";
            // 
            // panelRight
            // 
            this.panelRight.Controls.Add(this.panelLoader);
            this.panelRight.Controls.Add(this.user);
            this.panelRight.Controls.Add(this.admin);
            this.panelRight.Controls.Add(this.label3);
            this.panelRight.Controls.Add(this.remeberMe);
            this.panelRight.Controls.Add(this.gotoLogin);
            this.panelRight.Controls.Add(this.guna2ToggleSwitch1);
            this.panelRight.Controls.Add(this.password);
            this.panelRight.Controls.Add(this.username);
            this.panelRight.Controls.Add(this.label4);
            this.panelAnimator_Left.SetDecoration(this.panelRight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.panelRight, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelRight.Location = new System.Drawing.Point(310, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(560, 486);
            this.panelRight.TabIndex = 1;
            // 
            // panelLoader
            // 
            this.panelLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(53)))));
            this.panelLoader.Controls.Add(this.guna2ProgressIndicator1);
            this.panelLoader.Controls.Add(this.txt_loader);
            this.panelAnimator_Left.SetDecoration(this.panelLoader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.panelLoader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelLoader.Location = new System.Drawing.Point(52, 72);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.Size = new System.Drawing.Size(480, 397);
            this.panelLoader.TabIndex = 9;
            this.panelLoader.Visible = false;
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.AutoStart = true;
            this.guna2ProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressIndicator1.CircleSize = 1F;
            this.panelAnimator_Left.SetDecoration(this.guna2ProgressIndicator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.guna2ProgressIndicator1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(141, 126);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.ProgressColor = System.Drawing.Color.Transparent;
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(196, 196);
            this.guna2ProgressIndicator1.TabIndex = 41;
            // 
            // txt_loader
            // 
            this.txt_loader.AutoSize = true;
            this.txt_loader.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator_Left.SetDecoration(this.txt_loader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.txt_loader, Guna.UI2.AnimatorNS.DecorationType.None);
            this.txt_loader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_loader.ForeColor = System.Drawing.Color.White;
            this.txt_loader.Location = new System.Drawing.Point(159, 50);
            this.txt_loader.Name = "txt_loader";
            this.txt_loader.Size = new System.Drawing.Size(170, 50);
            this.txt_loader.TabIndex = 1;
            this.txt_loader.Text = "جاري تسجيل الدخول \r\n      برجاء الإنتظار";
            this.txt_loader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user.CheckedState.BorderThickness = 0;
            this.user.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.user.CheckedState.InnerColor = System.Drawing.Color.White;
            this.user.CheckedState.InnerOffset = -4;
            this.panelAnimator_Left.SetDecoration(this.user, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.user, Guna.UI2.AnimatorNS.DecorationType.None);
            this.user.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.user.ForeColor = System.Drawing.Color.Teal;
            this.user.Location = new System.Drawing.Point(84, 259);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(95, 29);
            this.user.TabIndex = 64;
            this.user.Text = "مستخدم";
            this.user.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.user.UncheckedState.BorderThickness = 2;
            this.user.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.user.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // admin
            // 
            this.admin.AutoSize = true;
            this.admin.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admin.CheckedState.BorderThickness = 0;
            this.admin.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.admin.CheckedState.InnerColor = System.Drawing.Color.White;
            this.admin.CheckedState.InnerOffset = -4;
            this.panelAnimator_Left.SetDecoration(this.admin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.admin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.admin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.admin.ForeColor = System.Drawing.Color.Teal;
            this.admin.Location = new System.Drawing.Point(407, 259);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(90, 29);
            this.admin.TabIndex = 63;
            this.admin.Text = "مسؤول";
            this.admin.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.admin.UncheckedState.BorderThickness = 2;
            this.admin.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.admin.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator_Left.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.label3, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Teal;
            this.label3.Location = new System.Drawing.Point(414, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 25);
            this.label3.TabIndex = 62;
            this.label3.Text = "تذكرني";
            // 
            // remeberMe
            // 
            this.remeberMe.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remeberMe.CheckedState.BorderRadius = 2;
            this.remeberMe.CheckedState.BorderThickness = 0;
            this.remeberMe.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.remeberMe.CheckedState.Parent = this.remeberMe;
            this.panelAnimator_Right.SetDecoration(this.remeberMe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Left.SetDecoration(this.remeberMe, Guna.UI2.AnimatorNS.DecorationType.None);
            this.remeberMe.Location = new System.Drawing.Point(317, 333);
            this.remeberMe.Name = "remeberMe";
            this.remeberMe.ShadowDecoration.Parent = this.remeberMe;
            this.remeberMe.Size = new System.Drawing.Size(20, 20);
            this.remeberMe.TabIndex = 61;
            this.remeberMe.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.remeberMe.UncheckedState.BorderRadius = 2;
            this.remeberMe.UncheckedState.BorderThickness = 0;
            this.remeberMe.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.remeberMe.UncheckedState.Parent = this.remeberMe;
            // 
            // gotoLogin
            // 
            this.gotoLogin.Animated = true;
            this.gotoLogin.AutoRoundedCorners = true;
            this.gotoLogin.BorderRadius = 29;
            this.gotoLogin.CheckedState.Parent = this.gotoLogin;
            this.gotoLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gotoLogin.CustomImages.Parent = this.gotoLogin;
            this.panelAnimator_Left.SetDecoration(this.gotoLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.gotoLogin, Guna.UI2.AnimatorNS.DecorationType.None);
            this.gotoLogin.FillColor = System.Drawing.Color.SteelBlue;
            this.gotoLogin.FillColor2 = System.Drawing.Color.SteelBlue;
            this.gotoLogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gotoLogin.ForeColor = System.Drawing.Color.White;
            this.gotoLogin.HoverState.FillColor = System.Drawing.Color.SlateBlue;
            this.gotoLogin.HoverState.FillColor2 = System.Drawing.Color.SlateBlue;
            this.gotoLogin.HoverState.ForeColor = System.Drawing.Color.White;
            this.gotoLogin.HoverState.Parent = this.gotoLogin;
            this.gotoLogin.Image = ((System.Drawing.Image)(resources.GetObject("gotoLogin.Image")));
            this.gotoLogin.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.gotoLogin.Location = new System.Drawing.Point(119, 386);
            this.gotoLogin.Name = "gotoLogin";
            this.gotoLogin.ShadowDecoration.Parent = this.gotoLogin;
            this.gotoLogin.Size = new System.Drawing.Size(337, 60);
            this.gotoLogin.TabIndex = 60;
            this.gotoLogin.Text = "تسجيل الدخول";
            this.gotoLogin.Visible = false;
            this.gotoLogin.Click += new System.EventHandler(this.guna2GradientButton66_Click);
            // 
            // guna2ToggleSwitch1
            // 
            this.guna2ToggleSwitch1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.CheckedState.Parent = this.guna2ToggleSwitch1;
            this.panelAnimator_Right.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Left.SetDecoration(this.guna2ToggleSwitch1, Guna.UI2.AnimatorNS.DecorationType.None);
            this.guna2ToggleSwitch1.Location = new System.Drawing.Point(97, 201);
            this.guna2ToggleSwitch1.Name = "guna2ToggleSwitch1";
            this.guna2ToggleSwitch1.ShadowDecoration.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.Size = new System.Drawing.Size(35, 20);
            this.guna2ToggleSwitch1.TabIndex = 6;
            this.guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.guna2ToggleSwitch1.UncheckedState.Parent = this.guna2ToggleSwitch1;
            this.guna2ToggleSwitch1.CheckedChanged += new System.EventHandler(this.guna2ToggleSwitch1_CheckedChanged);
            // 
            // password
            // 
            this.password.Animated = true;
            this.password.BorderRadius = 3;
            this.password.BorderThickness = 0;
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelAnimator_Left.SetDecoration(this.password, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.password, Guna.UI2.AnimatorNS.DecorationType.None);
            this.password.DefaultText = "";
            this.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.DisabledState.Parent = this.password;
            this.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password.FillColor = System.Drawing.Color.WhiteSmoke;
            this.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.FocusedState.Parent = this.password;
            this.password.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password.HoverState.Parent = this.password;
            this.password.IconRight = ((System.Drawing.Image)(resources.GetObject("password.IconRight")));
            this.password.Location = new System.Drawing.Point(84, 178);
            this.password.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password.Name = "password";
            this.password.PasswordChar = '●';
            this.password.PlaceholderForeColor = System.Drawing.Color.Black;
            this.password.PlaceholderText = "كلمة المرور";
            this.password.SelectedText = "";
            this.password.ShadowDecoration.Parent = this.password;
            this.password.Size = new System.Drawing.Size(413, 55);
            this.password.TabIndex = 3;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // username
            // 
            this.username.Animated = true;
            this.username.BorderRadius = 3;
            this.username.BorderThickness = 0;
            this.username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.panelAnimator_Left.SetDecoration(this.username, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.username, Guna.UI2.AnimatorNS.DecorationType.None);
            this.username.DefaultText = "";
            this.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.DisabledState.Parent = this.username;
            this.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username.FillColor = System.Drawing.Color.WhiteSmoke;
            this.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.FocusedState.Parent = this.username;
            this.username.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.username.ForeColor = System.Drawing.Color.Black;
            this.username.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username.HoverState.Parent = this.username;
            this.username.IconRight = ((System.Drawing.Image)(resources.GetObject("username.IconRight")));
            this.username.Location = new System.Drawing.Point(84, 86);
            this.username.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.PlaceholderForeColor = System.Drawing.Color.Black;
            this.username.PlaceholderText = "اسم المستخدم";
            this.username.SelectedText = "";
            this.username.ShadowDecoration.Parent = this.username;
            this.username.Size = new System.Drawing.Size(413, 55);
            this.username.TabIndex = 2;
            this.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.panelAnimator_Left.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this.label4, Guna.UI2.AnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Teal;
            this.label4.Location = new System.Drawing.Point(204, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 32);
            this.label4.TabIndex = 1;
            this.label4.Text = "تسجيل الدخول";
            // 
            // panelAnimator_Left
            // 
            this.panelAnimator_Left.AnimationType = Guna.UI2.AnimatorNS.AnimationType.HorizSlide;
            this.panelAnimator_Left.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.panelAnimator_Left.DefaultAnimation = animation1;
            // 
            // panelAnimator_Right
            // 
            this.panelAnimator_Right.AnimationType = Guna.UI2.AnimatorNS.AnimationType.VertSlide;
            this.panelAnimator_Right.Cursor = null;
            animation2.AnimateOnlyDifferences = true;
            animation2.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.BlindCoeff")));
            animation2.LeafCoeff = 0F;
            animation2.MaxTime = 1F;
            animation2.MinTime = 0F;
            animation2.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicCoeff")));
            animation2.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation2.MosaicShift")));
            animation2.MosaicSize = 0;
            animation2.Padding = new System.Windows.Forms.Padding(0);
            animation2.RotateCoeff = 0F;
            animation2.RotateLimit = 0F;
            animation2.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.ScaleCoeff")));
            animation2.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation2.SlideCoeff")));
            animation2.TimeCoeff = 0F;
            animation2.TransparencyCoeff = 0F;
            this.panelAnimator_Right.DefaultAnimation = animation2;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.panel1);
            this.panelAnimator_Left.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.panelAnimator_Right.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.None);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تسجيل الدخول";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.login_FormClosing);
            this.panel1.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.panelLoader.ResumeLayout(false);
            this.panelLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Panel panelRight;
        private System.Windows.Forms.Panel panelLeft;
        private Guna.UI2.WinForms.Guna2Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox username;
        private Guna.UI2.WinForms.Guna2TextBox password;
        private Guna.UI2.WinForms.Guna2ToggleSwitch guna2ToggleSwitch1;
        private System.Windows.Forms.Panel panelLoader;
        private System.Windows.Forms.Label txt_loader;
        private Guna.UI2.WinForms.Guna2Transition panelAnimator_Right;
        private Guna.UI2.WinForms.Guna2Transition panelAnimator_Left;
        private Guna.UI2.WinForms.Guna2GradientButton gotoLogin;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private Guna.UI2.WinForms.Guna2CustomCheckBox remeberMe;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RadioButton user;
        private Guna.UI2.WinForms.Guna2RadioButton admin;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
    }
}


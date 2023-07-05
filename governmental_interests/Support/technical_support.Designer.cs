namespace governmental_interests.Support
{
    partial class technical_support
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(technical_support));
            this.ToolTip = new Guna.UI2.WinForms.Guna2HtmlToolTip();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.xuiObjectAnimator = new XanderUI.XUIObjectAnimator();
            this.panelLoader = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2ProgressIndicator1 = new Guna.UI2.WinForms.Guna2ProgressIndicator();
            this.textLoading = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.support_left = new System.Windows.Forms.Label();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.loader = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.send = new MaterialSkin.Controls.MaterialButton();
            this.label6 = new System.Windows.Forms.Label();
            this.service_type = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.phone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.email = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.name = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.employee_name = new Guna.UI2.WinForms.Guna2TextBox();
            this.emp_message = new System.Windows.Forms.RichTextBox();
            this.support_view = new System.Windows.Forms.DataGridView();
            this.panelLoader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.support_view)).BeginInit();
            this.SuspendLayout();
            // 
            // ToolTip
            // 
            this.ToolTip.AllowLinksHandling = true;
            this.ToolTip.MaximumSize = new System.Drawing.Size(0, 0);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif;" +
    " *.png";
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // panelLoader
            // 
            this.panelLoader.BorderRadius = 20;
            this.panelLoader.Controls.Add(this.guna2ProgressIndicator1);
            this.panelLoader.Controls.Add(this.textLoading);
            this.panelLoader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.panelLoader.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(41)))), ((int)(((byte)(123)))));
            this.panelLoader.Location = new System.Drawing.Point(0, 0);
            this.panelLoader.Name = "panelLoader";
            this.panelLoader.ShadowDecoration.Parent = this.panelLoader;
            this.panelLoader.Size = new System.Drawing.Size(1310, 298);
            this.panelLoader.TabIndex = 40;
            this.panelLoader.Visible = false;
            // 
            // guna2ProgressIndicator1
            // 
            this.guna2ProgressIndicator1.AutoStart = true;
            this.guna2ProgressIndicator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ProgressIndicator1.CircleSize = 1F;
            this.guna2ProgressIndicator1.Location = new System.Drawing.Point(622, 99);
            this.guna2ProgressIndicator1.Name = "guna2ProgressIndicator1";
            this.guna2ProgressIndicator1.ProgressColor = System.Drawing.Color.White;
            this.guna2ProgressIndicator1.Size = new System.Drawing.Size(142, 142);
            this.guna2ProgressIndicator1.TabIndex = 40;
            // 
            // textLoading
            // 
            this.textLoading.AutoSize = true;
            this.textLoading.BackColor = System.Drawing.Color.Transparent;
            this.textLoading.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLoading.ForeColor = System.Drawing.Color.White;
            this.textLoading.Location = new System.Drawing.Point(622, 41);
            this.textLoading.Name = "textLoading";
            this.textLoading.Size = new System.Drawing.Size(142, 32);
            this.textLoading.TabIndex = 39;
            this.textLoading.Text = "جاري التحميل";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.support_left);
            this.panel2.Controls.Add(this.materialButton1);
            this.panel2.Controls.Add(this.loader);
            this.panel2.Controls.Add(this.panelLoader);
            this.panel2.Controls.Add(this.send);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.service_type);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.phone);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.email);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.employee_name);
            this.panel2.Controls.Add(this.emp_message);
            this.panel2.Controls.Add(this.support_view);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1310, 680);
            this.panel2.TabIndex = 2;
            // 
            // support_left
            // 
            this.support_left.AutoSize = true;
            this.support_left.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.support_left.Location = new System.Drawing.Point(1111, 633);
            this.support_left.Name = "support_left";
            this.support_left.Size = new System.Drawing.Size(188, 21);
            this.support_left.TabIndex = 60;
            this.support_left.Text = ":   اجمالي عدد الاستطلاعات ";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSize = false;
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.materialButton1.Depth = 0;
            this.materialButton1.DrawShadows = true;
            this.materialButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = ((System.Drawing.Image)(resources.GetObject("materialButton1.Icon")));
            this.materialButton1.Location = new System.Drawing.Point(1039, 332);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.Size = new System.Drawing.Size(258, 46);
            this.materialButton1.TabIndex = 59;
            this.materialButton1.Text = "عرض الاستطلاعات";
            this.materialButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // loader
            // 
            this.loader.AnimationSpeed = 90;
            this.loader.AutoStart = true;
            this.loader.BackColor = System.Drawing.Color.Transparent;
            this.loader.CircleSize = 5F;
            this.loader.Location = new System.Drawing.Point(1131, 422);
            this.loader.Name = "loader";
            this.loader.ProgressColor = System.Drawing.Color.Black;
            this.loader.Size = new System.Drawing.Size(84, 84);
            this.loader.TabIndex = 58;
            this.loader.Visible = false;
            // 
            // send
            // 
            this.send.AutoSize = false;
            this.send.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.Depth = 0;
            this.send.DrawShadows = true;
            this.send.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.send.HighEmphasis = true;
            this.send.Icon = ((System.Drawing.Image)(resources.GetObject("send.Icon")));
            this.send.Location = new System.Drawing.Point(1039, 515);
            this.send.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.send.MouseState = MaterialSkin.MouseState.HOVER;
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(258, 46);
            this.send.TabIndex = 57;
            this.send.Text = "ارسال الاستطلاع";
            this.send.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.send.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.send.UseAccentColor = false;
            this.send.UseVisualStyleBackColor = true;
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(812, 582);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 21);
            this.label6.TabIndex = 56;
            this.label6.Text = "نوع الخدمة";
            // 
            // service_type
            // 
            this.service_type.BackColor = System.Drawing.Color.Transparent;
            this.service_type.BorderRadius = 10;
            this.service_type.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.service_type.DefaultText = "";
            this.service_type.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.service_type.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.service_type.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.service_type.DisabledState.Parent = this.service_type;
            this.service_type.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.service_type.FillColor = System.Drawing.Color.SlateBlue;
            this.service_type.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.service_type.FocusedState.Parent = this.service_type;
            this.service_type.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.service_type.ForeColor = System.Drawing.Color.White;
            this.service_type.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.service_type.HoverState.Parent = this.service_type;
            this.service_type.Location = new System.Drawing.Point(492, 608);
            this.service_type.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.service_type.Name = "service_type";
            this.service_type.PasswordChar = '\0';
            this.service_type.PlaceholderText = "";
            this.service_type.ReadOnly = true;
            this.service_type.SelectedText = "";
            this.service_type.ShadowDecoration.Depth = 20;
            this.service_type.ShadowDecoration.Parent = this.service_type;
            this.service_type.Size = new System.Drawing.Size(399, 46);
            this.service_type.TabIndex = 55;
            this.service_type.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.Location = new System.Drawing.Point(812, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 54;
            this.label5.Text = "رقم الهاتف";
            // 
            // phone
            // 
            this.phone.BackColor = System.Drawing.Color.Transparent;
            this.phone.BorderRadius = 10;
            this.phone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phone.DefaultText = "";
            this.phone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.phone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.phone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.DisabledState.Parent = this.phone;
            this.phone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.phone.FillColor = System.Drawing.Color.SlateBlue;
            this.phone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.FocusedState.Parent = this.phone;
            this.phone.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.phone.ForeColor = System.Drawing.Color.White;
            this.phone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.phone.HoverState.Parent = this.phone;
            this.phone.Location = new System.Drawing.Point(492, 516);
            this.phone.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.phone.Name = "phone";
            this.phone.PasswordChar = '\0';
            this.phone.PlaceholderText = "";
            this.phone.ReadOnly = true;
            this.phone.SelectedText = "";
            this.phone.ShadowDecoration.Depth = 20;
            this.phone.ShadowDecoration.Parent = this.phone;
            this.phone.Size = new System.Drawing.Size(399, 46);
            this.phone.TabIndex = 53;
            this.phone.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(779, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 21);
            this.label4.TabIndex = 52;
            this.label4.Text = "البريد الالكتروني";
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.BorderRadius = 10;
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.DefaultText = "";
            this.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.DisabledState.Parent = this.email;
            this.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.email.FillColor = System.Drawing.Color.SlateBlue;
            this.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.FocusedState.Parent = this.email;
            this.email.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.email.ForeColor = System.Drawing.Color.White;
            this.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.email.HoverState.Parent = this.email;
            this.email.Location = new System.Drawing.Point(492, 424);
            this.email.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.email.Name = "email";
            this.email.PasswordChar = '\0';
            this.email.PlaceholderText = "";
            this.email.ReadOnly = true;
            this.email.SelectedText = "";
            this.email.ShadowDecoration.Depth = 20;
            this.email.ShadowDecoration.Parent = this.email;
            this.email.Size = new System.Drawing.Size(399, 46);
            this.email.TabIndex = 51;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(796, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 21);
            this.label3.TabIndex = 50;
            this.label3.Text = "الاسم بالكامل";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(365, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 49;
            this.label2.Text = "الرسالة";
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.BorderRadius = 10;
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.DefaultText = "";
            this.name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.DisabledState.Parent = this.name;
            this.name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.name.FillColor = System.Drawing.Color.SlateBlue;
            this.name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.FocusedState.Parent = this.name;
            this.name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.name.HoverState.Parent = this.name;
            this.name.Location = new System.Drawing.Point(492, 332);
            this.name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.name.Name = "name";
            this.name.PasswordChar = '\0';
            this.name.PlaceholderText = "";
            this.name.SelectedText = "";
            this.name.ShadowDecoration.Depth = 20;
            this.name.ShadowDecoration.Parent = this.name;
            this.name.Size = new System.Drawing.Size(399, 46);
            this.name.TabIndex = 48;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(325, 582);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "اسم الموظف";
            // 
            // employee_name
            // 
            this.employee_name.BackColor = System.Drawing.Color.Transparent;
            this.employee_name.BorderRadius = 10;
            this.employee_name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.employee_name.DefaultText = "";
            this.employee_name.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.employee_name.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.employee_name.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employee_name.DisabledState.Parent = this.employee_name;
            this.employee_name.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.employee_name.FillColor = System.Drawing.Color.SlateBlue;
            this.employee_name.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employee_name.FocusedState.Parent = this.employee_name;
            this.employee_name.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.employee_name.ForeColor = System.Drawing.Color.White;
            this.employee_name.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.employee_name.HoverState.Parent = this.employee_name;
            this.employee_name.Location = new System.Drawing.Point(23, 608);
            this.employee_name.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.employee_name.Name = "employee_name";
            this.employee_name.PasswordChar = '\0';
            this.employee_name.PlaceholderText = "";
            this.employee_name.ReadOnly = true;
            this.employee_name.SelectedText = "";
            this.employee_name.ShadowDecoration.Depth = 20;
            this.employee_name.ShadowDecoration.Parent = this.employee_name;
            this.employee_name.Size = new System.Drawing.Size(399, 46);
            this.employee_name.TabIndex = 45;
            this.employee_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // emp_message
            // 
            this.emp_message.BackColor = System.Drawing.Color.SlateBlue;
            this.emp_message.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emp_message.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.emp_message.Location = new System.Drawing.Point(23, 339);
            this.emp_message.Name = "emp_message";
            this.emp_message.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.emp_message.Size = new System.Drawing.Size(399, 222);
            this.emp_message.TabIndex = 44;
            this.emp_message.Text = "";
            // 
            // support_view
            // 
            this.support_view.AllowUserToAddRows = false;
            this.support_view.AllowUserToDeleteRows = false;
            this.support_view.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.support_view.BackgroundColor = System.Drawing.Color.White;
            this.support_view.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.support_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.support_view.Dock = System.Windows.Forms.DockStyle.Top;
            this.support_view.GridColor = System.Drawing.Color.Black;
            this.support_view.Location = new System.Drawing.Point(0, 0);
            this.support_view.Name = "support_view";
            this.support_view.ReadOnly = true;
            this.support_view.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.support_view.Size = new System.Drawing.Size(1310, 298);
            this.support_view.TabIndex = 47;
            this.support_view.SelectionChanged += new System.EventHandler(this.support_view_SelectionChanged);
            // 
            // technical_support
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1310, 680);
            this.Controls.Add(this.panel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "technical_support";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الدعم الفني";
            this.Load += new System.EventHandler(this.technical_support_Load);
            this.panelLoader.ResumeLayout(false);
            this.panelLoader.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.support_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2HtmlToolTip ToolTip;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private XanderUI.XUIObjectAnimator xuiObjectAnimator;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GradientPanel panelLoader;
        private Guna.UI2.WinForms.Guna2ProgressIndicator guna2ProgressIndicator1;
        private System.Windows.Forms.Label textLoading;
        private System.Windows.Forms.RichTextBox emp_message;
        private Guna.UI2.WinForms.Guna2TextBox employee_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView support_view;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox service_type;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox phone;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox name;
        private MaterialSkin.Controls.MaterialButton send;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loader;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private System.Windows.Forms.Label support_left;
    }
}
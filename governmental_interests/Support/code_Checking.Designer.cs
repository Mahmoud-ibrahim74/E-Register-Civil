
namespace governmental_interests.Support
{
    partial class code_Checking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(code_Checking));
            this.label3 = new System.Windows.Forms.Label();
            this.code = new Guna.UI2.WinForms.Guna2TextBox();
            this.sendCode = new MaterialSkin.Controls.MaterialButton();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(140, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 51;
            this.label3.Text = "ادخل الكود";
            // 
            // code
            // 
            this.code.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.code.DefaultText = "";
            this.code.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.code.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.code.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.code.DisabledState.Parent = this.code;
            this.code.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.code.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.code.FocusedState.Parent = this.code;
            this.code.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.code.ForeColor = System.Drawing.Color.Black;
            this.code.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.code.HoverState.Parent = this.code;
            this.code.Location = new System.Drawing.Point(14, 100);
            this.code.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.code.Name = "code";
            this.code.PasswordChar = '\0';
            this.code.PlaceholderText = "";
            this.code.SelectedText = "";
            this.code.ShadowDecoration.Depth = 20;
            this.code.ShadowDecoration.Enabled = true;
            this.code.ShadowDecoration.Parent = this.code;
            this.code.Size = new System.Drawing.Size(348, 46);
            this.code.TabIndex = 52;
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // sendCode
            // 
            this.sendCode.AutoSize = false;
            this.sendCode.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.sendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendCode.Depth = 0;
            this.sendCode.DrawShadows = true;
            this.sendCode.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.sendCode.HighEmphasis = true;
            this.sendCode.Icon = ((System.Drawing.Image)(resources.GetObject("sendCode.Icon")));
            this.sendCode.Location = new System.Drawing.Point(61, 200);
            this.sendCode.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.sendCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.sendCode.Name = "sendCode";
            this.sendCode.Size = new System.Drawing.Size(258, 46);
            this.sendCode.TabIndex = 60;
            this.sendCode.Text = "تحقق من الكود";
            this.sendCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sendCode.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.sendCode.UseAccentColor = false;
            this.sendCode.UseVisualStyleBackColor = true;
            this.sendCode.Click += new System.EventHandler(this.sendCode_Click);
            // 
            // code_Checking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 278);
            this.Controls.Add(this.sendCode);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label3);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "code_Checking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ادخال الكود";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox code;
        private MaterialSkin.Controls.MaterialButton sendCode;
    }
}
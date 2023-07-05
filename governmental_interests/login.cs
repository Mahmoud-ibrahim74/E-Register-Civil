using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace governmental_interests
{

    public partial class login : Form
    {
        string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
        SqlDataAdapter adapter;
        DataTable dt;
        SqlConnection cn;
        public login()
        {
            InitializeComponent();
            TimeUpdater();

            InitData();
        }
        async void TimeUpdater() // refresh time 
        {
            while (true)
            {
                await Task.Delay(20000);

                checkConenction();

            }

        }
        public void checkConenction()
        {
            Ping p = new Ping();
            try
            {
                if (p.Send("www.google.com.mx").Status == IPStatus.Success)
                {
                }

            }
            catch (PingException)
            {
                if (MessageBox.Show("لا يوجد اتصال بالأنترنت فتح إعدادات الشبكة", "ERROR", MessageBoxButtons.YesNo, MessageBoxIcon.Error) == DialogResult.Yes)
                {
                    Process[] CloseProcess = Process.GetProcessesByName("ms-settings");
                    if (CloseProcess.Length == 0)
                    {
                        Process.Start("ms-settings:Status");
                    }

                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width == 310)
            {

                panelLeft.Visible = false;
                panelRight.Visible = false;
                panelLeft.Location = new Point(563, 0);

                panelAnimator_Left.ShowSync(panelLeft);
                panelRight.Location = new Point(0, 0);
                panelAnimator_Right.ShowSync(panelRight);
                start.Visible = false;
                gotoLogin.Visible = true;
                xuiObjectAnimator.ColorAnimate(panelRight, Color.AntiqueWhite, XanderUI.XUIObjectAnimator.ColorAnimation.FillEllipse, true, 1);
                xuiObjectAnimator.StandardAnimate(label1, XanderUI.XUIObjectAnimator.StandardAnimation.SlideUp, 1);
                xuiObjectAnimator.StandardAnimate(label2, XanderUI.XUIObjectAnimator.StandardAnimation.SlideUp, 1);



            }

        }

        private void guna2ToggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ToggleSwitch1.Checked == true)
            {
                password.PasswordChar = '\0';

            }
            else
            {
                password.PasswordChar = '●';

            }
        }

        private void username_TextChanged(object sender, EventArgs e)
        {
            username.Text = string.Concat(username.Text.Where(char.IsLetterOrDigit));
        }

        private void login_FormClosing(object sender, FormClosingEventArgs e)
        {
            var processBackGround = Process.GetProcessesByName("FMS");

            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("هل تريد إغلاق التطبيق  ؟؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    foreach (var KillProcess in processBackGround)
                    {
                        KillProcess.Kill();
                    }
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void guna2GradientButton66_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(username.Text))
            {
                errorProvider.SetError(username, "!! اسم المستخدم فارغ");

            }
            else if (string.IsNullOrEmpty(password.Text))
            {
                errorProvider.SetError(password, "!!  كلمة المرور فارغة");

            }
            else if (admin.Checked == false && user.Checked == false)
            {
                errorProvider.SetError(admin, "!!  بجاء اختيار نوع المستخدم (مسؤول/مستخدم) ");

            }
            else
            {
                if(admin.Checked)
                {
                    if (!backgroundWorker.IsBusy)
                    {
                        panelLoader.Visible = true;
                        backgroundWorker.RunWorkerAsync("admin");
                    }
                }
                else if(user.Checked)
                {
                    if (!backgroundWorker.IsBusy)
                    {
                        panelLoader.Visible = true;
                        backgroundWorker.RunWorkerAsync("employee");
                    }
                }
               
            }
        }

        private void InitData()
        {
            if (Properties.Settings.Default.UsernameDefault != string.Empty)
            {
                username.Text = Properties.Settings.Default.UsernameDefault;
                password.Text = Properties.Settings.Default.PasswordDefault;
                remeberMe.Checked = true;

            }
            else
            {
                username.Text = "";

            }
        }

        private void SaveData()
        {
            if (remeberMe.Checked)
            {
                Properties.Settings.Default.UsernameDefault = username.Text;
                Properties.Settings.Default.PasswordDefault = password.Text;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.UsernameDefault = "";
                Properties.Settings.Default.PasswordDefault = "";
                remeberMe.Checked = false;
                Properties.Settings.Default.Save();
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string getProcess = (string)e.Argument;
            if (getProcess == "admin") // if user checked admin
            {
                try
                {
                    cn = new SqlConnection(sqlConn);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select service_type, emp_username,password,user_type from employee_management where emp_username =@user and password =@pass and user_type = N'مسؤول' ", cn);
                    cmd.Parameters.AddWithValue("@user", username.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                }
                catch (SqlException ex)
                {
                    panelLoader.Visible = false;
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gotoLogin.Enabled = true;
                }

            }
            else if (getProcess == "employee")  // if user checked employee
            {

                try
                {
                    cn = new SqlConnection(sqlConn);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("select service_type, emp_username,password,user_type from employee_management where emp_username =@user and password =@pass and user_type = N'موظف' ", cn);
                    cmd.Parameters.AddWithValue("@user", username.Text);
                    cmd.Parameters.AddWithValue("@pass", password.Text);
                    adapter = new SqlDataAdapter(cmd);
                    dt = new DataTable();
                    adapter.Fill(dt);

                }
                catch (SqlException ex)
                {
                    panelLoader.Visible = false;
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    gotoLogin.Enabled = true;

                }
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            if (dt.Rows.Count == 1)
            {
                if (dt.Rows[0][3].ToString() == "مسؤول")
                {
                    panelLoader.Visible = false;
                    MessageBox.Show("تم تسجيل الدخول بنجاح", "  " + username.Text + "  : مرحبا  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    new MainMenu("admin", username.Text).Show();
                    this.Hide();

                }

                else if (dt.Rows[0][3].ToString() == "موظف")
                {
                    panelLoader.Visible = false;
                    MessageBox.Show("تم تسجيل الدخول بنجاح", "  " + username.Text + "  : مرحبا  ", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    new MainMenu("employee", username.Text).Show();
                    this.Hide();

                }

            }
            else
            {
                panelLoader.Visible = false;
                MessageBox.Show("اسم المستخدم او كلمة السر غير صحيحة", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                gotoLogin.Enabled = true;

            }

        }
    }
}

using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace governmental_interests
{
    public partial class MainMenu : Form
    {
        private string getType;
        private string getusername;
        private string fullName;
        private string Pass_Location;

        private string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=60;";
        DataSet ds = new DataSet();

        public MainMenu()
        {
            InitializeComponent();
        }
        public MainMenu(string types, string getUsername)
        {
            if (types == "employee")
            {
                InitializeComponent();
                panel_emp.Enabled = false;
                getType = types;
                this.getusername = getUsername;
                this.it_room.Enabled = false;
                PingUpdater();
            }
            else if (types == "admin")
            {
                InitializeComponent();
                getType = types;
                technical.Enabled = false;
                panel_orders.Enabled = false;
                this.getusername = getUsername;
                PingUpdater();


            }
        }

        async void PingUpdater() // refresh time 
        {
            while (true)
            {
                await Task.Delay(1000);

                if(getPing() <= 200)
                {
                    ping.Text = getPing() + "ms";
                    ping.ForeColor = Color.Green;
                }
                else if(getPing() >= 200 && getPing() <= 500)

                {
                    ping.Text = getPing() + "ms";
                    ping.ForeColor = Color.Orange;

                }
                else if(getPing() >=500 && getPing() <= 968)
                {
                    ping.Text = getPing() + "ms";
                    ping.ForeColor = Color.Red;

                }


            }

        }
        public long  getPing()
        {
            Ping p = new Ping();


            return p.Send("www.google.com").RoundtripTime;



        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer.Start();
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync("LoadName");
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }


        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            var form = new admin_priviliges.employees_mangement();
            if (Application.OpenForms[form.Name] == null)
            {
                form.Show();
            }
            else
            {
                Application.OpenForms[form.Name].Focus();
            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            var processBackGround = Process.GetProcessesByName("governmental_interests");

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

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("تسجيل الخروج ؟؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                new login().Show();
                this.Hide();
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pass_Location))
            {
                var form = new Orders_Request.National_ID( this.Pass_Location,lbl_name.Text);
                if (Application.OpenForms[form.Name] == null)
                {
                    form.Show();
                }
                else
                {
                    Application.OpenForms[form.Name].Focus();
                }
            }
            else
            {
                MessageBox.Show("برجاء المحاولة لاحقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void technical_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.fullName))
            {
                MessageBox.Show("برجاء المحاولة لاحقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var form = new Support.technical_support(fullName);
                if (Application.OpenForms[form.Name] == null)
                {
                    form.Show();
                }
                else
                {
                    Application.OpenForms[form.Name].Focus();
                }
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string getProcess = (string)e.Argument;
            if (getProcess == "LoadName")
            {
                try
                {
                    SqlConnection connection = new SqlConnection(sqlConn);
                    connection.Open();
                    SqlCommand cmd2 = new SqlCommand("select emp_fname,emp_lname,service_type,emp_place,photo from employee_management where emp_username = N'" + this.getusername + "' ", connection);
                    SqlDataAdapter da = new SqlDataAdapter(cmd2);
                    da.Fill(ds);
                    connection.Close();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (ds.Tables[0].Rows.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                
                profile_img.Image = new Bitmap(ms);
                fullName = ds.Tables[0].Rows[0]["emp_fname"].ToString() +"  " +  ds.Tables[0].Rows[0]["emp_lname"].ToString();
                lbl_name.Text = ds.Tables[0].Rows[0]["emp_fname"].ToString() +" " +  ds.Tables[0].Rows[0]["emp_lname"].ToString();
                lbl_service_type.Text = ds.Tables[0].Rows[0]["service_type"].ToString();
                lbl_location.Text = ds.Tables[0].Rows[0]["emp_place"].ToString();
                lbl_username.Text = this.getusername;
                Pass_Location = ds.Tables[0].Rows[0]["emp_place"].ToString();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {

        }

        private void chat_Click(object sender, EventArgs e)
        {

        }

        private void it_room_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Pass_Location))
            {
                var form = new Operations_Management.Orders_Monitoring(this.Pass_Location, lbl_name.Text);
                if (Application.OpenForms[form.Name] == null)
                {
                    form.Show();
                }
                else
                {
                    Application.OpenForms[form.Name].Focus();
                }
            }
            else
            {
                MessageBox.Show("برجاء المحاولة لاحقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void guna2CirclePictureBox1_Click(object sender, EventArgs e)
        {
            if (profile_card.Width == 340)
            {
                profile_card.Visible = true;

                profile_card.Width = 335;
            }
            else
            {
                profile_card.Visible = false;
                profile_card.Width = 340;

            }
        }

        private void Civil_types_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (Civil_types.SelectedIndex)
            {
                case 0 :
                    if (!string.IsNullOrEmpty(Pass_Location))
                    {
                        var form = new Orders_Request.National_ID( this.Pass_Location, lbl_name.Text);
                        if (Application.OpenForms[form.Name] == null)
                        {
                            form.Show();
                        }
                        else
                        {
                            Application.OpenForms[form.Name].Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء المحاولة لاحقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;

                case 1:
                    if (!string.IsNullOrEmpty(Pass_Location))
                    {
                        var form = new Orders_Request.birth_certificate( this.Pass_Location, lbl_name.Text);
                        if (Application.OpenForms[form.Name] == null)
                        {
                            form.Show();
                        }
                        else
                        {
                            Application.OpenForms[form.Name].Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("برجاء المحاولة لاحقا", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    break;




                default:
                    break;
            }
        }
    }
}

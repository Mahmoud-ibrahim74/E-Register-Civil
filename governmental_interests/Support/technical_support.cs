using System;
using System.Data;
using System.Windows.Forms;
namespace governmental_interests.Support
{
    public partial class technical_support : Form
    {
        private string service_type_sender = "";
        private string getFull_Name;
        string checkDisplayData = "";
        DataTable dt = new DataTable();
        private string getID;
        private int getCount = 0;
        public bool close_code { get; set; }
        public technical_support()
        {
            InitializeComponent();
        }
        public technical_support(string getFull_Name)
        {
            InitializeComponent();
            this.getFull_Name = getFull_Name;
            employee_name.Text = this.getFull_Name;

        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SQL_SERVER_Queris.technical_support.support support = new SQL_SERVER_Queris.technical_support.support();
            string ControlName = (string)e.Argument;
            if (ControlName == "Display_Support")
            {
                dt.Clear();
                checkDisplayData = "Display_Done";
                support.Display_Support(dt);
            }
            else if (ControlName == "sendMail")
            {
                support.SendMail(emp_message, email, name, employee_name, loader, getID);
                support_left.Text = support.getCounter_Support_SQL(getFull_Name) + " : اجمالي عدد الاستطلاعات ";
                getCount = Convert.ToInt32(support.getCounter_Support_SQL(getFull_Name));
                support.setIntial_Count(getCount);
            }
            else
            {
                support_left.Text = support.getCounter_Support_SQL(getFull_Name) + " : اجمالي عدد الاستطلاعات ";
                 getCount = Convert.ToInt32(support.getCounter_Support_SQL(getFull_Name));
                support.setIntial_Count(getCount);
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            if (checkDisplayData == "Display_Done")
            {
                panelLoader.Visible = false;
                support_view.DataSource = dt;

            }

        }

        private void support_view_SelectionChanged(object sender, EventArgs e)
        {
            if (support_view.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in support_view.SelectedRows)
                {
                    getID = row.Cells[0].Value.ToString();
                    name.Text = row.Cells[1].Value.ToString();
                    email.Text = row.Cells[2].Value.ToString();
                    phone.Text = row.Cells[3].Value.ToString();
                    emp_message.Text = row.Cells[4].Value.ToString();
                    service_type.Text = row.Cells[5].Value.ToString();
                }
            }

        }

        private void send_Click(object sender, EventArgs e)
        {
            if (emp_message.Text.Length <= 50)
            {
                MessageBox.Show("برجاء ادخال رسالة صحيحة الحد الادني للحروف =  50 حرف", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(getCount == 3)
            {
                MessageBox.Show("لقد تجاوزت الحد الاقصي من الاستطلاعات ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                if (close_code == false)
                {
                    var form = new Support.code_Checking();
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
                    getCount++;
                }

            }
            else
            {

                if (!backgroundWorker.IsBusy)
                {
                    loader.Visible = true;
                    backgroundWorker.RunWorkerAsync("sendMail");
                }
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (!backgroundWorker.IsBusy)
            {
                panelLoader.Visible = true;
                xuiObjectAnimator.StandardAnimate(panelLoader, XanderUI.XUIObjectAnimator.StandardAnimation.SlideDown, 5);
                backgroundWorker.RunWorkerAsync("Display_Support");
            }
        }

        private void technical_support_Load(object sender, EventArgs e)
        {
            if(!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }
    }
}

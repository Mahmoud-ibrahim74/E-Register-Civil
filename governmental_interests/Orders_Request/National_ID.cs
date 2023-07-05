using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace governmental_interests.Orders_Request
{
    public partial class National_ID : Form
    {
        private string getOrder_ID = "";
        string checkDisplayData = "";
        string Do_Location = "";
        string Sub_Governate, Sub_region;
        string get_empName;
        byte[] getImg1;
        byte[] getImg2;

        DataTable dt = new DataTable();
        public National_ID()
        {
            InitializeComponent();
        }
        public National_ID(string emp_location, string emp_name)
        {
            InitializeComponent();
            this.Do_Location = emp_location;

            Sub_Governate = Do_Location.Split('-').First();
            Sub_region = Do_Location.Split('-').Last();
            this.get_empName = emp_name;
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {

            string ControlName = (string)e.Argument;
            SQL_SERVER_Queris.Orders_Porcess.National_ID _Registry = new SQL_SERVER_Queris.Orders_Porcess.National_ID();
            SQL_SERVER_Queris.technical_support.support support = new SQL_SERVER_Queris.technical_support.support();
            if (ControlName == "Civil_Registry")
            {
                dt.Clear();
                checkDisplayData = "Display_Done";
                _Registry.Display_Order(dt, Sub_Governate, Sub_region);
            }
            else if (ControlName == "update_confirmed")
            {
                checkDisplayData = "update_confirmed";
                _Registry.Order_Confirmed(getOrder_ID);

            }
            else if (ControlName == "sendOrderMail")
            {
                checkDisplayData = "sendOrderMail";
                support.SendOrderMail(notes, email, fullname, get_empName, getOrder_ID, id.Text, date.Text, phone1.Text, phone2.Text, address.Text, order_type.Text, governate.Text, region.Text, card_type.Text, Service_Type.Text, IsPaid.Text, payment_method.Text);

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            if (checkDisplayData == "Display_Done")
            {
                panelLoader.Visible = false;
                Order_View.DataSource = dt;
            }
            else if (checkDisplayData == "update_confirmed")
            {
                panelLoader.Visible = false;
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("Civil_Registry");
                }
            }
            else if (checkDisplayData == "deltedOrder")
            {
                panelLoader.Visible = false;
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("Civil_Registry");
                }
            }
            else if (checkDisplayData == "sendOrderMail")
            {
                panelLoader.Visible = false;
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("Civil_Registry");
                }
            }

        }

        private void display_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Sub_Governate) || string.IsNullOrEmpty(Sub_region))
            {
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("Civil_Registry");
                }
            }
            else
            {
                MessageBox.Show("حدث خطأ اثناء العرض برجاء المحاولة لاحقا", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void gallery_Click(object sender, EventArgs e)
        {
            if (Order_View.Rows.Count == 0)
            {
                MessageBox.Show("من فضلك اعرض الطلبات اولا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else if (!fullname.Text.Contains("-"))
            {
                MessageBox.Show("برجاء ادخال (-) بعد الاسم الأول", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!address.Text.Contains("-"))
            {
                MessageBox.Show("(-) برجاء تقسيم العنوان اولا باستخدام", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (!qualifications.Text.Contains("-"))
            {
                MessageBox.Show("(-) برجاء تقسيم المؤهل اولا باستخدام", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                var form = new Orders_Request.CreateOrder(fullname.Text, address.Text, id.Text, BirthDate.Text, getImg1, date.Text, qualifications.Text, Gender.Text, religion.Text, status.Text);
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

        private void id_TextChanged(object sender, EventArgs e)
        {
            id.Text = string.Concat(id.Text.Where(char.IsDigit));
        }

        private void Order_View_SelectionChanged(object sender, EventArgs e)
        {
            if (Order_View.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Order_View.SelectedRows)
                {
                    getOrder_ID = row.Cells[0].Value.ToString();
                    date.Text = row.Cells[1].Value.ToString();
                    id.Text = row.Cells[2].Value.ToString();
                    order_type.Text = row.Cells[3].Value.ToString();
                    fullname.Text = row.Cells[4].Value.ToString();
                    email.Text = row.Cells[5].Value.ToString();

                    phone1.Text = row.Cells[6].Value.ToString();
                    phone2.Text = row.Cells[7].Value.ToString();
                    address.Text = row.Cells[8].Value.ToString();
                    governate.Text = row.Cells[9].Value.ToString();
                    region.Text = row.Cells[10].Value.ToString();

                    card_type.Text = row.Cells[11].Value.ToString();
                    Service_Type.Text = row.Cells[12].Value.ToString();
                    payment_method.Text = row.Cells[13].Value.ToString();
                    notes.Text = row.Cells[16].Value.ToString();

                    BirthDate.Text = row.Cells[17].Value.ToString();
                    Gender.Text = row.Cells[18].Value.ToString();
                    religion.Text = row.Cells[19].Value.ToString();
                    status.Text = row.Cells[20].Value.ToString();
                    qualifications.Text = row.Cells[21].Value.ToString();



                    if (row.Cells[14].Value.ToString() == "True")
                    {
                        IsPaid.Text = "تم الدفع";
                        Confirm.Enabled = true;
                        send_mail.Enabled = true;
                    }
                    else
                    {
                        IsPaid.Text = "لم يتم الدفع";
                        Confirm.Enabled = false;
                        send_mail.Enabled = true;
                    }

                    img1.Image = null;
                    img2.Image = null;
                    if (row.Cells[22].Value != null)
                    {
                        getImg1 = (byte[])(row.Cells[22].Value);
                        MemoryStream ms1 = new MemoryStream(getImg1);
                        img1.Image = Image.FromStream(ms1);
                        if (row.Cells[23].Value.ToString() != null)
                        {
                            getImg2 = (byte[])(row.Cells[23].Value);
                            MemoryStream ms2 = new MemoryStream(getImg2);
                            img2.Image = Image.FromStream(ms2);
                        }
                    }

                }
            }

        }

        private void send_mail_Click(object sender, EventArgs e)
        {
            if (Order_View.Rows.Count == 0)
            {
                MessageBox.Show("من فضلك اعرض الطلبات اولا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else if (MessageBox.Show("تأكيد ارسال التقرير", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync("sendOrderMail");
                }
            }
        }



        private void Confirm_Click(object sender, EventArgs e)
        {
            if (Order_View.Rows.Count == 0)
            {
                MessageBox.Show("من فضلك اعرض الطلبات اولا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {

                if (MessageBox.Show("تأكيد الطلب؟؟", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (!backgroundWorker.IsBusy)
                    {
                        backgroundWorker.RunWorkerAsync("update_confirmed");
                    }
                }


            }

        }
    }
}

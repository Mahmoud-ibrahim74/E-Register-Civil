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
    public partial class birth_certificate : Form
    {
        private string getOrder_ID = "";
        bool confirmned_btnClick = false;
        string checkDisplayData = "";
        string Do_Location = "";
        string Sub_Governate, Sub_region;
        string get_empName;
        DataTable dt = new DataTable();
        public birth_certificate()
        {
            InitializeComponent();
        }
        public birth_certificate(string emp_location, string emp_name)
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
            SQL_SERVER_Queris.Orders_Porcess.birth_certificate birth = new SQL_SERVER_Queris.Orders_Porcess.birth_certificate();
           // SQL_SERVER_Queris.technical_support.support support = new SQL_SERVER_Queris.technical_support.support();
            if (ControlName == "birth_certificate")
            {
                dt.Clear();
                checkDisplayData = "Display_Done";
                birth.Display_Order(dt, Sub_Governate, Sub_region);
            }
            else if (ControlName == "update_confirmed")
            {
               checkDisplayData = "update_confirmed";
                birth.Order_Confirmed(getOrder_ID);
                confirmned_btnClick = false;

            }
            else if (ControlName == "sendOrderMail")
            {
                /*checkDisplayData = "sendOrderMail";
                support.SendOrderMail(notes, email, fullname, get_empName, getOrder_ID, id.Text, date.Text, phone1.Text, phone2.Text, address.Text, order_type.Text, governate.Text, region.Text, card_type.Text, Service_Type.Text, IsPaid.Text, payment_method.Text);
                confirmned_btnClick = true;*/

            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            if (checkDisplayData == "Display_Done")
            {
                panelLoader.Visible = false;
                Order_View.DataSource = dt;
                backgroundWorker.CancelAsync();
            }
            else if (checkDisplayData == "update_confirmed")
            {
                panelLoader.Visible = false;
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("birth_certificate");
                }
            }
            else if (checkDisplayData == "deltedOrder")
            {
                panelLoader.Visible = false;
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("birth_certificate");
                }
            }
            else if (checkDisplayData == "sendOrderMail")
            {
                panelLoader.Visible = false;
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    backgroundWorker.RunWorkerAsync("birth_certificate");
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
                    backgroundWorker.RunWorkerAsync("birth_certificate");
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
            else
            {

            }
        }

      

        private void Order_View_SelectionChanged(object sender, EventArgs e)
        {
            if (Order_View.Rows.Count > 0)
            {
                foreach (DataGridViewRow row in Order_View.SelectedRows)
                {

                    getOrder_ID = row.Cells[0].Value.ToString();

                    fullname.Text = row.Cells[1].Value.ToString();
                    email.Text = row.Cells[2].Value.ToString();
                    phone1.Text = row.Cells[3].Value.ToString();
                    HomePhone.Text = row.Cells[4].Value.ToString();
                    Apartment_number.Text = row.Cells[5].Value.ToString();
                    Floor_Number.Text = row.Cells[6].Value.ToString();
                    HomeNumber.Text = row.Cells[7].Value.ToString();
                    StreetName.Text = row.Cells[8].Value.ToString();
                    city.Text = row.Cells[9].Value.ToString();
                    PostalCode.Text = row.Cells[10].Value.ToString();
                    governate.Text = row.Cells[11].Value.ToString();
                    region.Text = row.Cells[12].Value.ToString();
                    police.Text = row.Cells[13].Value.ToString();
                    NumberCopies.Text = row.Cells[14].Value.ToString();
                    degree_kinship.Text = row.Cells[15].Value.ToString();


                    FirstName.Text = row.Cells[16].Value.ToString();
                    FatherName.Text = row.Cells[17].Value.ToString();
                    MotherName.Text = row.Cells[18].Value.ToString();
                    GrandBaName.Text = row.Cells[19].Value.ToString();

                    FamilyName.Text = row.Cells[20].Value.ToString();

                    id.Text = row.Cells[21].Value.ToString();
                    payment_method.Text = row.Cells[22].Value.ToString();
                    orderDate.Text = row.Cells[23].Value.ToString();
                    notes.Text = row.Cells[24].Value.ToString();
                    if (row.Cells[25].Value.ToString() == "True")
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

                    if (row.Cells[26].Value != null || row.Cells[27].Value != null)
                    {
                        var getImg1 = (byte[])(row.Cells[26].Value);
                        var getImg2 = (byte[])(row.Cells[27].Value);

                        MemoryStream ms1 = new MemoryStream(getImg1);
                        MemoryStream ms2 = new MemoryStream(getImg2);

                        img1.Image = Image.FromStream(ms1);
                        img2.Image = Image.FromStream(ms2);
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
              /*  if (confirmned_btnClick == false)
                {
                    MessageBox.Show("من فضلك ارسل الطلب اولا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                }*/

            }

        }
    }
}

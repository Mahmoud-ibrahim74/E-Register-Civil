using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace governmental_interests.Operations_Management
{
    public partial class Orders_Monitoring : Form
    {
        private string getOrder_ID = "";
        string checkDisplayData = "";
        string Do_Location = "";
        string Sub_Governate, Sub_region;
        string get_empName;
        byte[] getImg1;
        byte[] getImg2;
        private string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";


        DataTable dt = new DataTable();
        public Orders_Monitoring()
        {
            InitializeComponent();
        }
        public Orders_Monitoring(string emp_location, string emp_name)
        {
            InitializeComponent();
            this.Do_Location = emp_location;

            Sub_Governate = Do_Location.Split('-').First();
            Sub_region = Do_Location.Split('-').Last();
            this.get_empName = emp_name;
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            SQL_SERVER_Queris.Orders_Porcess.National_ID national = new SQL_SERVER_Queris.Orders_Porcess.National_ID();
            string ControlName = (string)e.Argument;
            if (ControlName == "Civil_Registry")
            {
                dt.Clear();
                checkDisplayData = "Display_Done";
                national.ShowOrders(dt,Sub_Governate,Sub_region);
                panelLoader.Visible = false;


            }
            else if (ControlName == "UpdateOrder")
            {
                checkDisplayData = "UpdateOrder";
                UpdateOrder();
                panelLoader.Visible = false;
            }

        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {

            if (checkDisplayData == "Display_Done")
            {
                Order_View.DataSource = dt;
            }
            else if (checkDisplayData == "UpdateOrder")
            {
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
            int n;
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
            //else if(!date.Text.Contains("-") || !int.TryParse(date.Text,out  n))
            //{
            //    MessageBox.Show("برجاء ادخال تاريخ الطلب صحيح", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
            else
            {
                var form = new Orders_Request.CreateOrder(fullname.Text, address.Text, id.Text, BirthDate.Text, getImg2, date.Text, qualifications.Text, Gender.Text, religion.Text, status.Text);
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
                    BirthDate.Text = row.Cells[16].Value.ToString();

                    Gender.Text = row.Cells[17].Value.ToString();
                    religion.Text = row.Cells[18].Value.ToString();
                    status.Text = row.Cells[19].Value.ToString();
                    qualifications.Text = row.Cells[20].Value.ToString();
                    notes.Text = row.Cells[21].Value.ToString();



                    if (row.Cells[14].Value.ToString() == "True")
                    {
                        IsPaid.Text = "تم الدفع";
                    }
                    else
                    {
                        IsPaid.Text = "لم يتم الدفع";
                    }
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

                if (MessageBox.Show("تعديل رقم رقم  '"+Order_View.SelectedCells[0].Value.ToString()+"'", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    if (!backgroundWorker.IsBusy)
                    {
                        panelLoader.Visible = true;
                        backgroundWorker.RunWorkerAsync("UpdateOrder");
                    }
                }


            }

        }

        private void Order_View_DataSourceChanged(object sender, EventArgs e)
        {
            search.Visible = true;
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            search.Text = string.Concat(search.Text.Where(char.IsDigit));

            (Order_View.DataSource as DataTable).DefaultView.RowFilter = string.Format("CONVERT({0}, System.String) like '%{1}%'", "[رقم البطاقة]", search.Text.Trim());


        }


        private void UpdateOrder()
        {
            if(Order_View.Rows.Count != 0)
            {
                string getOrderID = Order_View.SelectedCells[0].Value.ToString();

                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand command = new SqlCommand("update RegisterCivil set Phone1 = @ph1, governorate = @gov, FullName = @full, Phone2 = @ph2, BirthDate = @bt," +
                "Address = @add, card_type = @ct, Kind = @k, Religion = @r, Email = @e, SocialStatus = @ss, qualification = @q where OrderCivilId = @card", cn);
                command.Parameters.AddWithValue("@ph1", phone1.Text);
                command.Parameters.AddWithValue("@gov", governate.Text);
                command.Parameters.AddWithValue("@full", fullname.Text);
                command.Parameters.AddWithValue("@ph2", phone2.Text);
                command.Parameters.AddWithValue("@e", email.Text);

                command.Parameters.AddWithValue("@bt", BirthDate.Text);
                command.Parameters.AddWithValue("@add", address.Text);
                command.Parameters.AddWithValue("@ct", card_type.Text);
                command.Parameters.AddWithValue("@k", Gender.Text);
                command.Parameters.AddWithValue("@r", religion.Text);
                command.Parameters.AddWithValue("@ss", status.Text);
                command.Parameters.AddWithValue("@q", qualifications.Text);
                command.Parameters.AddWithValue("@card", getOrderID);
                command.ExecuteNonQuery();
                MessageBox.Show("تم تعديل الطلب بنجاح");
                cn.Close();
            }
         
        }








    }
}

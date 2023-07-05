using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace governmental_interests.SQL_SERVER_Queris
{
    class emp_mangement
    {
        private string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";

        public void InsertData(Guna2CirclePictureBox userPic,Guna2TextBox id, Guna2TextBox emp_fname, Guna2TextBox emp_lname,Guna2DateTimePicker emp_date, Guna2TextBox phone,Guna2ComboBox user_type, string emp_place, Guna2TextBox username, Guna2TextBox password,Guna2ComboBox service_type, Guna2GradientPanel panelLoader)
        {
            

            try
            {
                MemoryStream ms = new MemoryStream();
                userPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = ms.GetBuffer();
                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into [dbo].[employee_management] values (@id,@fname,@lname,@date,@phone,@user_type,@address,@user,@password,@st,@img)", cn);
                cmd.Parameters.AddWithValue("@id", id.Text);
                cmd.Parameters.AddWithValue("@fname", emp_fname.Text);
                cmd.Parameters.AddWithValue("@lname", emp_lname.Text);
                cmd.Parameters.AddWithValue("@date", emp_date.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@user_type", user_type.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@address", emp_place);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@st", service_type.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@img", img);
                cmd.ExecuteNonQuery();
                panelLoader.Visible = false;
                MessageBox.Show("تم إدخال المستخدم بنجاح" + "\n '" + username.Text + "': اسم المستخدم ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("الرقم القومي موجود بالفعل ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (ex.Message.Contains("A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: TCP Provider, error: 0 - No such host is known.)"))
                    {

                        MessageBox.Show("خطأ في الأتصال بالخادم برجاء التحقق من اتصالك بالأنترنت", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        public void DisplayData(Guna2CirclePictureBox userPic, Guna2TextBox id, Guna2TextBox emp_fname, Guna2TextBox emp_lname, Guna2DateTimePicker emp_date, Guna2TextBox phone, Guna2ComboBox user_type, Guna2ComboBox govern, Guna2ComboBox region, Guna2TextBox username, Guna2TextBox confirm_pass, Guna2ComboBox service_type)
        {

            try
            {

                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand cmd = new SqlCommand("select * from employee_management where  emp_username=@user;", cn);
                cmd.Parameters.AddWithValue("@user", username.Text);
                SqlDataReader rd = cmd.ExecuteReader();
                if (rd.Read())
                {
                    id.Text = rd["emp_id"].ToString();
                    emp_fname.Text = rd["emp_fname"].ToString();
                    emp_lname.Text = rd["emp_lname"].ToString();
                    phone.Text = rd["emp_phone"].ToString();

                    username.Text = rd["emp_username"].ToString();
                    user_type.Text = rd["user_type"].ToString();
                    service_type.Text = rd["service_type"].ToString();
                    confirm_pass.Text = rd["password"].ToString();
                }
                else
                {
                    MessageBox.Show("لا يوجد موظف بهذه البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                cn.Close();

                cn.Open();
                SqlCommand cmd2 = new SqlCommand("select photo  from employee_management where emp_username = N'" + username.Text + "' ", cn);
                SqlDataAdapter da = new SqlDataAdapter(cmd2);
                DataSet ds = new DataSet();
                da.Fill(ds);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["photo"]);
                    userPic.Image = new Bitmap(ms);

                }
                cn.Close();
            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: TCP Provider, error: 0 - No such host is known.)"))
                {

                    MessageBox.Show("خطأ في الأتصال بالخادم برجاء التحقق من اتصالك بالأنترنت", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        public void UpdateData(Guna2CirclePictureBox userPic, Guna2TextBox id, Guna2TextBox emp_fname, Guna2TextBox emp_lname, Guna2DateTimePicker emp_date, Guna2TextBox phone, Guna2ComboBox user_type, string emp_place, Guna2TextBox username, Guna2TextBox password, Guna2ComboBox service_type, Guna2GradientPanel panelLoader)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                userPic.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] img = ms.GetBuffer();

                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE employee_management SET emp_fname = @fname,emp_lname = @lname,service_type = @st, emp_date = @date, emp_phone = @phone, user_type = @user_type, emp_place = @address, emp_username = @user, password = @password,photo= @img WHERE emp_id =  " + id.Text + "  ; ", cn);
                cmd.Parameters.AddWithValue("@fname", emp_fname.Text);
                cmd.Parameters.AddWithValue("@lname", emp_lname.Text);
                cmd.Parameters.AddWithValue("@date", emp_date.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@user_type", user_type.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@address", emp_place);
                cmd.Parameters.AddWithValue("@user", username.Text);
                cmd.Parameters.AddWithValue("@password", password.Text);
                cmd.Parameters.AddWithValue("@st", service_type.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@img", img);
                cmd.ExecuteNonQuery();
                panelLoader.Visible = false;
                MessageBox.Show("تم تعديل المستخدم بنجاح" + "\n '" + username.Text + "': اسم المستخدم ", "تم", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("الرقم القومي موجود بالفعل ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else
                {

                    if (ex.Message.Contains("A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: TCP Provider, error: 0 - No such host is known.)"))
                    {

                        MessageBox.Show("خطأ في الأتصال بالخادم برجاء التحقق من اتصالك بالأنترنت", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
        public void deleteData(Guna2TextBox id, Guna2TextBox username)
        {

            if (MessageBox.Show("هل تريد حذف المستخدم ؟؟" + "\n '" + id.Text + "'", "تحذير", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {

                try
                {
                    SqlConnection cn = new SqlConnection(sqlConn);
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM employee_management WHERE emp_id= " + id.Text + " or emp_username = N'" + username.Text + "' ;", cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("تم حذف المستخدم بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    cn.Close();
                }
                catch (SqlException ex)
                {

                    if (ex.Message.Contains("A network-related or instance-specific error occurred while establishing a connection to SQL Server. The server was not found or was not accessible. Verify that the instance name is correct and that SQL Server is configured to allow remote connections. (provider: TCP Provider, error: 0 - No such host is known.)"))
                    {

                        MessageBox.Show("خطأ في الأتصال بالخادم برجاء التحقق من اتصالك بالأنترنت", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }


        }

    }
}

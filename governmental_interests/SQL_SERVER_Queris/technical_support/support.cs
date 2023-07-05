using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Windows.Forms;
using Guna.UI2.WinForms;


namespace governmental_interests.SQL_SERVER_Queris.technical_support
{
    class support
    {


        static int count = 0;
        private string pass = "mahmoud-2020";
        private string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
        private static int Decrement_TopCols = 10;
        public void setIntial_Count(int setCount)
        {
            count = setCount;
        }
        public void Display_Support(DataTable dt)
        {
            try
            {
                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand cmd = new SqlCommand("select top "+Decrement_TopCols+" ContactUsID as [رقم الاستطلاع], FullName as [اسم المرسل] ,Email as [البريد الالكتروني] , PhoneNumber as [الهاتف],Message as [الرساله] , Serves as [نوع الخدمه]  from [dbo].[ContactUs] ", cn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);
                cn.Close();

            }
            catch (SqlException)
            {
                MessageBox.Show("حدث خطأ اثناء العرض برجاء المحاولة لاحقا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SendMail(RichTextBox message, Guna2TextBox email, Guna2TextBox name, Guna2TextBox emp_name, Guna2ProgressIndicator loader, String getID)
        {
            try
            {
                MailAddress fromMail = new MailAddress("governmentinterests508@gmail.com", "المصالح الحكومية");
                MailAddress toMail = new MailAddress(email.Text);
                MailMessage m = new MailMessage(fromMail, toMail);
                m.Subject = "الدعم الفني";
                m.Body = "\n .مرحبا    " + name.Text + "\n\n" + message.Text + "\n\n" + "شكرا علي دعمك \n" + emp_name.Text;
                SmtpClient smtp = new SmtpClient();
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("governmentinterests508@gmail.com", pass);
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(m);
                loader.Visible = false;
                MessageBox.Show("تم ارسال التقرير", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                DeleteSupport(getID);
                sendCounter_Support(emp_name.Text);
            }
            catch (SmtpException)
            {
                MessageBox.Show("برجاء المحاولة لاحقا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        public void DeleteSupport(String getID)
        {
            try
            {
                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand cmd = new SqlCommand("delete from ContactUs where ContactUsID =" + getID + " ", cn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("تم حذف الاستطلاع بنجاح", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                cn.Close();
                Interlocked.Increment(ref count);
                Decrement_TopCols--;
            }
            catch (SqlException )
            {
                MessageBox.Show("حدث خطأ اثناء الحذف برجاء المحاولة لاحقا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }


        public void SendOrderMail(RichTextBox message, Guna2TextBox email, Guna2TextBox name, string emp_name , String getID,string civilID,string OrderDate,string phone1,string phone2,string address,string order_type,string governate,string region,string card_type,string Service_Type,string IsPaid,string paymentMethod)
        {
            try
            {
                MailAddress fromMail = new MailAddress("governmentinterests508@gmail.com", "السجل المدني الالكتروني");
                MailAddress toMail = new MailAddress(email.Text);
                MailMessage m = new MailMessage(fromMail, toMail);
                m.Subject = "ارسال الطلب";
                m.Body = "\n .مرحبا    " + name.Text + "\n\n" + "برجاء العلم انه تم ارسال طلبك للسجل المدني الالكتروني وهي \n\n" +
                  "  الاسم بالكامل :" + name.Text +
                    "\n"+
                  "   الرقم القومي :"+ civilID + 
                    "\n" +
                  "   البريد الالكتروني :"+ email.Text  +
                    "\n" +
                  "   تاريخ الطلب :"+   OrderDate  +
                    "\n" +
                  "   رقم الهاتف الأول :" +  phone1  +
                    "\n" +
                  "  رقم الهاتف الثاني :" +   phone2  +
                    "\n" +
                  "  نوع الطلب :" + order_type  +
                    "\n" +
                  "  المحافظة :" +   governate  +
                    "\n" +
                 "  المنطقة :" +  region   +
                    "\n" +
                  "  نوع الطلب :" + card_type +  
                    "\n" +
                  "  حالة الدفع :" + IsPaid   +
                    "\n" +
                  " طريقة الدفع :" +  paymentMethod  +
                   "\n\n" +
                   "سيتم التواصل معك علي احد الهواتف الخاصة بك لتأكيد معلوماتك" +
                   "\n" + 
                   message.Text + 
                   "\n\n" + 
                   "شكرا علي تعاونك" + 
                   "\n  "+
                   emp_name;
                SmtpClient smtp = new SmtpClient();
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential("governmentinterests508@gmail.com", pass);
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.Send(m);
                MessageBox.Show("تم ارسال التقرير", "تم", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            catch (SmtpException)
            {
                MessageBox.Show("برجاء المحاولة لاحقا", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void sendCounter_Support(String emp_name)
        {
            try
            {
                String getTime = DateTime.Now.ToShortTimeString() + "   " + DateTime.Now.ToShortDateString();
                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();               
                SqlCommand cmd = new SqlCommand("insert into supportCount (support_counter,Date,username) values(" + count+",'"+getTime+"',N'"+emp_name+"');", cn);
                cmd.ExecuteNonQuery();
                cn.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        
        public String getCounter_Support_SQL(String emp_name)
        {
            String getTime =DateTime.Now.ToShortDateString();
            SqlConnection cn = new SqlConnection(sqlConn);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select COUNT(support_counter)  from supportCount WHERE Date LIKE '%"+getTime+"%' and username = N'"+emp_name+"' ", cn);
             String getCount =  cmd.ExecuteScalar().ToString();
            cn.Close();
            return getCount;
        }





    }
}

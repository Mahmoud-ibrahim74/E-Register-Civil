using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace governmental_interests.SQL_SERVER_Queris.Orders_Porcess
{
    class National_ID
    {
        private string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
        public void Display_Order(DataTable dt,string governate, string region)
        {

            SqlConnection cn = new SqlConnection(sqlConn);
            cn.Open();
            SqlCommand command = new SqlCommand("select top 5   OrderCivilId as [رقم الطلب],Date as [تاريخ الطلب],CardID as [رقم البطاقة],OrderType as [نوع الطلب],FullName as [اسم العميل],Email as [البريد الالكتروني],Phone1 as [رقم الهاتف الاول],Phone2 as [رقم الهاتف الثاني],Address as [العنوان],governorate as [المحافظة],region as [المنطقة],card_type as [نوع البطاقة],service_type as [نوع الخدمة],payment_method as [طريقة الدفع],IsPaid as [تم الدفع],Confirmed as[حالة الطلب],Notes as [ملاحظات], BirthDate as [تاريخ الميلاد],Kind as [النوع],Religion as [الديانة],SocialStatus as [الحالة الاجتماعية],qualification as [المؤهل],Photo1 as [الصورة الأولي],Photo2 as [الصور الثانية] from RegisterCivil where Confirmed !=1 and governorate LIKE N'%" + governate+"%' and region LIKE N'%"+region+"%' and service_type = 'VIP' " +
                "UNION " +
                "select top 5   OrderCivilId as [رقم الطلب],Date as [تاريخ الطلب],CardID as [رقم البطاقة],OrderType as [نوع الطلب],FullName as [اسم العميل],Email as [البريد الالكتروني],Phone1 as [رقم الهاتف الاول],Phone2 as [رقم الهاتف الثاني],Address as [العنوان],governorate as [المحافظة],region as [المنطقة],card_type as [نوع البطاقة],service_type as [نوع الخدمة],payment_method as [طريقة الدفع],IsPaid as [تم الدفع],Confirmed as[حالة الطلب],Notes as [ملاحظات], BirthDate as [تاريخ الميلاد],Kind as [النوع],Religion as [الديانة],SocialStatus as [الحالة الاجتماعية],qualification as [المؤهل],Photo1 as [الصورة الأولي],Photo2 as [الصور الثانية] from RegisterCivil where Confirmed !=1 and governorate LIKE N'%" + governate+"%' and region LIKE N'%"+region+"%' and service_type = N'سريعة' " +
                "UNION " +
                "select top 5   OrderCivilId as [رقم الطلب],Date as [تاريخ الطلب],CardID as [رقم البطاقة],OrderType as [نوع الطلب],FullName as [اسم العميل],Email as [البريد الالكتروني],Phone1 as [رقم الهاتف الاول],Phone2 as [رقم الهاتف الثاني],Address as [العنوان],governorate as [المحافظة],region as [المنطقة],card_type as [نوع البطاقة],service_type as [نوع الخدمة],payment_method as [طريقة الدفع],IsPaid as [تم الدفع],Confirmed as[حالة الطلب],Notes as [ملاحظات], BirthDate as [تاريخ الميلاد],Kind as [النوع],Religion as [الديانة],SocialStatus as [الحالة الاجتماعية],qualification as [المؤهل],Photo1 as [الصورة الأولي],Photo2 as [الصور الثانية] from RegisterCivil where Confirmed !=1 and governorate LIKE N'%" + governate+ "%' and region LIKE N'%"+region+"%' and service_type = N'عادية' ", cn);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.Close();
        }
        public void ShowOrders(DataTable dt, string governate, string region)
        {
            SqlConnection cn = new SqlConnection(sqlConn);
            cn.Open();
            SqlCommand command = new SqlCommand("select OrderCivilId as [رقم الطلب],Date as [تاريخ الطلب],CardID as [رقم البطاقة],OrderType as [نوع الطلب],FullName as [اسم العميل],Email as [البريد الالكتروني],Phone1 as [رقم الهاتف الاول],Phone2 as [رقم الهاتف الثاني],Address as [العنوان],governorate as [المحافظة],region as [المنطقة],card_type as [نوع البطاقة],service_type as [نوع الخدمة],payment_method as [طريقة الدفع],IsPaid as [تم الدفع],Confirmed as[حالة الطلب], BirthDate as [تاريخ الميلاد],Kind as [النوع],Religion as [الديانة],SocialStatus as [الحالة الاجتماعية],qualification as [المؤهل],Notes as [ملاحظات] from RegisterCivil where  governorate LIKE N'%" + governate + "%' and region LIKE N'%" + region + "%'  ", cn);
            command.ExecuteNonQuery();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            cn.Close();
        }

        public void Order_Confirmed(string getID)
        {
            try
            {
                SqlConnection cn = new SqlConnection(sqlConn);
                cn.Open();
                SqlCommand cmd2 = new SqlCommand("update RegisterCivil set Confirmed = 1 where OrderCivilId='" + getID + "' ", cn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("تم تأكيد الطلب بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (SqlException ex)
            {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        //public void DeleteOrder(string id)
        //{
        //    try
        //    {
        //        SqlConnection cn = new SqlConnection(sqlConn);
        //        cn.Open();
        //        SqlCommand cmd2 = new SqlCommand("delete from  RegisterCivil  where OrderCivilId='" + id + "' ", cn);
        //        cmd2.ExecuteNonQuery();
        //        MessageBox.Show("تم حذف الطلب بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
        //    }
        //    catch (SqlException ex)
        //    {
        //        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }

        //}


    }
}

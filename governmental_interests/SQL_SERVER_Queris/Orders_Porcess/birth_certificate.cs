using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI2.WinForms;
namespace governmental_interests.SQL_SERVER_Queris.Orders_Porcess
{
    class birth_certificate
    {
        private string sqlConn = "Server=den1.mssql8.gear.host; Initial Catalog=governmental;Persist Security Info=False;User ID=governmental;Password=M01207443941i#;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=true;Connection Timeout=30;";
        public void Display_Order(DataTable dt,string governate, string region)
        {

            SqlConnection cn = new SqlConnection(sqlConn);
            cn.Open();
            SqlCommand command = new SqlCommand("select top 10 BirthcertificateId as [رقم الطلب],FullName as [الاسم بالكامل],Email as [البريد الالكتروني],MobilePhone as [رقم الهاتف]," +
                "HomePhone as [رقم الهاتف الارضي],ApartmentNumber as [رقم الشقة],FloorNumber as [رقم الدور],HomeNumber as [رقم المنزل],StreetName as [اسم الشارع],City as [المدينة]," +
                "PostalCode as [الرقم البريدي],Governorate as [المحافظة],region as [المنطقة],PoliceDepartment as [قسم الشرطة],NumberOfCopies as [عدد النسخ],DegreeOfKinship as [درجة القرابة]," +
                "FirstName as [الاسم الاول],FatherName as [اسم الاب],MotherName as [اسم الام],GrandpaName as [اسم الجد],FamilyName as [اسم العائلة],CardId as [رقم البطاقة],PaymentType as [طريقة الدفع]," +
                "Date as [تاريخ الطلب],Notes as [ملاحظات],IsPaid as [تم الدفع],photo1 as [الصورة الاول],photo2 as [الصورة الثانية] from Birthcertificates where Confirmed !=1 and Governorate LIKE N'%" + governate + "%' and region LIKE N'%" + region + "%' ", cn);
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
                SqlCommand cmd2 = new SqlCommand("update Birthcertificates set Confirmed = 1 where BirthcertificateId ='" + getID + "' ", cn);
                cmd2.ExecuteNonQuery();
                MessageBox.Show("تم تأكيد الطلب بنجاح", "Done", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            catch (SqlException ex)
            {
                    MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        


    }
}

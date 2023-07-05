using Guna.UI2.WinForms;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace governmental_interests.admin_priviliges
{
    public partial class employees_mangement : Form
    {
        public employees_mangement()
        {
            InitializeComponent();
            datePanel.Text = DateTime.Now.ToLongDateString();
            id.MaxLength = 15;
            phone.MaxLength = 11;
        }
        public void MovePic(object sender)
        {
            Guna2Button b = (Guna2Button)sender;
            imageSlider.Location = new System.Drawing.Point(b.Location.X + 84, b.Location.Y - 24);
            imageSlider.SendToBack();
        }


        private void id_TextChanged(object sender, System.EventArgs e)
        {
            id.Text = string.Concat(id.Text.Where(char.IsDigit));

        }



        private void phone_TextChanged(object sender, System.EventArgs e)
        {
            phone.Text = string.Concat(phone.Text.Where(char.IsNumber));

        }

        private void show_CheckedChanged_1(object sender, System.EventArgs e)
        {
            if (show.Checked)
            {
                confirm_pass.PasswordChar = '\0';
            }
            else
            {
                confirm_pass.PasswordChar = '●';
            }
        }

        private void username_TextChanged(object sender, System.EventArgs e)
        {
            username.Text = string.Concat(username.Text.Where(char.IsLetterOrDigit));
        }

        public void reset()
        {
            emp_fname.Text = "";
            id.Text = "";
            userPic.Image = userPic.InitialImage;
            emp_lname.Text = "";
            phone.Text = "";
            user_type.SelectedIndex = -1;
            governate.SelectedIndex = -1;
            region.SelectedIndex = -1;
            confirm_pass.Text = "";
        }


        private void confirm_pass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            
        }

        private void guna2Button3_Click(object sender, System.EventArgs e)
        {
            MovePic(sender);

            if (string.IsNullOrEmpty(id.Text) && string.IsNullOrEmpty(username.Text))
            {
                errorProvider.SetError(username, "من فضلك أدخل   اسم المستخدم حتي تعرض البيانات");

            }

            else
            {

                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    xuiObjectAnimator.StandardAnimate(panelLoader, XanderUI.XUIObjectAnimator.StandardAnimation.SlideDown,5);
                    backgroundWorker.RunWorkerAsync("emp_display");
                }
            }

        }

        private void guna2Button4_Click(object sender, System.EventArgs e)
        {
            MovePic(sender);
            if (string.IsNullOrEmpty(emp_fname.Text))
            {
                errorProvider.SetError(emp_fname, "ادخل الاسم الأول");
            }
            else if (string.IsNullOrEmpty(emp_lname.Text))
            {
                errorProvider.SetError(emp_lname, "ادخل الاسم الأخير");
            }
            else if (string.IsNullOrEmpty(id.Text))
            {
                errorProvider.SetError(id, "ادخل الرقم القومي");
            }
            else if (governate.SelectedIndex == -1)
            {
                errorProvider.SetError(governate, "ادخل المحافظة");
            }
            else if (region.SelectedIndex == -1)
            {
                errorProvider.SetError(region, "ادخل المنطقة");
            }
            else if (string.IsNullOrEmpty(phone.Text))
            {
                errorProvider.SetError(phone, "ادخل رقم الهاتف");
            }
            else if (string.IsNullOrEmpty(username.Text))
            {
                errorProvider.SetError(username, "ادخل اسم المستخدم");
            }
            else if (user_type.SelectedIndex == -1)
            {
                errorProvider.SetError(user_type, "ادخل نوع المستخدم");
            }
 
            else
            {
                if (!backgroundWorker.IsBusy)
                {
                    panelLoader.Visible = true;
                    xuiObjectAnimator.StandardAnimate(panelLoader, XanderUI.XUIObjectAnimator.StandardAnimation.SlideDown, 5);
                    backgroundWorker.RunWorkerAsync("emp_add");
                }
            }

        }
        private void guna2Button5_Click(object sender, System.EventArgs e)
        {
            MovePic(sender);


            if (string.IsNullOrEmpty(emp_fname.Text))
            {
                errorProvider.SetError(emp_fname, "ادخل الاسم الأول");
            }
            else if (string.IsNullOrEmpty(emp_lname.Text))
            {
                errorProvider.SetError(emp_lname, "ادخل الاسم الأخير");
            }
            else if (string.IsNullOrEmpty(id.Text))
            {
                errorProvider.SetError(id, "ادخل الرقم القومي");
            }
            else if (governate.SelectedIndex == -1)
            {
                errorProvider.SetError(governate, "ادخل المحافظة");
            }
            else if (region.SelectedIndex == -1)
            {
                errorProvider.SetError(region, "ادخل المنطقة");
            }
            else if (string.IsNullOrEmpty(phone.Text))
            {
                errorProvider.SetError(phone, "ادخل رقم الهاتف");
            }
            else if (string.IsNullOrEmpty(username.Text))
            {
                errorProvider.SetError(username, "ادخل اسم المستخدم");
            }
            else if (user_type.SelectedIndex == -1)
            {
                errorProvider.SetError(user_type, "ادخل نوع المستخدم");
            }

            else
            {
                if (!backgroundWorker.IsBusy)
                {

                    panelLoader.Visible = true;
                    xuiObjectAnimator.StandardAnimate(panelLoader, XanderUI.XUIObjectAnimator.StandardAnimation.SlideDown, 5);
                    backgroundWorker.RunWorkerAsync("emp_update");
                }
            }

        }
        private void guna2Button6_Click(object sender, System.EventArgs e)
        {
            MovePic(sender);

            if (string.IsNullOrEmpty(id.Text) || string.IsNullOrEmpty(username.Text))
            {
                errorProvider.SetError(id, "برجاء إدخال الرقم القومي او اسم المستخدم حتي تحذف المستخدم");
                errorProvider.SetError(username, "برجاء إدخال الرقم القومي او اسم المستخدم حتي تحذف المستخدم");
            }
            else
            {
                if (!backgroundWorker.IsBusy)
                {
                    backgroundWorker.RunWorkerAsync("emp_delete");
                }
            }


        }
   
        private void xuiBatteryPercentageAPI_Tick(object sender, System.EventArgs e)
        {
            batteryStatus.Value = xuiBatteryPercentageAPI.Value;
            ToolTip.SetToolTip(batteryStatus, "Battery Status : " + xuiBatteryPercentageAPI.Value);
        }

        private void userPic_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                userPic.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void backgroundWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            string buttonName = (string)e.Argument;
            SQL_SERVER_Queris.emp_mangement _Mangement = new SQL_SERVER_Queris.emp_mangement();
            switch (buttonName)
            {
                case "emp_display":
                    _Mangement.DisplayData(userPic, id, emp_fname, emp_lname, emp_date, phone, user_type,governate,region, username,confirm_pass,service_type);
                    break;
                case "emp_add":
                    _Mangement.InsertData(userPic,id,emp_fname,emp_lname,emp_date,phone,user_type, governate.SelectedItem.ToString() + "-" + region.SelectedItem.ToString(), username,confirm_pass,service_type,panelLoader);
                    break;

                case "emp_update":
                    _Mangement.UpdateData(userPic, id, emp_fname, emp_lname, emp_date, phone, user_type, governate.SelectedItem.ToString() + "-" + region.SelectedItem.ToString(), username, confirm_pass,service_type, panelLoader);
                    break;

                case "emp_delete":
                    _Mangement.deleteData(id,username);
                    reset();
                    break;
            }



        }

        private void clearFields_CheckedChanged(object sender, EventArgs e)
        {
            if(clearFields.Checked)
            {
                if(MessageBox.Show("هل تريد حذف جميع المدخلات ؟؟","تحذير",MessageBoxButtons.YesNo,MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    reset();
                    clearFields.Checked = false;
                }
                else
                {
                    clearFields.Checked = false;

                }
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            panelLoader.Visible = false;
            backgroundWorker.CancelAsync();

        }

        private void emp_fname_TextChanged(object sender, EventArgs e)
        {
            Random random = new Random();
            if (emp_fname.Text.Contains("محمود"))
            {
                
                username.Text = "mahmoud" + random.Next(100, 10000);
            }
            else if (emp_fname.Text.Contains("مصطفي"))
            {
                username.Text = "mostafa" + random.Next(100, 10000);
            }
            else if (emp_fname.Text.Contains("حسام"))
            {
                username.Text = "hossam" + random.Next(100, 10000);
            }
            else if (emp_fname.Text.Contains("محمد"))
            {
                username.Text = "mohamed" + random.Next(100, 10000);
            }
            else if (emp_fname.Text.Contains("فضل"))
            {
                username.Text = "fadl" + random.Next(100, 10000);
            }
            else if (emp_fname.Text.Contains("احمد"))
            {
                username.Text = "ahmed" + random.Next(100, 10000);
            }
            else
            {
                username.Text = "";
            }
        }

        private void governate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(governate.SelectedIndex == 0)  // القاهرة
            {
                region.Items.Clear();
                region.Items.Add("مكتب سجل مدني ابو النمرس");
                region.Items.Add("مكتب سجل مدني الازبكية");
                region.Items.Add("مكتب سجل مدني التبين");
                region.Items.Add("مكتب سجل مدني الحوامدية");
                region.Items.Add("مكتب سجل مدني الخليفة");
                region.Items.Add("مكتب سجل مدني الساحل");
                region.Items.Add("مكتب سجل مدني الشيخ زايد");
                region.Items.Add("مكتب سجل مدني العبور");
                region.Items.Add("مكتب سجل مدني العياط");
                region.Items.Add("مكتب سجل مدني القاهرة الجديدة ٣");
                region.Items.Add("مكتب سجل مدني المطرية");
                region.Items.Add("مكتب سجل مدني النزهة");
                region.Items.Add("مكتب سجل مدني امبابة - فرع ١");
                region.Items.Add("مكتب سجل مدني باب الشعرية");
                region.Items.Add("مكتب سجل مدني بولاق الدكرور");
                region.Items.Add("مكتب سجل مدني حلوان - فرع ٢");
                region.Items.Add("مكتب سجل مدني شبرا الخيمة ١");
                region.Items.Add("مكتب سجل مدني طوخ");
                region.Items.Add("مكتب سجل مدني قصر النيل");
                region.Items.Add("مكتب سجل مدني مدينة ٦ اكتوبر");


            }

        }
    }
}

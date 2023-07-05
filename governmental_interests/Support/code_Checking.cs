using System;
using System.Linq;
using System.Windows.Forms;

namespace governmental_interests.Support
{
    public partial class code_Checking : Form
    {
        public code_Checking()
        {
            InitializeComponent();
        }

        private void sendCode_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(code.Text))
            {
                MessageBox.Show("برجاء ادخال الكود اولا","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                Support.Code_Generation code_ = new Code_Generation();
                if(string.Equals(code.Text,code_.ReadCode()))
                {
                    this.Close();
                    var bool_for_code = Application.OpenForms.OfType<technical_support>().First();
                    bool_for_code.close_code = true;
                }
                else
                {
                    MessageBox.Show("الكود غير صحيح", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }
    }
}

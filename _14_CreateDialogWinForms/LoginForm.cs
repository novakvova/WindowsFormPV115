using _14_CreateDialogWinForms.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms
{
    public partial class LoginForm : Form
    {
        private readonly AppFormData _formData;

        public LoginForm(AppFormData appForm)
        {
            InitializeComponent();
            _formData = appForm;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            //Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var user = _formData.Users.Where(x=>x.Phone==txtPhone.Text).FirstOrDefault();
            if(user!=null)
            {
                MessageBox.Show($"{user.FirstName} {user.LastName}");
            }    
        }
    }
}

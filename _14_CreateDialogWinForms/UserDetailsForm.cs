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
    public partial class UserDetailsForm : Form
    {
        public int UserID { get; set; }
        private AppFormData _formData;
        public UserDetailsForm(AppFormData formData)
        {
            InitializeComponent();
            _formData = formData;
        }

        private void UserDetailsForm_Load(object sender, EventArgs e)
        {
            //MessageBox.Show($"User Id {UserID}");
            var user = _formData.Users.SingleOrDefault(x => x.Id == UserID);
            pbImage.Image = Image.FromFile($"images/300_{user.Image}");
        }
    }
}

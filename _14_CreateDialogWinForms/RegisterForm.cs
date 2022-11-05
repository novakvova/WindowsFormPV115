using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _14_CreateDialogWinForms
{
    public partial class RegisterForm : Form
    {
        private string imageSelect = string.Empty;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Filter
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Select file "+ofd.FileName);
                pbImage.Image = Image.FromFile(ofd.FileName);
                imageSelect= ofd.FileName;
            }

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile("images/select.jpg");
            MyComboBoxItem male = new MyComboBoxItem();
            male.Name = "Чоловік";
            male.Id =(int)Gender.Male;
            cbGender.Items.Add(male);
            MyComboBoxItem female = new MyComboBoxItem();
            female.Name = "Жінка";
            female.Id = (int)Gender.Female;
            cbGender.Items.Add(female);
            cbGender.SelectedIndex = 0;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(cbGender.SelectedIndex.ToString());
            if(cbGender.SelectedIndex<0)
            {
                MessageBox.Show("Визначтеся із стать");
                return;
            }
            if(string.IsNullOrEmpty(imageSelect))
            {
                MessageBox.Show("Оберіть фото");
                return;
            }
            var select = cbGender.SelectedItem as MyComboBoxItem;

            AppFormData appFormData = new AppFormData();

            string exp = Path.GetExtension(imageSelect);
            string fileName = Path.GetRandomFileName()+exp;
            var bitmap = new Bitmap(Image.FromFile(imageSelect));
            var saveBmp = ImageWorker.CompressImage(bitmap, 50, 50, false);
            saveBmp.Save($"images/{fileName}", ImageFormat.Jpeg);
            //File.Copy(imageSelect, $"images/{fileName}", true);
            
            



            UserEntity user = new UserEntity
            {
                FirstName=txtName.Text,
                Image= fileName,
                LastName=txtLastName.Text,
                Phone=txtPhone.Text,
                Password=txtPassword.Text,
                Gender=(Gender)select.Id
            };
            appFormData.Users.Add(user);
            appFormData.SaveChanges();
            this.Close();

        }
    }
}

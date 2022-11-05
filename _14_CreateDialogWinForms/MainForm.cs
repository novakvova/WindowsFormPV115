using _14_CreateDialogWinForms.Data;
using Bogus;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;

namespace _14_CreateDialogWinForms
{
    public partial class MainForm : Form
    {
        private readonly AppFormData _formData;
        public MainForm()
        {
            InitializeComponent();
            try
            {
                _formData = new AppFormData();
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
        }
        private void UpdateUsersList()
        {
            dgvUsers.Rows.Clear();
            var users = _formData.Users.ToList();
            foreach (var user in users)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/50_{user.Image}"));
                    object[] row = {user.Id, user.FirstName+" "+user.LastName, user.Phone,
                    user.Gender, Image.FromStream(ms) };
                    dgvUsers.Rows.Add(row);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello app");
            UpdateUsersList();
        }

        private void btnShowLoginForm_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(_formData);
            loginForm.ShowDialog();
        }

        private void btnShowRegisterForm_Click(object sender, EventArgs e)
        {
            RegisterForm dlg = new RegisterForm();
            dlg.ShowDialog();
            UpdateUsersList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dgvUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvUsers.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    var selectRowIndex = dgvUsers.SelectedCells[0].RowIndex;
                    var id = int.Parse(dgvUsers.Rows[selectRowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    var userDel = _formData.Users.SingleOrDefault(x => x.Id == id);
                    if (!string.IsNullOrEmpty(userDel.Image))
                    {
                        File.Delete($"images/{userDel.Image}");
                    }
                    _formData.Users.Remove(userDel);
                    _formData.SaveChanges();
                    UpdateUsersList();

                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dgvUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvUsers.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    var selectRowIndex = dgvUsers.SelectedCells[0].RowIndex;
                    var id = int.Parse(dgvUsers.Rows[selectRowIndex].Cells[0].Value.ToString());
                    //MessageBox.Show(id.ToString());
                    var user = _formData.Users.SingleOrDefault(x => x.Id == id);
                    EditUserForm editForm = new EditUserForm(_formData);
                    editForm.initTxtName = user.FirstName;
                    editForm.initTxtLastName = user.LastName;
                    editForm.initTxtPhone = user.Phone;
                    editForm.initTxtPassword = user.Password;
                    editForm.initSelectGender=user.Gender;
                    editForm.initImageUser = user.Image;
                    editForm.initUserId = user.Id;
                    editForm.ShowDialog();
                    UpdateUsersList();

                }
            }
           
            //MessageBox.Show("Edit item");
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            var testOrders = new Faker<UserEntity>("uk")
            //Ensure all properties have rules. By default, StrictMode is false
            //Set a global policy by using Faker.DefaultStrictMode
                .RuleFor(u => u.Gender, f => f.PickRandom<Gender>())
                .RuleFor(u => u.FirstName, (f, u) => f.Name.FirstName((Bogus.DataSets.Name.Gender)(int)u.Gender))
                .RuleFor(u => u.LastName, (f, u) => f.Name.LastName((Bogus.DataSets.Name.Gender)(int)u.Gender))
                .RuleFor(u => u.Phone, (f, u) => f.Phone.PhoneNumber())
                .RuleFor(u => u.Password, (f, u) => f.Internet.Password())
                .RuleFor(u => u.Image, (f, u) => f.Image.LoremFlickrUrl());

            for (int i = 0; i < 2; i++)
            {
                var user = testOrders.Generate();
                using (WebClient client = new WebClient())
                {
                    //byte[] data = client.DownloadData(user.Image);
                    using (Stream stream = client.OpenRead(user.Image))
                    {
                        Bitmap bitmap; 
                        bitmap = new Bitmap(stream);
                        string fileName = Path.GetRandomFileName() + ".jpg";
                        string[] sizes = { "50", "150", "300", "600" };
                        foreach (string size in sizes)
                        {
                            int width = int.Parse(size);
                            var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                            saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                        }
                        user.Image = fileName;
                    }
                }
                _formData.Users.Add(user);
                _formData.SaveChanges();
            }

        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = dgvUsers.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                if (dgvUsers.AreAllCellsSelected(true))
                {
                    MessageBox.Show("All cells are selected", "Selected Cells");
                }
                else
                {
                    var selectRowIndex = dgvUsers.SelectedCells[0].RowIndex;
                    var id = int.Parse(dgvUsers.Rows[selectRowIndex].Cells[0].Value.ToString());
                    UserDetailsForm userDetails = new UserDetailsForm(_formData);
                    userDetails.UserID = id;

                    userDetails.ShowDialog();

                    

                }
            }
        }

        //UserEntity user = new UserEntity
        //{
        //    FirstName = txtName.Text,
        //    Image = fileName,
        //    LastName = txtLastName.Text,
        //    Phone = txtPhone.Text,
        //    Password = txtPassword.Text,
        //    Gender = (Gender)select.Id
        //};
    }
}
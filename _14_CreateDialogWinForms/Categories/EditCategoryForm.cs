using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms.Categories
{
    public partial class EditCategoryForm : Form
    {
        private string imageSelect = string.Empty;
        public int CategoryID { get; set; }
        private string fileName;
        private readonly AppFormData _appFormData;
        public EditCategoryForm(AppFormData appFormData)
        {
            InitializeComponent();
            _appFormData=appFormData;
        }
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            //Filter
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show("Select file "+ofd.FileName);
                pbImage.Image = Image.FromFile(ofd.FileName);
                imageSelect = ofd.FileName;
            }
        }
        private void btnRegCategory_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(imageSelect))
            {
                var bitmap = new Bitmap(Image.FromFile(imageSelect));
                string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                foreach (string size in sizes)
                {
                    int width = int.Parse(size);
                    var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                    saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                }
            }

            CategoryEntity category = _appFormData.Categories
                .SingleOrDefault(x => x.Id==CategoryID); 
            
                category.Name = txtName.Text;
                category.Image = fileName;
                category.Proirity = int.Parse(txtPrioritet.Text);

            _appFormData.Categories.Update(category);
            _appFormData.SaveChanges();
            this.DialogResult= DialogResult.OK;
        }

        private void EditCategoryForm_Load(object sender, EventArgs e)
        {
            var category = _appFormData.Categories.SingleOrDefault(x=>x.Id==CategoryID);
            if (category != null)
            {
                txtName.Text = category.Name;
                txtPrioritet.Text = category.Proirity.ToString();
                fileName = category.Image;
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/150_{category.Image}"));
                    pbImage.Image = Image.FromStream(ms);
                }
            }
        }
    }
}

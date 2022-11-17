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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms.Categories
{
    public partial class CreateCategoryForm : Form
    {
        private string imageSelect = string.Empty;
        public CreateCategoryForm()
        {
            InitializeComponent();
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

            AppFormData appFormData = new AppFormData();

            string exp = Path.GetExtension(imageSelect);
            string fileName = Path.GetRandomFileName() + exp;
            var bitmap = new Bitmap(Image.FromFile(imageSelect));

            //File.Copy(imageSelect, $"images/{fileName}", true);

            string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
            foreach (string size in sizes)
            {
                int width = int.Parse(size);
                var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
            }

            CategoryEntity category = new CategoryEntity
            {
                Name = textBox2.Text,
                Image = fileName,
                Proirity = int.Parse(textBox3.Text),
            };
            appFormData.Categories.Add(category);
            appFormData.SaveChanges();
            this.DialogResult= DialogResult.OK;
        }
    }
}

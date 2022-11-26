using _14_CreateDialogWinForms.Categories;
using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Helpers;
using _14_CreateDialogWinForms.Products;
using Bogus;
using Bogus.DataSets;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace _14_CreateDialogWinForms
{
    public partial class HomeForm : Form
    {
        private readonly AppFormData _formData;
        public HomeForm()
        {
            InitializeComponent();
            try
            {
                _formData = new AppFormData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FileExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuDataUsers_Click(object sender, EventArgs e)
        {
            UsersForm dlg = new UsersForm();
            dlg.ShowDialog();
        }


        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Ви дійсно хочете вийдти?", "Вихід", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
                return;
            }
            //
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            LoadDataCategories();
        }

        private void LoadDataCategories()
        {
            lvCategories.Clear();
            lvCategories.LargeImageList = new ImageList();
            lvCategories.LargeImageList.ImageSize = new Size(100, 75);
            foreach(var c in _formData.Categories
                .OrderBy(c => c.Proirity)
                .ToList())
            {
                string id = "0";
                string image = "no_image.jpg";
                if(c.Image!=null)
                {
                    image = c.Image.ToString();
                    id=c.Id.ToString();
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/150_{c.Image}"));
                    lvCategories.LargeImageList.Images.Add(id, Image.FromStream(ms));
                    ListViewItem item = new ListViewItem();
                    item.Text = c.Name+"\r\n"+c.Proirity;
                    item.Tag = c;
                    item.ImageKey= id;
                    lvCategories.Items.Add(item);
                }

            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            CreateCategoryForm dlg = new CreateCategoryForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                LoadDataCategories();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectCategories = lvCategories.SelectedItems;
            if(selectCategories.Count > 0 )
            {
                var item = selectCategories[0];
                var catetory = (CategoryEntity)item.Tag;
                // MessageBox.Show("Category = "+ catetory.Id);
                var delete = _formData.Categories.SingleOrDefault(x=>x.Id==catetory.Id);
                if(delete != null)
                {
                    string fileName = delete.Image;
                    string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                    foreach (string size in sizes)
                    {
                        string deleFile = $"images/{size}_{fileName}";
                        if (File.Exists(deleFile))
                            File.Delete(deleFile);
                    }
                    _formData.Categories.Remove(delete);
                    _formData.SaveChanges();
                    lvCategories.Items.Remove(item);
                }
            }
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            var selectCategories = lvCategories.SelectedItems;
            if (selectCategories.Count > 0)
            {
                var item = selectCategories[0];
                var category = (CategoryEntity)item.Tag;
                EditCategoryForm dlg = new EditCategoryForm(_formData);
                dlg.CategoryID = category.Id;
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    LoadDataCategories();
                }
            }
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateProductForm dlg = new CreateProductForm();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var product = new ProductEntity
                {
                    Name = dlg.ProductName,
                    Description = dlg.ProductDescription,
                    Price = decimal.Parse(dlg.ProductPrice),
                };
                string images = "";
                int count = dlg.ProductImages.Count;
                int i = 1;
                foreach (var image in dlg.ProductImages)
                {
                    var img = Image.FromFile(image);
                    Bitmap bitmap;
                    bitmap = new Bitmap(img);
                    string fileName = Path.GetRandomFileName() + ".jpg";
                    string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                    foreach (string size in sizes)
                    {
                        int width = int.Parse(size);
                        var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                        saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                    }
                    images += fileName + (i == count ? "" : " ");
                    i++;
                }
                product.Images = images;
                _formData.Products.Add(product);
                _formData.SaveChanges();
            }
        }
    }
}

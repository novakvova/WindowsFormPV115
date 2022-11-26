using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Helpers;
using Bogus.DataSets;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms.Products
{
    public partial class ShowProductsForm : Form
    {
        private readonly AppFormData _formData;
        public ShowProductsForm()
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

        private void ShowProducts_Load(object sender, EventArgs e)
        {
            lvProducts.Clear();
            lvProducts.LargeImageList = new ImageList();
            lvProducts.LargeImageList.ImageSize = new Size(100, 75);
            foreach (var c in _formData.Products
                .OrderBy(c => c.Id)
                .ToList())
            {
                string id = "0";
                string image = "no_image.jpg";

                if (c.Images != null)
                {

                    image = c.Images.ToString();
                    id = c.Id.ToString();
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/150_{c.Images.Split(' ')[0]}"));
                    lvProducts.LargeImageList.Images.Add(id, Image.FromStream(ms));
                    ListViewItem item = new ListViewItem();
                    item.Text = c.Name;
                    item.Tag = c;
                    item.ImageKey = id;
                    lvProducts.Items.Add(item);
                }

            }
        }

        private void deleteItm_Click(object sender, EventArgs e)
        {
            var selectCategories = lvProducts.SelectedItems;
            if (selectCategories.Count > 0)
            {
                var item = selectCategories[0];
                var catetory = (ProductEntity)item.Tag;
                var delete = _formData.Products.SingleOrDefault(x => x.Id == catetory.Id);
                if (delete != null)
                {
                    string[] fileName = delete.Images.Split(' ');
                    foreach (string fileName2 in fileName)
                    {
                        string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                        foreach (string size in sizes)
                        {
                            string deleFile = $"images/{size}_{fileName2}";
                            if (File.Exists(deleFile))
                                File.Delete(deleFile);
                        }

                    }
                    _formData.Products.Remove(delete);
                    _formData.SaveChanges();
                    lvCategories.Items.Remove(item);
                }
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            var selectCategories = lvProducts.SelectedItems;
            if (selectCategories.Count > 0)
            {
                var itemSelect = selectCategories[0];
                var product = (ProductEntity)itemSelect.Tag;
                var editProduct = _formData.Products.SingleOrDefault(x => x.Id == product.Id);
                if (editProduct != null)
                {
                    EditProductForm dlg = new EditProductForm();
                    dlg.SetTxtName=editProduct.Name;
                    dlg.SetTxtDescription=editProduct.Description;
                    dlg.SetTxtPrice=editProduct.Price.ToString();
                    //dlg.SetListViewItemImages = editProduct.Images.Split(' ');                   
                    dlg.Product_Images = new List<ImageItemListView>();
                    int id = 1;
                    foreach (var image in editProduct.Images.Split(' '))
                    {
                        dlg.Product_Images.Add(new ImageItemListView
                        {
                            Id = id,
                            Name = image
                        });
                        id++;
                    }
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        foreach (var pImgDel in dlg.RemoveFiles)
                        {
                            string name = pImgDel.Name;
                            string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                            foreach (string size in sizes)
                            {
                                string deleFile = $"images/{size}_{name}";
                                if (File.Exists(deleFile))
                                    File.Delete(deleFile);
                            }
                        }
                        var editProd = _formData.Products.SingleOrDefault(x => x.Id == product.Id);
                        if (editProd != null)
                        {
                            editProd.Name = dlg.ProductName;
                            editProd.Description = dlg.ProductDescription;
                            editProd.Price = decimal.Parse(dlg.ProductPrice);

                            string images = "";
                            int count = dlg.Product_Images.Count;
                            int i = 1;
                            foreach (var image in dlg.Product_Images)
                            {
                                if(image.Id == 0)
                                {
                                    var img = Image.FromFile(image.Name);
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
                                    
                                }
                                else
                                {
                                    images += image.Name + (i == count ? "" : " ");
                                }
                                i++;

                            }
                            product.Images = images;
                            _formData.Update(product);
                            _formData.SaveChanges();
                        }


                    }
                }
            }


           
        }
    }
}

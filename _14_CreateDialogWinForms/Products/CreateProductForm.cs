using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_CreateDialogWinForms.Products
{
    public partial class CreateProductForm : Form
    {
        public CreateProductForm()
        {
            InitializeComponent();
            lvImages.LargeImageList = new ImageList();
            lvImages.LargeImageList.ImageSize = new Size(90, 65);
            lvImages.MultiSelect = false;
            lvImages.InsertionMark.Color= Color.Green;
            lvImages.AllowDrop = true;
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string key = Guid.NewGuid().ToString();
                ListViewItem item= new ListViewItem();
                item.Tag = dlg.FileName;
                item.Text = Path.GetFileName(dlg.FileName);
                item.ImageKey = key;
                lvImages.LargeImageList.Images.Add(key, Image.FromFile(dlg.FileName));
                lvImages.Items.Add(item);

            }
        }
    }
}

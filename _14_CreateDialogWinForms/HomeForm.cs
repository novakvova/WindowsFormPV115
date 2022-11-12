using _14_CreateDialogWinForms.Data;
using Bogus;
using Bogus.DataSets;
using Microsoft.VisualBasic.ApplicationServices;
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
            foreach(var c in _formData.Categories.ToList())
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
                    item.Text = c.Name;
                    item.Tag = c;
                    item.ImageKey= id;
                    lvCategories.Items.Add(item);
                }

            }
        }
    }
}

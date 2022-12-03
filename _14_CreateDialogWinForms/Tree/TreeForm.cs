using _14_CreateDialogWinForms.Data;
using _14_CreateDialogWinForms.Helpers;
using Microsoft.EntityFrameworkCore;
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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _14_CreateDialogWinForms.Tree
{
    public partial class TreeForm : Form
    {
        private string imageSelect = string.Empty;
        private bool isEdit = false;
        private int editId = 0;
        private readonly AppFormData appFormData; 
        public TreeForm()
        {
            InitializeComponent();
            tvProducts.ImageList = new ImageList();
            appFormData=new AppFormData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int? parentId = null;
            if(cbChild.Checked)
            {
                parentId = (tvProducts.SelectedNode.Tag as TreeEntity).Id;
            }
            Bitmap bitmap = new Bitmap(imageSelect);
            string fileName = Path.GetRandomFileName() + ".jpg";
            string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
            foreach (string size in sizes)
            {
                int width = int.Parse(size);
                var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
            }
            TreeEntity treeitem = new TreeEntity();
            treeitem.Name = txtName.Text;
            treeitem.Image = fileName;
            treeitem.ParentId=parentId;
            appFormData.Trees.Add(treeitem);
            appFormData.SaveChanges();
            LoadData();
        }

        private void LoadData()
        {
            imageSelect = String.Empty;
            txtName.Text = "";
            pbImage.Image = Image.FromFile("images/select.jpg");
            tvProducts.Nodes.Clear();
            tvProducts.ImageList = new ImageList();
            foreach (var item in appFormData.Trees.Where(x => x.ParentId == null).ToList())
            {
                string id = item.Id.ToString();

                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/50_{item.Image}"));
                    tvProducts.ImageList.Images.Add(id, Image.FromStream(ms));
                }
                TreeNode node = new TreeNode(item.Name);
                node.Tag = item;
                node.ImageKey = id;
                node.SelectedImageKey = id;
                node.Nodes.Add("");
                tvProducts.Nodes.Add(node);
            }
        }
        private void TreeForm_Load(object sender, EventArgs e)
        {
            LoadData();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            var parent = tvProducts.SelectedNode;
            if (parent != null)
            {
                tvProducts.Nodes.Remove(parent);
            }
        }

        private void tvProducts_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            var hitTest = e.Node.TreeView.HitTest(e.Location);
            if (hitTest.Location != TreeViewHitTestLocations.PlusMinus)
                return;
            if (!e.Node.IsExpanded)
                return;
            var item = e.Node.Tag as TreeEntity;
            var list= appFormData.Trees.Where(x => x.ParentId == item.Id).ToList();
            e.Node.Nodes.Clear();
            if (list.Count > 0)
            {
                foreach (var c in list)
                {
                    TreeNode node = new TreeNode(c.Name);
                    using (MemoryStream ms = new MemoryStream())
                    {
                        ms.Write(File.ReadAllBytes($"images/50_{c.Image}"));
                        tvProducts.ImageList.Images.Add(c.Id.ToString(), Image.FromStream(ms));
                    }
                   
                    node.ImageKey = c.Id.ToString();
                    node.SelectedImageKey = c.Id.ToString();
                    node.Nodes.Add("");
                    node.Tag = c;
                    e.Node.Nodes.Add(node);
                }
            }
        }

        private void btnEditAndSave_Click(object sender, EventArgs e)
        {
            if (!isEdit)
            {
                var item = tvProducts.SelectedNode;
                if (item == null) return;
                var treeView = item.Tag as TreeEntity;
                if (treeView == null) return;
                btnEditAndSave.Text = "Зберегти зміни";
                isEdit = true;
                editId=treeView.Id;
                txtName.Text = treeView.Name;
                using (MemoryStream ms = new MemoryStream())
                {
                    ms.Write(File.ReadAllBytes($"images/300_{treeView.Image}"));
                pbImage.Image = Image.FromStream(ms);
                }
            }
            else
            {
                isEdit = false;
                var entity = appFormData.Trees.SingleOrDefault(x => x.Id == editId);
                if(entity != null)
                {
                    entity.Name=txtName.Text;
                    tvProducts.SelectedNode.Text = txtName.Text;
                    appFormData.SaveChanges();
                    if(!string.IsNullOrEmpty(imageSelect))
                    {
                        
                        Bitmap bitmap = new Bitmap(imageSelect);
                        string fileName = entity.Image;
                        string[] sizes = MyAppConfig.GetSectionValue("ImageSizes").Split(',');
                        foreach (string size in sizes)
                        {
                            int width = int.Parse(size);
                            var saveBMP = ImageWorker.CompressImage(bitmap, width, width, false);
                            saveBMP.Save($"images/{size}_{fileName}", ImageFormat.Jpeg);
                        }
                        using (MemoryStream ms = new MemoryStream())
                        {
                            ms.Write(File.ReadAllBytes($"images\\50_{entity.Image}"));
                            tvProducts.ImageList.Images.Add(entity.Id.ToString(), Image.FromStream(ms));
                        }
                        tvProducts.SelectedNode.ImageKey = entity.Id.ToString();
                        tvProducts.SelectedNode.SelectedImageKey = entity.Id.ToString();
                    }
                    btnEditAndSave.Text = "Змінить";
                }
            }

        }
    }
}

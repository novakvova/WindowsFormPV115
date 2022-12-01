using _14_CreateDialogWinForms.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _14_CreateDialogWinForms.Tree
{
    public partial class TreeForm : Form
    {
        private string imageSelect = string.Empty;
        private readonly AppFormData appFormData; 
        public TreeForm()
        {
            InitializeComponent();
            tvProducts.ImageList = new ImageList();
            appFormData=new AppFormData();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            tvProducts.ImageList.Images.Add(id, Image.FromFile(imageSelect));
            TreeNode node = new TreeNode(txtName.Text);
            node.Tag = id;
            node.ImageKey= id;
            node.SelectedImageKey= id;
            node.Nodes.Add("");
            if(cbChild.Checked)
            {
                var parent = tvProducts.SelectedNode;
                if(parent != null)
                {
                    parent.Nodes.Add(node);
                }
            }
            else
            {
                tvProducts.Nodes.Add(node);
            }

            txtName.Text = "";
            pbImage.Image = Image.FromFile("images/select.jpg");
        }

        private void TreeForm_Load(object sender, EventArgs e)
        {
            pbImage.Image = Image.FromFile("images/select.jpg");
            tvProducts.Nodes.Clear();
            tvProducts.ImageList = new ImageList();
            foreach (var item in appFormData.Trees.Where(x=>x.ParentId==null).ToList())
            {
                string id = item.Id.ToString();
                tvProducts.ImageList.Images.Add(id, Image.FromFile($@"images\50_{item.Image}"));
                TreeNode node = new TreeNode(item.Name);
                node.Tag = item;
                node.ImageKey = id;
                node.SelectedImageKey = id;
                node.Nodes.Add("");
                tvProducts.Nodes.Add(node);
            }

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
                    tvProducts.ImageList.Images.Add(c.Id.ToString(), Image.FromFile($"images\\50_{c.Image}"));
                    node.ImageKey = c.Id.ToString();
                    node.SelectedImageKey = c.Id.ToString();
                    node.Nodes.Add("");
                    node.Tag = c;
                    e.Node.Nodes.Add(node);
                }
            }
        }
    }
}

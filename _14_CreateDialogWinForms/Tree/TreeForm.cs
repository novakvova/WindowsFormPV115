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
        public TreeForm()
        {
            InitializeComponent();
            tvProducts.ImageList = new ImageList();
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if(dlg.ShowDialog() == DialogResult.OK)
            {
                string key = Guid.NewGuid().ToString();

            }
        }
    }
}

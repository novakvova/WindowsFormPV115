namespace _14_CreateDialogWinForms.Products
{
    partial class ShowProductsForm
    {
        // <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvProducts = new System.Windows.Forms.ListView();
            this.deleteItm = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(0, 51);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(800, 400);
            this.lvProducts.TabIndex = 4;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            // 
            // deleteItm
            // 
            this.deleteItm.Location = new System.Drawing.Point(713, 12);
            this.deleteItm.Name = "deleteItm";
            this.deleteItm.Size = new System.Drawing.Size(75, 23);
            this.deleteItm.TabIndex = 5;
            this.deleteItm.Text = "Удалить ";
            this.deleteItm.UseVisualStyleBackColor = true;
            this.deleteItm.Click += new System.EventHandler(this.deleteItm_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(580, 12);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(100, 28);
            this.btnEditProduct.TabIndex = 6;
            this.btnEditProduct.Text = "Змінити";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // ShowProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.deleteItm);
            this.Controls.Add(this.lvProducts);
            this.Name = "ShowProductsForm";
            this.Text = "ShowProducts";
            this.Load += new System.EventHandler(this.ShowProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.Button deleteItm;
        private System.Windows.Forms.Button btnEditProduct;
    }
}
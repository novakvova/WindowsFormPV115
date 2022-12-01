namespace _14_CreateDialogWinForms.Tree
{
    partial class TreeForm
    {
        /// <summary>
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
            this.tvProducts = new System.Windows.Forms.TreeView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbChild = new System.Windows.Forms.CheckBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // tvProducts
            // 
            this.tvProducts.Location = new System.Drawing.Point(12, 12);
            this.tvProducts.Name = "tvProducts";
            this.tvProducts.Size = new System.Drawing.Size(303, 426);
            this.tvProducts.TabIndex = 0;
            this.tvProducts.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvProducts_NodeMouseClick);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(692, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(96, 36);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Додати";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(330, 36);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 23);
            this.txtName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(330, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Назва";
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(330, 104);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(146, 133);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 4;
            this.pbImage.TabStop = false;
            this.pbImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(330, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Назва";
            // 
            // cbChild
            // 
            this.cbChild.AutoSize = true;
            this.cbChild.Location = new System.Drawing.Point(330, 254);
            this.cbChild.Name = "cbChild";
            this.cbChild.Size = new System.Drawing.Size(98, 19);
            this.cbChild.TabIndex = 5;
            this.cbChild.Text = "Під категорія";
            this.cbChild.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(330, 392);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 36);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Text = "Видалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // TreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.cbChild);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tvProducts);
            this.Name = "TreeForm";
            this.Text = "TreeForm";
            this.Load += new System.EventHandler(this.TreeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tvProducts;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbChild;
        private System.Windows.Forms.Button btnRemove;
    }
}
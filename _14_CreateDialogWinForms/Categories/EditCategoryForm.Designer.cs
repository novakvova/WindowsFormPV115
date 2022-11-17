namespace _14_CreateDialogWinForms.Categories
{
    partial class EditCategoryForm
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.txtPrioritet = new System.Windows.Forms.TextBox();
            this.lbNameCategory = new System.Windows.Forms.Label();
            this.lbPriorityCategory = new System.Windows.Forms.Label();
            this.btnRegCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(208, 23);
            this.txtName.TabIndex = 0;
            // 
            // pbImage
            // 
            this.pbImage.Location = new System.Drawing.Point(12, 130);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(123, 107);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 1;
            this.pbImage.TabStop = false;
            // 
            // btnSelectImage
            // 
            this.btnSelectImage.Location = new System.Drawing.Point(142, 166);
            this.btnSelectImage.Name = "btnSelectImage";
            this.btnSelectImage.Size = new System.Drawing.Size(75, 43);
            this.btnSelectImage.TabIndex = 2;
            this.btnSelectImage.Text = "Choose img";
            this.btnSelectImage.UseVisualStyleBackColor = true;
            this.btnSelectImage.Click += new System.EventHandler(this.btnSelectImage_Click);
            // 
            // txtPrioritet
            // 
            this.txtPrioritet.Location = new System.Drawing.Point(12, 84);
            this.txtPrioritet.Name = "txtPrioritet";
            this.txtPrioritet.Size = new System.Drawing.Size(208, 23);
            this.txtPrioritet.TabIndex = 3;
            // 
            // lbNameCategory
            // 
            this.lbNameCategory.AutoSize = true;
            this.lbNameCategory.Location = new System.Drawing.Point(12, 22);
            this.lbNameCategory.Name = "lbNameCategory";
            this.lbNameCategory.Size = new System.Drawing.Size(104, 15);
            this.lbNameCategory.TabIndex = 4;
            this.lbNameCategory.Text = "Name of Category";
            // 
            // lbPriorityCategory
            // 
            this.lbPriorityCategory.AutoSize = true;
            this.lbPriorityCategory.Location = new System.Drawing.Point(12, 66);
            this.lbPriorityCategory.Name = "lbPriorityCategory";
            this.lbPriorityCategory.Size = new System.Drawing.Size(110, 15);
            this.lbPriorityCategory.TabIndex = 4;
            this.lbPriorityCategory.Text = "Priority of Category";
            // 
            // btnRegCategory
            // 
            this.btnRegCategory.Location = new System.Drawing.Point(12, 243);
            this.btnRegCategory.Name = "btnRegCategory";
            this.btnRegCategory.Size = new System.Drawing.Size(208, 40);
            this.btnRegCategory.TabIndex = 5;
            this.btnRegCategory.Text = "Збегерти";
            this.btnRegCategory.UseVisualStyleBackColor = true;
            this.btnRegCategory.Click += new System.EventHandler(this.btnRegCategory_Click);
            // 
            // EditCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 296);
            this.Controls.Add(this.btnRegCategory);
            this.Controls.Add(this.lbPriorityCategory);
            this.Controls.Add(this.lbNameCategory);
            this.Controls.Add(this.txtPrioritet);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.txtName);
            this.Name = "EditCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Редагувати катгорію";
            this.Load += new System.EventHandler(this.EditCategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox txtPrioritet;
        private System.Windows.Forms.Label lbNameCategory;
        private System.Windows.Forms.Label lbPriorityCategory;
        private System.Windows.Forms.Button btnRegCategory;
    }
}
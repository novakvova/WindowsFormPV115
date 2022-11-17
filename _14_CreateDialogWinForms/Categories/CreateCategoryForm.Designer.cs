namespace _14_CreateDialogWinForms.Categories
{
    partial class CreateCategoryForm
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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.btnSelectImage = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbNameCategory = new System.Windows.Forms.Label();
            this.lbPriorityCategory = new System.Windows.Forms.Label();
            this.btnRegCategory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(208, 23);
            this.textBox2.TabIndex = 0;
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
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(208, 23);
            this.textBox3.TabIndex = 3;
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
            this.btnRegCategory.Text = "Enter Category";
            this.btnRegCategory.UseVisualStyleBackColor = true;
            this.btnRegCategory.Click += new System.EventHandler(this.btnRegCategory_Click);
            // 
            // CreateCategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 296);
            this.Controls.Add(this.btnRegCategory);
            this.Controls.Add(this.lbPriorityCategory);
            this.Controls.Add(this.lbNameCategory);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnSelectImage);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.textBox2);
            this.Name = "CreateCategoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Додати катгорію";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.Button btnSelectImage;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label lbNameCategory;
        private System.Windows.Forms.Label lbPriorityCategory;
        private System.Windows.Forms.Button btnRegCategory;
    }
}
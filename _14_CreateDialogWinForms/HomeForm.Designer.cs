namespace _14_CreateDialogWinForms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.headMenu = new System.Windows.Forms.MenuStrip();
            this.menuHeadFile = new System.Windows.Forms.ToolStripMenuItem();
            this.FileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuData = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDataUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.addProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.HomePanelStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripUsers = new System.Windows.Forms.ToolStripButton();
            this.lvCategories = new System.Windows.Forms.ListView();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.myTreeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.headMenu.SuspendLayout();
            this.HomePanelStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // headMenu
            // 
            this.headMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuHeadFile,
            this.menuData});
            this.headMenu.Location = new System.Drawing.Point(0, 0);
            this.headMenu.Name = "headMenu";
            this.headMenu.Size = new System.Drawing.Size(800, 24);
            this.headMenu.TabIndex = 0;
            this.headMenu.Text = "menuStrip1";
            // 
            // menuHeadFile
            // 
            this.menuHeadFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileExit});
            this.menuHeadFile.Name = "menuHeadFile";
            this.menuHeadFile.Size = new System.Drawing.Size(48, 20);
            this.menuHeadFile.Text = "Файл";
            // 
            // FileExit
            // 
            this.FileExit.Name = "FileExit";
            this.FileExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.FileExit.Size = new System.Drawing.Size(144, 22);
            this.FileExit.Text = "Вихід";
            this.FileExit.Click += new System.EventHandler(this.FileExit_Click);
            // 
            // menuData
            // 
            this.menuData.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDataUsers,
            this.addProductToolStripMenuItem,
            this.productsToolStripMenuItem,
            this.myTreeToolStripMenuItem});
            this.menuData.Name = "menuData";
            this.menuData.Size = new System.Drawing.Size(43, 20);
            this.menuData.Text = "Дані";
            // 
            // menuDataUsers
            // 
            this.menuDataUsers.Name = "menuDataUsers";
            this.menuDataUsers.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.menuDataUsers.Size = new System.Drawing.Size(180, 22);
            this.menuDataUsers.Text = "Users";
            this.menuDataUsers.Click += new System.EventHandler(this.menuDataUsers_Click);
            // 
            // addProductToolStripMenuItem
            // 
            this.addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            this.addProductToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addProductToolStripMenuItem.Text = "Додати продукт";
            this.addProductToolStripMenuItem.Click += new System.EventHandler(this.addProductToolStripMenuItem_Click);
            // 
            // productsToolStripMenuItem
            // 
            this.productsToolStripMenuItem.Name = "productsToolStripMenuItem";
            this.productsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productsToolStripMenuItem.Text = "Products";
            this.productsToolStripMenuItem.Click += new System.EventHandler(this.productsToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // HomePanelStrip
            // 
            this.HomePanelStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsers});
            this.HomePanelStrip.Location = new System.Drawing.Point(0, 24);
            this.HomePanelStrip.Name = "HomePanelStrip";
            this.HomePanelStrip.Size = new System.Drawing.Size(800, 25);
            this.HomePanelStrip.TabIndex = 2;
            this.HomePanelStrip.Text = "toolStrip1";
            // 
            // toolStripUsers
            // 
            this.toolStripUsers.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripUsers.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUsers.Image")));
            this.toolStripUsers.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUsers.Name = "toolStripUsers";
            this.toolStripUsers.Size = new System.Drawing.Size(23, 22);
            this.toolStripUsers.Text = "toolStripButton1";
            this.toolStripUsers.Click += new System.EventHandler(this.menuDataUsers_Click);
            // 
            // lvCategories
            // 
            this.lvCategories.HideSelection = false;
            this.lvCategories.Location = new System.Drawing.Point(0, 52);
            this.lvCategories.Name = "lvCategories";
            this.lvCategories.Size = new System.Drawing.Size(800, 307);
            this.lvCategories.TabIndex = 3;
            this.lvCategories.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Location = new System.Drawing.Point(12, 383);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(132, 42);
            this.btnAddCategory.TabIndex = 4;
            this.btnAddCategory.Text = "Додати категорію";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(150, 383);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(141, 42);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(297, 383);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(132, 42);
            this.btnEditCategory.TabIndex = 4;
            this.btnEditCategory.Text = "Змінити категорію";
            this.btnEditCategory.UseVisualStyleBackColor = true;
            this.btnEditCategory.Click += new System.EventHandler(this.btnEditCategory_Click);
            // 
            // myTreeToolStripMenuItem
            // 
            this.myTreeToolStripMenuItem.Name = "myTreeToolStripMenuItem";
            this.myTreeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.myTreeToolStripMenuItem.Text = "MyTree";
            this.myTreeToolStripMenuItem.Click += new System.EventHandler(this.myTreeToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.btnAddCategory);
            this.Controls.Add(this.lvCategories);
            this.Controls.Add(this.HomePanelStrip);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.headMenu);
            this.MainMenuStrip = this.headMenu;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.headMenu.ResumeLayout(false);
            this.headMenu.PerformLayout();
            this.HomePanelStrip.ResumeLayout(false);
            this.HomePanelStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip headMenu;
        private System.Windows.Forms.ToolStripMenuItem menuHeadFile;
        private System.Windows.Forms.ToolStripMenuItem FileExit;
        private System.Windows.Forms.ToolStripMenuItem menuData;
        private System.Windows.Forms.ToolStripMenuItem menuDataUsers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip HomePanelStrip;
        private System.Windows.Forms.ToolStripButton toolStripUsers;
        private System.Windows.Forms.ListView lvCategories;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEditCategory;
        private System.Windows.Forms.ToolStripMenuItem addProductToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myTreeToolStripMenuItem;
    }
}
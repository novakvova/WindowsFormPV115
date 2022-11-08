using System.Windows.Forms;

namespace _14_CreateDialogWinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnShowLoginForm = new System.Windows.Forms.Button();
            this.btnShowRegisterForm = new System.Windows.Forms.Button();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ColId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColImage = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnGen = new System.Windows.Forms.Button();
            this.btnDetails = new System.Windows.Forms.Button();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbCount = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowLoginForm
            // 
            this.btnShowLoginForm.Location = new System.Drawing.Point(424, 398);
            this.btnShowLoginForm.Name = "btnShowLoginForm";
            this.btnShowLoginForm.Size = new System.Drawing.Size(123, 63);
            this.btnShowLoginForm.TabIndex = 0;
            this.btnShowLoginForm.Text = "Відкрити форму для входу";
            this.btnShowLoginForm.UseVisualStyleBackColor = true;
            this.btnShowLoginForm.Click += new System.EventHandler(this.btnShowLoginForm_Click);
            // 
            // btnShowRegisterForm
            // 
            this.btnShowRegisterForm.Location = new System.Drawing.Point(553, 398);
            this.btnShowRegisterForm.Name = "btnShowRegisterForm";
            this.btnShowRegisterForm.Size = new System.Drawing.Size(123, 63);
            this.btnShowRegisterForm.TabIndex = 1;
            this.btnShowRegisterForm.Text = "Реєструватися";
            this.btnShowRegisterForm.UseVisualStyleBackColor = true;
            this.btnShowRegisterForm.Click += new System.EventHandler(this.btnShowRegisterForm_Click);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColId,
            this.ColFullName,
            this.ColPhone,
            this.ColGender,
            this.ColImage});
            this.dgvUsers.Location = new System.Drawing.Point(12, 110);
            this.dgvUsers.Name = "dgvUsers";
            this.dgvUsers.ReadOnly = true;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 50;
            this.dgvUsers.Size = new System.Drawing.Size(765, 282);
            this.dgvUsers.TabIndex = 2;
            // 
            // ColId
            // 
            this.ColId.HeaderText = "Id";
            this.ColId.MinimumWidth = 6;
            this.ColId.Name = "ColId";
            this.ColId.ReadOnly = true;
            this.ColId.Visible = false;
            this.ColId.Width = 125;
            // 
            // ColFullName
            // 
            this.ColFullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColFullName.HeaderText = "ПІБ";
            this.ColFullName.MinimumWidth = 6;
            this.ColFullName.Name = "ColFullName";
            this.ColFullName.ReadOnly = true;
            // 
            // ColPhone
            // 
            this.ColPhone.HeaderText = "Телефон";
            this.ColPhone.MinimumWidth = 6;
            this.ColPhone.Name = "ColPhone";
            this.ColPhone.ReadOnly = true;
            this.ColPhone.Width = 150;
            // 
            // ColGender
            // 
            this.ColGender.HeaderText = "Стать";
            this.ColGender.MinimumWidth = 6;
            this.ColGender.Name = "ColGender";
            this.ColGender.ReadOnly = true;
            this.ColGender.Width = 125;
            // 
            // ColImage
            // 
            this.ColImage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColImage.HeaderText = "Фото";
            this.ColImage.MinimumWidth = 6;
            this.ColImage.Name = "ColImage";
            this.ColImage.ReadOnly = true;
            this.ColImage.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColImage.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(12, 398);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 29);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Видалити";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(105, 398);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 29);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Редагувати";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnGen
            // 
            this.btnGen.Location = new System.Drawing.Point(12, 439);
            this.btnGen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(132, 22);
            this.btnGen.TabIndex = 5;
            this.btnGen.Text = "Генерація 100";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(688, 439);
            this.btnDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(82, 22);
            this.btnDetails.TabIndex = 6;
            this.btnDetails.Text = "Деталі";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(105, 9);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(124, 23);
            this.txtLastName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Прізвище";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(105, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(124, 23);
            this.txtName.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ім\'я";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(674, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(89, 33);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Пошук";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cbGender
            // 
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Location = new System.Drawing.Point(252, 33);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(158, 23);
            this.cbGender.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(252, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Стать";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Усіх записів знайдено ";
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCount.Location = new System.Drawing.Point(141, 78);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(19, 21);
            this.lbCount.TabIndex = 13;
            this.lbCount.Text = "0";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(708, 68);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(65, 34);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 489);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbGender);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnGen);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvUsers);
            this.Controls.Add(this.btnShowRegisterForm);
            this.Controls.Add(this.btnShowLoginForm);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Головна форма";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnShowLoginForm;
        private Button btnShowRegisterForm;
        private DataGridView dgvUsers;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColFullName;
        private DataGridViewTextBoxColumn ColPhone;
        private DataGridViewTextBoxColumn ColGender;
        private DataGridViewImageColumn ColImage;
        private Button btnDelete;
        private Button btnEdit;
        private Button btnGen;
        private Button btnDetails;
        private TextBox txtLastName;
        private Label label1;
        private TextBox txtName;
        private Label label2;
        private Button btnSearch;
        private ComboBox cbGender;
        private Label label4;
        private Label label3;
        private Label lbCount;
        private Button btnNext;
    }
}
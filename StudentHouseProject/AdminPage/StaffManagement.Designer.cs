﻿namespace UI.AdminPage
{
    partial class StaffManagement
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
            label1 = new Label();
            lbStaffId = new Label();
            lbStaffName = new Label();
            lbEmail = new Label();
            lbPhone = new Label();
            lbdob = new Label();
            lbSex = new Label();
            lbStatus = new Label();
            txtStaffId = new TextBox();
            txtStaffName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtStatus = new TextBox();
            txtdob = new TextBox();
            txtSex = new TextBox();
            label2 = new Label();
            cbSearch = new ComboBox();
            dgv = new DataGridView();
            btnSearch = new Button();
            btnLoad = new Button();
            btnCreate = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            txtServiceId = new TextBox();
            lbServiceId = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 4);
            label1.Name = "label1";
            label1.Size = new Size(13, 20);
            label1.TabIndex = 0;
            label1.Text = " ";
            // 
            // lbStaffId
            // 
            lbStaffId.AutoSize = true;
            lbStaffId.Location = new Point(49, 49);
            lbStaffId.Name = "lbStaffId";
            lbStaffId.Size = new Size(57, 20);
            lbStaffId.TabIndex = 1;
            lbStaffId.Text = "Staff Id";
            // 
            // lbStaffName
            // 
            lbStaffName.AutoSize = true;
            lbStaffName.Location = new Point(46, 97);
            lbStaffName.Name = "lbStaffName";
            lbStaffName.Size = new Size(84, 20);
            lbStaffName.TabIndex = 2;
            lbStaffName.Text = "Staff Name";
            lbStaffName.Click += label3_Click;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(46, 145);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(46, 20);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email";
            // 
            // lbPhone
            // 
            lbPhone.AutoSize = true;
            lbPhone.Location = new Point(373, 45);
            lbPhone.Name = "lbPhone";
            lbPhone.Size = new Size(50, 20);
            lbPhone.TabIndex = 4;
            lbPhone.Text = "Phone";
            // 
            // lbdob
            // 
            lbdob.AutoSize = true;
            lbdob.Location = new Point(373, 97);
            lbdob.Name = "lbdob";
            lbdob.Size = new Size(96, 20);
            lbdob.TabIndex = 5;
            lbdob.Text = "Date Of Birth";
            // 
            // lbSex
            // 
            lbSex.AutoSize = true;
            lbSex.Location = new Point(47, 201);
            lbSex.Name = "lbSex";
            lbSex.Size = new Size(32, 20);
            lbSex.TabIndex = 6;
            lbSex.Text = "Sex";
            // 
            // lbStatus
            // 
            lbStatus.AutoSize = true;
            lbStatus.Location = new Point(374, 200);
            lbStatus.Name = "lbStatus";
            lbStatus.Size = new Size(49, 20);
            lbStatus.TabIndex = 7;
            lbStatus.Text = "Status";
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(165, 43);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(170, 27);
            txtStaffId.TabIndex = 8;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(165, 93);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(170, 27);
            txtStaffName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(165, 139);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(170, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(491, 43);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(259, 27);
            txtPhone.TabIndex = 11;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(491, 198);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(259, 27);
            txtStatus.TabIndex = 12;
            // 
            // txtdob
            // 
            txtdob.Location = new Point(491, 97);
            txtdob.Name = "txtdob";
            txtdob.Size = new Size(259, 27);
            txtdob.TabIndex = 13;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(165, 197);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(170, 27);
            txtSex.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 265);
            label2.Name = "label2";
            label2.Size = new Size(97, 20);
            label2.TabIndex = 16;
            label2.Text = "Search Status";
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "true", "false" });
            cbSearch.Location = new Point(165, 265);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(170, 28);
            cbSearch.TabIndex = 17;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(49, 328);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(701, 172);
            dgv.TabIndex = 18;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(362, 265);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 19;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(129, 539);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 20;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(285, 539);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(94, 29);
            btnCreate.TabIndex = 21;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(431, 539);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 22;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(591, 539);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 23;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new Point(491, 139);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(259, 27);
            txtServiceId.TabIndex = 24;
            // 
            // lbServiceId
            // 
            lbServiceId.AutoSize = true;
            lbServiceId.Location = new Point(373, 146);
            lbServiceId.Name = "lbServiceId";
            lbServiceId.Size = new Size(69, 20);
            lbServiceId.TabIndex = 25;
            lbServiceId.Text = "ServiceId";
            // 
            // StaffManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(833, 607);
            Controls.Add(lbServiceId);
            Controls.Add(txtServiceId);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnCreate);
            Controls.Add(btnLoad);
            Controls.Add(btnSearch);
            Controls.Add(dgv);
            Controls.Add(cbSearch);
            Controls.Add(label2);
            Controls.Add(txtSex);
            Controls.Add(txtdob);
            Controls.Add(txtStatus);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffId);
            Controls.Add(lbStatus);
            Controls.Add(lbSex);
            Controls.Add(lbdob);
            Controls.Add(lbPhone);
            Controls.Add(lbEmail);
            Controls.Add(lbStaffName);
            Controls.Add(lbStaffId);
            Controls.Add(label1);
            Name = "StaffManagement";
            Text = "StaffManagement";
            Load += StaffManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbStaffId;
        private Label lbStaffName;
        private Label lbEmail;
        private Label lbPhone;
        private Label lbdob;
        private Label lbSex;
        private Label lbStatus;
        private TextBox txtStaffId;
        private TextBox txtStaffName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtStatus;
        private TextBox txtdob;
        private TextBox txtSex;
        private Label label2;
        private ComboBox cbSearch;
        private DataGridView dgv;
        private Button btnSearch;
        private Button btnLoad;
        private Button btnCreate;
        private Button btnDelete;
        private Button btnUpdate;
        private TextBox txtServiceId;
        private Label lbServiceId;
    }
}
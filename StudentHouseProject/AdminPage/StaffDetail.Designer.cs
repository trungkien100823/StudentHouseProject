﻿namespace UI.AdminPage
{
    partial class StaffDetail
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            txtStaffId = new TextBox();
            txtStaffName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            cbStatus = new ComboBox();
            txtPassword = new TextBox();
            dtpdob = new DateTimePicker();
            cbSex = new ComboBox();
            label9 = new Label();
            pictureBox1 = new PictureBox();
            btnSave = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 98);
            label1.Name = "label1";
            label1.Size = new Size(100, 25);
            label1.TabIndex = 0;
            label1.Text = "Staff Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(59, 149);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(59, 49);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 2;
            label3.Text = "Staff Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(59, 197);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 3;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(363, 365);
            label5.Name = "label5";
            label5.Size = new Size(115, 25);
            label5.TabIndex = 4;
            label5.Text = "Date Of Birth";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(363, 411);
            label6.Name = "label6";
            label6.Size = new Size(39, 25);
            label6.TabIndex = 5;
            label6.Text = "Sex";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(363, 267);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 6;
            label7.Text = "Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(363, 315);
            label8.Name = "label8";
            label8.Size = new Size(87, 25);
            label8.TabIndex = 7;
            label8.Text = "Password";
            // 
            // txtStaffId
            // 
            txtStaffId.Location = new Point(203, 47);
            txtStaffId.Name = "txtStaffId";
            txtStaffId.Size = new Size(313, 27);
            txtStaffId.TabIndex = 8;
            // 
            // txtStaffName
            // 
            txtStaffName.Location = new Point(203, 96);
            txtStaffName.Name = "txtStaffName";
            txtStaffName.Size = new Size(313, 27);
            txtStaffName.TabIndex = 9;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(203, 149);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(313, 27);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(203, 197);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(313, 27);
            txtPhone.TabIndex = 11;
            txtPhone.TextChanged += txtPhone_TextChanged;
            // 
            // cbStatus
            // 
            cbStatus.FormattingEnabled = true;
            cbStatus.Items.AddRange(new object[] { "true", "false" });
            cbStatus.Location = new Point(507, 267);
            cbStatus.Name = "cbStatus";
            cbStatus.Size = new Size(251, 28);
            cbStatus.TabIndex = 12;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(508, 316);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(250, 27);
            txtPassword.TabIndex = 13;
            txtPassword.Text = "1";
            // 
            // dtpdob
            // 
            dtpdob.Location = new Point(507, 363);
            dtpdob.Name = "dtpdob";
            dtpdob.Size = new Size(250, 27);
            dtpdob.TabIndex = 14;
            // 
            // cbSex
            // 
            cbSex.FormattingEnabled = true;
            cbSex.Items.AddRange(new object[] { "male", "female" });
            cbSex.Location = new Point(508, 411);
            cbSex.Name = "cbSex";
            cbSex.Size = new Size(249, 28);
            cbSex.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlText;
            label9.ImageAlign = ContentAlignment.TopLeft;
            label9.Location = new Point(542, 116);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(263, 38);
            label9.TabIndex = 18;
            label9.Text = "Staff Management";
            label9.TextAlign = ContentAlignment.MiddleLeft;
            label9.Click += label9_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = StudentHouseProject.Properties.Resources.download;
            pictureBox1.Location = new Point(59, 286);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 234);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(417, 476);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(119, 44);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(572, 476);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(119, 44);
            btnCancel.TabIndex = 21;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // StaffDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(832, 565);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(pictureBox1);
            Controls.Add(label9);
            Controls.Add(cbSex);
            Controls.Add(dtpdob);
            Controls.Add(txtPassword);
            Controls.Add(cbStatus);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtStaffName);
            Controls.Add(txtStaffId);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StaffDetail";
            Text = "Staff Details";
            Load += StaffDetail_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox txtStaffId;
        private TextBox txtStaffName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private ComboBox cbStatus;
        private TextBox txtPassword;
        private DateTimePicker dtpdob;
        private ComboBox cbSex;
        private Label label9;
        private PictureBox pictureBox1;
        private Button btnSave;
        private Button btnCancel;
    }
}
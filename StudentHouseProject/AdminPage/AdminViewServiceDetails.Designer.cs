﻿namespace StudentHouseProject.AdminAPage
{
    partial class AdminViewServiceDetails
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
            txtServicePrice = new TextBox();
            label5 = new Label();
            txtAmountOfTime = new TextBox();
            label3 = new Label();
            txtServiceName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnAdd = new Button();
            btnDeleteService = new Button();
            btnUpdateService = new Button();
            txtServiceId = new TextBox();
            label8 = new Label();
            label4 = new Label();
            dgv = new DataGridView();
            txtStatus = new TextBox();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // txtServicePrice
            // 
            txtServicePrice.Location = new Point(572, 70);
            txtServicePrice.Name = "txtServicePrice";
            txtServicePrice.Size = new Size(180, 27);
            txtServicePrice.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(476, 70);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 16;
            label5.Text = "Price (VNĐ)";
            // 
            // txtAmountOfTime
            // 
            txtAmountOfTime.Location = new Point(273, 177);
            txtAmountOfTime.Name = "txtAmountOfTime";
            txtAmountOfTime.Size = new Size(139, 27);
            txtAmountOfTime.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(37, 180);
            label3.Name = "label3";
            label3.Size = new Size(230, 20);
            label3.TabIndex = 12;
            label3.Text = "Time length to complete (Hours)";
            // 
            // txtServiceName
            // 
            txtServiceName.Location = new Point(147, 125);
            txtServiceName.Name = "txtServiceName";
            txtServiceName.Size = new Size(265, 27);
            txtServiceName.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(37, 132);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 10;
            label2.Text = "Service Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(322, 23);
            label1.Name = "label1";
            label1.Size = new Size(167, 31);
            label1.TabIndex = 9;
            label1.Text = "Service Details";
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(572, 495);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(148, 42);
            btnAdd.TabIndex = 18;
            btnAdd.Text = "Add Service";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnCreate_Click;
            // 
            // btnDeleteService
            // 
            btnDeleteService.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDeleteService.Location = new Point(418, 495);
            btnDeleteService.Name = "btnDeleteService";
            btnDeleteService.Size = new Size(148, 42);
            btnDeleteService.TabIndex = 19;
            btnDeleteService.Text = "Remove Service";
            btnDeleteService.UseVisualStyleBackColor = true;
            btnDeleteService.Click += btnDelete_Click;
            // 
            // btnUpdateService
            // 
            btnUpdateService.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateService.Location = new Point(264, 495);
            btnUpdateService.Name = "btnUpdateService";
            btnUpdateService.Size = new Size(148, 42);
            btnUpdateService.TabIndex = 20;
            btnUpdateService.Text = "Update Service";
            btnUpdateService.UseVisualStyleBackColor = true;
            btnUpdateService.Click += btnUpdate_Click;
            // 
            // txtServiceId
            // 
            txtServiceId.Location = new Point(144, 70);
            txtServiceId.Name = "txtServiceId";
            txtServiceId.Size = new Size(268, 27);
            txtServiceId.TabIndex = 26;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(37, 73);
            label8.Name = "label8";
            label8.Size = new Size(76, 20);
            label8.TabIndex = 25;
            label8.Text = "Service Id";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(476, 132);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 27;
            label4.Text = "Status";
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Location = new Point(54, 251);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.RowTemplate.Height = 29;
            dgv.Size = new Size(743, 205);
            dgv.TabIndex = 29;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(572, 125);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(180, 27);
            txtStatus.TabIndex = 30;
            // 
            // btnLoad
            // 
            btnLoad.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnLoad.Location = new Point(102, 495);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(148, 42);
            btnLoad.TabIndex = 31;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click_1;
            // 
            // AdminViewServiceDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 586);
            Controls.Add(btnLoad);
            Controls.Add(txtStatus);
            Controls.Add(dgv);
            Controls.Add(label4);
            Controls.Add(txtServiceId);
            Controls.Add(label8);
            Controls.Add(btnUpdateService);
            Controls.Add(btnDeleteService);
            Controls.Add(btnAdd);
            Controls.Add(txtServicePrice);
            Controls.Add(label5);
            Controls.Add(txtAmountOfTime);
            Controls.Add(label3);
            Controls.Add(txtServiceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminViewServiceDetails";
            Text = "Service Details";
            Load += AdminViewServiceDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtServicePrice;
        private Label label5;
        private TextBox txtAmountOfTime;
        private Label label3;
        private TextBox txtServiceName;
        private Label label2;
        private Label label1;
        private Button btnAdd;
        private Button btnDeleteService;
        private Button btnUpdateService;
        private TextBox txtServiceId;
        private Label label8;
        private Label label4;
        private DataGridView dgv;
        private TextBox txtStatus;
        private Button btnLoad;
    }
}
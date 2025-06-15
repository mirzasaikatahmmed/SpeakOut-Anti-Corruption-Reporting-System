namespace SpeakOut___Anti_Corruption_Reporting_System
{
    partial class AdminMenu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ACLOSEBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.adminLogoutBTN = new System.Windows.Forms.Button();
            this.adminUserManagementBTN = new System.Windows.Forms.Button();
            this.adminReportHistoryBTN = new System.Windows.Forms.Button();
            this.adminManageInvestigatorsBTN = new System.Windows.Forms.Button();
            this.assignReportBTN = new System.Windows.Forms.Button();
            this.adminAllReportBTN = new System.Windows.Forms.Button();
            this.adminDashboardBTN = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ACLOSEBTN);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 45);
            this.panel1.TabIndex = 0;
            // 
            // ACLOSEBTN
            // 
            this.ACLOSEBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ACLOSEBTN.FlatAppearance.BorderSize = 0;
            this.ACLOSEBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ACLOSEBTN.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACLOSEBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.ACLOSEBTN.Location = new System.Drawing.Point(710, 0);
            this.ACLOSEBTN.Name = "ACLOSEBTN";
            this.ACLOSEBTN.Size = new System.Drawing.Size(40, 40);
            this.ACLOSEBTN.TabIndex = 4;
            this.ACLOSEBTN.Text = "X";
            this.ACLOSEBTN.UseVisualStyleBackColor = true;
            this.ACLOSEBTN.Click += new System.EventHandler(this.ACLOSEBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(47, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "SpeakOut - Anti-Corruption Reporting System";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SpeakOut___Anti_Corruption_Reporting_System.Properties.Resources._24_hours_service;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.panel2.Controls.Add(this.adminLogoutBTN);
            this.panel2.Controls.Add(this.adminUserManagementBTN);
            this.panel2.Controls.Add(this.adminReportHistoryBTN);
            this.panel2.Controls.Add(this.adminManageInvestigatorsBTN);
            this.panel2.Controls.Add(this.assignReportBTN);
            this.panel2.Controls.Add(this.adminAllReportBTN);
            this.panel2.Controls.Add(this.adminDashboardBTN);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 485);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // adminLogoutBTN
            // 
            this.adminLogoutBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLogoutBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminLogoutBTN.Location = new System.Drawing.Point(12, 357);
            this.adminLogoutBTN.Name = "adminLogoutBTN";
            this.adminLogoutBTN.Size = new System.Drawing.Size(182, 37);
            this.adminLogoutBTN.TabIndex = 10;
            this.adminLogoutBTN.Text = "🚪 Logout";
            this.adminLogoutBTN.UseVisualStyleBackColor = true;
            this.adminLogoutBTN.Click += new System.EventHandler(this.adminLogoutBTN_Click);
            // 
            // adminUserManagementBTN
            // 
            this.adminUserManagementBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUserManagementBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminUserManagementBTN.Location = new System.Drawing.Point(12, 314);
            this.adminUserManagementBTN.Name = "adminUserManagementBTN";
            this.adminUserManagementBTN.Size = new System.Drawing.Size(182, 37);
            this.adminUserManagementBTN.TabIndex = 9;
            this.adminUserManagementBTN.Text = "👤 User";
            this.adminUserManagementBTN.UseVisualStyleBackColor = true;
            this.adminUserManagementBTN.Click += new System.EventHandler(this.adminUserManagementBTN_Click);
            // 
            // adminReportHistoryBTN
            // 
            this.adminReportHistoryBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminReportHistoryBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminReportHistoryBTN.Location = new System.Drawing.Point(12, 271);
            this.adminReportHistoryBTN.Name = "adminReportHistoryBTN";
            this.adminReportHistoryBTN.Size = new System.Drawing.Size(182, 37);
            this.adminReportHistoryBTN.TabIndex = 7;
            this.adminReportHistoryBTN.Text = "📈 Report History";
            this.adminReportHistoryBTN.UseVisualStyleBackColor = true;
            this.adminReportHistoryBTN.Click += new System.EventHandler(this.adminReportHistoryBTN_Click);
            // 
            // adminManageInvestigatorsBTN
            // 
            this.adminManageInvestigatorsBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminManageInvestigatorsBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminManageInvestigatorsBTN.Location = new System.Drawing.Point(12, 228);
            this.adminManageInvestigatorsBTN.Name = "adminManageInvestigatorsBTN";
            this.adminManageInvestigatorsBTN.Size = new System.Drawing.Size(182, 37);
            this.adminManageInvestigatorsBTN.TabIndex = 6;
            this.adminManageInvestigatorsBTN.Text = "👮 Investigators";
            this.adminManageInvestigatorsBTN.UseVisualStyleBackColor = true;
            this.adminManageInvestigatorsBTN.Click += new System.EventHandler(this.adminManageInvestigatorsBTN_Click);
            // 
            // assignReportBTN
            // 
            this.assignReportBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignReportBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.assignReportBTN.Location = new System.Drawing.Point(12, 185);
            this.assignReportBTN.Name = "assignReportBTN";
            this.assignReportBTN.Size = new System.Drawing.Size(182, 37);
            this.assignReportBTN.TabIndex = 5;
            this.assignReportBTN.Text = "🎯 Assign Reports";
            this.assignReportBTN.UseVisualStyleBackColor = true;
            this.assignReportBTN.Click += new System.EventHandler(this.assignReportBTN_Click);
            // 
            // adminAllReportBTN
            // 
            this.adminAllReportBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAllReportBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminAllReportBTN.Location = new System.Drawing.Point(12, 142);
            this.adminAllReportBTN.Name = "adminAllReportBTN";
            this.adminAllReportBTN.Size = new System.Drawing.Size(182, 37);
            this.adminAllReportBTN.TabIndex = 4;
            this.adminAllReportBTN.Text = "📋 View All Reports";
            this.adminAllReportBTN.UseVisualStyleBackColor = true;
            this.adminAllReportBTN.Click += new System.EventHandler(this.adminAllReportBTN_Click);
            // 
            // adminDashboardBTN
            // 
            this.adminDashboardBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminDashboardBTN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.adminDashboardBTN.Location = new System.Drawing.Point(12, 99);
            this.adminDashboardBTN.Name = "adminDashboardBTN";
            this.adminDashboardBTN.Size = new System.Drawing.Size(182, 37);
            this.adminDashboardBTN.TabIndex = 3;
            this.adminDashboardBTN.Text = "🏠 Dashboard";
            this.adminDashboardBTN.UseVisualStyleBackColor = true;
            this.adminDashboardBTN.Click += new System.EventHandler(this.adminDashboardBTN_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SpeakOut___Anti_Corruption_Reporting_System.Properties.Resources.dashboard;
            this.pictureBox2.Location = new System.Drawing.Point(67, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // adminPanel
            // 
            this.adminPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminPanel.Location = new System.Drawing.Point(200, 45);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(550, 485);
            this.adminPanel.TabIndex = 2;
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 530);
            this.ControlBox = false;
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button adminDashboardBTN;
        private System.Windows.Forms.Button ACLOSEBTN;
        private System.Windows.Forms.Button adminAllReportBTN;
        private System.Windows.Forms.Button adminLogoutBTN;
        private System.Windows.Forms.Button adminUserManagementBTN;
        private System.Windows.Forms.Button adminReportHistoryBTN;
        private System.Windows.Forms.Button adminManageInvestigatorsBTN;
        private System.Windows.Forms.Button assignReportBTN;
    }
}
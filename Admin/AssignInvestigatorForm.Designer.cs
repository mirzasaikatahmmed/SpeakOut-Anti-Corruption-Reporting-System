namespace SpeakOut___Anti_Corruption_Reporting_System.Admin
{
    partial class AssignInvestigatorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.backPictureBoxBTN = new System.Windows.Forms.PictureBox();
            this.assignSubmitBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.optionalNoteTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.investigatorsListComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.reportDescriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.locationTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.typeOfCorruptionTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dateOfSubmission = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reportTitleTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.reportID = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBoxBTN)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Assign Investigator";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.backPictureBoxBTN);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 24);
            this.panel2.TabIndex = 0;
            // 
            // backPictureBoxBTN
            // 
            this.backPictureBoxBTN.Image = global::SpeakOut___Anti_Corruption_Reporting_System.Properties.Resources.back;
            this.backPictureBoxBTN.Location = new System.Drawing.Point(491, -1);
            this.backPictureBoxBTN.Name = "backPictureBoxBTN";
            this.backPictureBoxBTN.Size = new System.Drawing.Size(25, 25);
            this.backPictureBoxBTN.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backPictureBoxBTN.TabIndex = 9;
            this.backPictureBoxBTN.TabStop = false;
            this.backPictureBoxBTN.Click += new System.EventHandler(this.backPictureBoxBTN_Click);
            // 
            // assignSubmitBTN
            // 
            this.assignSubmitBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.assignSubmitBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assignSubmitBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignSubmitBTN.ForeColor = System.Drawing.Color.White;
            this.assignSubmitBTN.Location = new System.Drawing.Point(358, 373);
            this.assignSubmitBTN.Name = "assignSubmitBTN";
            this.assignSubmitBTN.Size = new System.Drawing.Size(148, 35);
            this.assignSubmitBTN.TabIndex = 8;
            this.assignSubmitBTN.Text = "Assign";
            this.assignSubmitBTN.UseVisualStyleBackColor = false;
            this.assignSubmitBTN.Click += new System.EventHandler(this.assignSubmitBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 461);
            this.panel1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.optionalNoteTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.investigatorsListComboBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.reportDescriptionRichTextBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.locationTextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.typeOfCorruptionTextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.dateOfSubmission);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.reportTitleTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.reportID);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.assignSubmitBTN);
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 425);
            this.panel3.TabIndex = 1;
            // 
            // optionalNoteTextBox
            // 
            this.optionalNoteTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.optionalNoteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.optionalNoteTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionalNoteTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.optionalNoteTextBox.Location = new System.Drawing.Point(243, 225);
            this.optionalNoteTextBox.Name = "optionalNoteTextBox";
            this.optionalNoteTextBox.Size = new System.Drawing.Size(264, 25);
            this.optionalNoteTextBox.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label11.Location = new System.Drawing.Point(239, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(132, 19);
            this.label11.TabIndex = 24;
            this.label11.Text = "Optional Note: ";
            // 
            // investigatorsListComboBox
            // 
            this.investigatorsListComboBox.FormattingEnabled = true;
            this.investigatorsListComboBox.Items.AddRange(new object[] {
            "Bribery",
            "etc"});
            this.investigatorsListComboBox.Location = new System.Drawing.Point(243, 157);
            this.investigatorsListComboBox.Name = "investigatorsListComboBox";
            this.investigatorsListComboBox.Size = new System.Drawing.Size(261, 24);
            this.investigatorsListComboBox.TabIndex = 23;
            this.investigatorsListComboBox.SelectedIndexChanged += new System.EventHandler(this.investigatorsListComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label10.Location = new System.Drawing.Point(239, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 19);
            this.label10.TabIndex = 22;
            this.label10.Text = "Investigators: ";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // reportDescriptionRichTextBox
            // 
            this.reportDescriptionRichTextBox.Location = new System.Drawing.Point(7, 157);
            this.reportDescriptionRichTextBox.Name = "reportDescriptionRichTextBox";
            this.reportDescriptionRichTextBox.Size = new System.Drawing.Size(210, 181);
            this.reportDescriptionRichTextBox.TabIndex = 21;
            this.reportDescriptionRichTextBox.Text = "";
            this.reportDescriptionRichTextBox.TextChanged += new System.EventHandler(this.reportDescriptionRichTextBox_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label9.Location = new System.Drawing.Point(3, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 19);
            this.label9.TabIndex = 20;
            this.label9.Text = "Description: ";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // locationTextBox
            // 
            this.locationTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.locationTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.locationTextBox.Location = new System.Drawing.Point(406, 90);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(101, 25);
            this.locationTextBox.TabIndex = 19;
            this.locationTextBox.TextChanged += new System.EventHandler(this.locationTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label8.Location = new System.Drawing.Point(320, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 19);
            this.label8.TabIndex = 18;
            this.label8.Text = "Location: ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // typeOfCorruptionTextBox
            // 
            this.typeOfCorruptionTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.typeOfCorruptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.typeOfCorruptionTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfCorruptionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.typeOfCorruptionTextBox.Location = new System.Drawing.Point(167, 90);
            this.typeOfCorruptionTextBox.Name = "typeOfCorruptionTextBox";
            this.typeOfCorruptionTextBox.Size = new System.Drawing.Size(145, 25);
            this.typeOfCorruptionTextBox.TabIndex = 17;
            this.typeOfCorruptionTextBox.TextChanged += new System.EventHandler(this.typeOfCorruptionTextBox_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label7.Location = new System.Drawing.Point(3, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(168, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Type of Corruption: ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // dateOfSubmission
            // 
            this.dateOfSubmission.AutoSize = true;
            this.dateOfSubmission.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfSubmission.ForeColor = System.Drawing.Color.Black;
            this.dateOfSubmission.Location = new System.Drawing.Point(399, 13);
            this.dateOfSubmission.Name = "dateOfSubmission";
            this.dateOfSubmission.Size = new System.Drawing.Size(105, 19);
            this.dateOfSubmission.TabIndex = 15;
            this.dateOfSubmission.Text = "01/01/2000";
            this.dateOfSubmission.Click += new System.EventHandler(this.dateOfSubmission_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label6.Location = new System.Drawing.Point(266, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date Submitted: ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // reportTitleTextBox
            // 
            this.reportTitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.reportTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTitleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reportTitleTextBox.Location = new System.Drawing.Point(109, 42);
            this.reportTitleTextBox.Name = "reportTitleTextBox";
            this.reportTitleTextBox.Size = new System.Drawing.Size(397, 25);
            this.reportTitleTextBox.TabIndex = 13;
            this.reportTitleTextBox.TextChanged += new System.EventHandler(this.reportTitleTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(3, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Report Title: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // reportID
            // 
            this.reportID.AutoSize = true;
            this.reportID.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportID.ForeColor = System.Drawing.Color.Black;
            this.reportID.Location = new System.Drawing.Point(89, 13);
            this.reportID.Name = "reportID";
            this.reportID.Size = new System.Drawing.Size(29, 19);
            this.reportID.TabIndex = 11;
            this.reportID.Text = "01";
            this.reportID.Click += new System.EventHandler(this.reportID_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(3, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Report ID: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // AssignInvestigatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 485);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignInvestigatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AssignInvestigatorForm";
            this.Load += new System.EventHandler(this.AssignInvestigatorForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.backPictureBoxBTN)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox backPictureBoxBTN;
        private System.Windows.Forms.Button assignSubmitBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label reportID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox locationTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox typeOfCorruptionTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label dateOfSubmission;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox reportTitleTextBox;
        private System.Windows.Forms.RichTextBox reportDescriptionRichTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox optionalNoteTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox investigatorsListComboBox;
    }
}
namespace SpeakOut___Anti_Corruption_Reporting_System.Investigator
{
    partial class InvestigatorComments
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
            this.commentsBTN = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.reportIDtextBox = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.reportTitleTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.previousCommentsDataGridView = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.newCommentsRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousCommentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // commentsBTN
            // 
            this.commentsBTN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.commentsBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.commentsBTN.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsBTN.ForeColor = System.Drawing.Color.White;
            this.commentsBTN.Location = new System.Drawing.Point(323, 412);
            this.commentsBTN.Name = "commentsBTN";
            this.commentsBTN.Size = new System.Drawing.Size(192, 35);
            this.commentsBTN.TabIndex = 43;
            this.commentsBTN.Text = "Add Comments";
            this.commentsBTN.UseVisualStyleBackColor = false;
            this.commentsBTN.Click += new System.EventHandler(this.commentsBTN_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.reportIDtextBox);
            this.panel3.Controls.Add(this.search);
            this.panel3.Location = new System.Drawing.Point(3, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(520, 56);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Report ID: ";
            // 
            // reportIDtextBox
            // 
            this.reportIDtextBox.BackColor = System.Drawing.SystemColors.Window;
            this.reportIDtextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportIDtextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportIDtextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reportIDtextBox.Location = new System.Drawing.Point(108, 16);
            this.reportIDtextBox.Name = "reportIDtextBox";
            this.reportIDtextBox.Size = new System.Drawing.Size(297, 25);
            this.reportIDtextBox.TabIndex = 7;
            // 
            // search
            // 
            this.search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.search.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.ForeColor = System.Drawing.Color.White;
            this.search.Location = new System.Drawing.Point(411, 3);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(101, 50);
            this.search.TabIndex = 6;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = false;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(520, 24);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label1.Location = new System.Drawing.Point(3, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Investigator Comments";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.newCommentsRichTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.previousCommentsDataGridView);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.reportTitleTextBox);
            this.panel1.Controls.Add(this.commentsBTN);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 461);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label5.Location = new System.Drawing.Point(6, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 19);
            this.label5.TabIndex = 28;
            this.label5.Text = "Report Title: ";
            // 
            // reportTitleTextBox
            // 
            this.reportTitleTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.reportTitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportTitleTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportTitleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.reportTitleTextBox.Location = new System.Drawing.Point(123, 103);
            this.reportTitleTextBox.Name = "reportTitleTextBox";
            this.reportTitleTextBox.Size = new System.Drawing.Size(388, 25);
            this.reportTitleTextBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label3.Location = new System.Drawing.Point(6, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 19);
            this.label3.TabIndex = 44;
            this.label3.Text = "Previous Comments: ";
            // 
            // previousCommentsDataGridView
            // 
            this.previousCommentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previousCommentsDataGridView.Location = new System.Drawing.Point(10, 172);
            this.previousCommentsDataGridView.Name = "previousCommentsDataGridView";
            this.previousCommentsDataGridView.RowHeadersWidth = 51;
            this.previousCommentsDataGridView.RowTemplate.Height = 24;
            this.previousCommentsDataGridView.Size = new System.Drawing.Size(501, 86);
            this.previousCommentsDataGridView.TabIndex = 45;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.label4.Location = new System.Drawing.Point(6, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "New Comment:";
            // 
            // newCommentsRichTextBox
            // 
            this.newCommentsRichTextBox.Location = new System.Drawing.Point(10, 303);
            this.newCommentsRichTextBox.Name = "newCommentsRichTextBox";
            this.newCommentsRichTextBox.Size = new System.Drawing.Size(501, 92);
            this.newCommentsRichTextBox.TabIndex = 47;
            this.newCommentsRichTextBox.Text = "";
            // 
            // InvestigatorComments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 485);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InvestigatorComments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvestigatorComments";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.previousCommentsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button commentsBTN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reportIDtextBox;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox reportTitleTextBox;
        private System.Windows.Forms.RichTextBox newCommentsRichTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView previousCommentsDataGridView;
        private System.Windows.Forms.Label label3;
    }
}
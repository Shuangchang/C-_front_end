namespace ClientProgrammingProject3.Shuang
{
    partial class EmpTablePopup
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
            this.empPopupDGV = new System.Windows.Forms.DataGridView();
            this.employer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.empPopupDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // empPopupDGV
            // 
            this.empPopupDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.empPopupDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employer,
            this.degree,
            this.city,
            this.title,
            this.startDate});
            this.empPopupDGV.Location = new System.Drawing.Point(13, 31);
            this.empPopupDGV.Name = "empPopupDGV";
            this.empPopupDGV.RowTemplate.Height = 28;
            this.empPopupDGV.Size = new System.Drawing.Size(1391, 983);
            this.empPopupDGV.TabIndex = 0;
            // 
            // employer
            // 
            this.employer.HeaderText = "Employer";
            this.employer.Name = "employer";
            // 
            // degree
            // 
            this.degree.HeaderText = "Degree";
            this.degree.Name = "degree";
            // 
            // city
            // 
            this.city.HeaderText = "City";
            this.city.Name = "city";
            // 
            // title
            // 
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            // 
            // startDate
            // 
            this.startDate.HeaderText = "StartDate";
            this.startDate.Name = "startDate";
            // 
            // EmpTablePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 1059);
            this.Controls.Add(this.empPopupDGV);
            this.Name = "EmpTablePopup";
            this.Text = "EmpTable";
            this.Load += new System.EventHandler(this.EmpTablePopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.empPopupDGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView empPopupDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn employer;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn startDate;
    }
}
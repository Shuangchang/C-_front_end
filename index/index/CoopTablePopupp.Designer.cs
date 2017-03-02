namespace ClientProgrammingProject3.Shuang
{
    partial class CoopTablePopupp
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
            this.coopTableDataGridView = new System.Windows.Forms.DataGridView();
            this.employer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.degree = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.term = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.coopTableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // coopTableDataGridView
            // 
            this.coopTableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coopTableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.employer,
            this.degree,
            this.city,
            this.term});
            this.coopTableDataGridView.Location = new System.Drawing.Point(13, 30);
            this.coopTableDataGridView.Name = "coopTableDataGridView";
            this.coopTableDataGridView.RowHeadersWidth = 10;
            this.coopTableDataGridView.RowTemplate.Height = 28;
            this.coopTableDataGridView.Size = new System.Drawing.Size(1322, 976);
            this.coopTableDataGridView.TabIndex = 0;
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
            // term
            // 
            this.term.HeaderText = "Term";
            this.term.Name = "term";
            // 
            // CoopTablePopupp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1414, 1018);
            this.Controls.Add(this.coopTableDataGridView);
            this.Name = "CoopTablePopupp";
            this.Text = "CoopTable";
            this.Load += new System.EventHandler(this.CoopTablePopupp_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coopTableDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView coopTableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn employer;
        private System.Windows.Forms.DataGridViewTextBoxColumn degree;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn term;
    }
}
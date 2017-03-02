namespace ClientProgrammingProject3.Shuang
{
    partial class StudentServicesPopup
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
            this.advisingTab = new System.Windows.Forms.TabControl();
            this.academicAdvisors = new System.Windows.Forms.TabPage();
            this.aaLV = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.aaTB = new System.Windows.Forms.TextBox();
            this.aaLB = new System.Windows.Forms.Label();
            this.professonalAdvisors = new System.Windows.Forms.TabPage();
            this.paLV = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paLB = new System.Windows.Forms.Label();
            this.facultyAdvisors = new System.Windows.Forms.TabPage();
            this.faTB = new System.Windows.Forms.TextBox();
            this.faLB = new System.Windows.Forms.Label();
            this.istMinorAdvising = new System.Windows.Forms.TabPage();
            this.maLV = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.maLB = new System.Windows.Forms.Label();
            this.advisingTab.SuspendLayout();
            this.academicAdvisors.SuspendLayout();
            this.professonalAdvisors.SuspendLayout();
            this.facultyAdvisors.SuspendLayout();
            this.istMinorAdvising.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(644, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // advisingTab
            // 
            this.advisingTab.Controls.Add(this.academicAdvisors);
            this.advisingTab.Controls.Add(this.professonalAdvisors);
            this.advisingTab.Controls.Add(this.facultyAdvisors);
            this.advisingTab.Controls.Add(this.istMinorAdvising);
            this.advisingTab.Location = new System.Drawing.Point(13, 125);
            this.advisingTab.Name = "advisingTab";
            this.advisingTab.SelectedIndex = 0;
            this.advisingTab.Size = new System.Drawing.Size(1409, 823);
            this.advisingTab.TabIndex = 1;
            this.advisingTab.Selected += new System.Windows.Forms.TabControlEventHandler(this.advisingTab_Selected);
            this.advisingTab.Enter += new System.EventHandler(this.advisingTab_Enter);
            // 
            // academicAdvisors
            // 
            this.academicAdvisors.Controls.Add(this.aaLV);
            this.academicAdvisors.Controls.Add(this.aaTB);
            this.academicAdvisors.Controls.Add(this.aaLB);
            this.academicAdvisors.Location = new System.Drawing.Point(4, 29);
            this.academicAdvisors.Name = "academicAdvisors";
            this.academicAdvisors.Padding = new System.Windows.Forms.Padding(3);
            this.academicAdvisors.Size = new System.Drawing.Size(1401, 790);
            this.academicAdvisors.TabIndex = 0;
            this.academicAdvisors.Text = "Academic Advisors";
            this.academicAdvisors.UseVisualStyleBackColor = true;
            // 
            // aaLV
            // 
            this.aaLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.aaLV.Location = new System.Drawing.Point(42, 283);
            this.aaLV.Name = "aaLV";
            this.aaLV.Size = new System.Drawing.Size(1328, 97);
            this.aaLV.TabIndex = 2;
            this.aaLV.UseCompatibleStateImageBehavior = false;
            this.aaLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 150;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 500;
            // 
            // aaTB
            // 
            this.aaTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.aaTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aaTB.Location = new System.Drawing.Point(42, 105);
            this.aaTB.Multiline = true;
            this.aaTB.Name = "aaTB";
            this.aaTB.ReadOnly = true;
            this.aaTB.Size = new System.Drawing.Size(1328, 139);
            this.aaTB.TabIndex = 1;
            // 
            // aaLB
            // 
            this.aaLB.AutoSize = true;
            this.aaLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aaLB.Location = new System.Drawing.Point(38, 51);
            this.aaLB.Name = "aaLB";
            this.aaLB.Size = new System.Drawing.Size(83, 29);
            this.aaLB.TabIndex = 0;
            this.aaLB.Text = "label2";
            // 
            // professonalAdvisors
            // 
            this.professonalAdvisors.Controls.Add(this.paLV);
            this.professonalAdvisors.Controls.Add(this.paLB);
            this.professonalAdvisors.Location = new System.Drawing.Point(4, 29);
            this.professonalAdvisors.Name = "professonalAdvisors";
            this.professonalAdvisors.Padding = new System.Windows.Forms.Padding(3);
            this.professonalAdvisors.Size = new System.Drawing.Size(1401, 790);
            this.professonalAdvisors.TabIndex = 1;
            this.professonalAdvisors.Text = "Professonal Advisors";
            this.professonalAdvisors.UseVisualStyleBackColor = true;
            // 
            // paLV
            // 
            this.paLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.paLV.Location = new System.Drawing.Point(38, 129);
            this.paLV.Name = "paLV";
            this.paLV.Size = new System.Drawing.Size(1280, 167);
            this.paLV.TabIndex = 1;
            this.paLV.UseCompatibleStateImageBehavior = false;
            this.paLV.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "name";
            this.columnHeader3.Width = 150;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "department";
            this.columnHeader4.Width = 250;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "email";
            this.columnHeader5.Width = 200;
            // 
            // paLB
            // 
            this.paLB.AutoSize = true;
            this.paLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paLB.Location = new System.Drawing.Point(33, 64);
            this.paLB.Name = "paLB";
            this.paLB.Size = new System.Drawing.Size(83, 29);
            this.paLB.TabIndex = 0;
            this.paLB.Text = "label2";
            // 
            // facultyAdvisors
            // 
            this.facultyAdvisors.Controls.Add(this.faTB);
            this.facultyAdvisors.Controls.Add(this.faLB);
            this.facultyAdvisors.Location = new System.Drawing.Point(4, 29);
            this.facultyAdvisors.Name = "facultyAdvisors";
            this.facultyAdvisors.Padding = new System.Windows.Forms.Padding(3);
            this.facultyAdvisors.Size = new System.Drawing.Size(1401, 790);
            this.facultyAdvisors.TabIndex = 2;
            this.facultyAdvisors.Text = "Faculty Advisors";
            this.facultyAdvisors.UseVisualStyleBackColor = true;
            // 
            // faTB
            // 
            this.faTB.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.faTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.faTB.Location = new System.Drawing.Point(41, 109);
            this.faTB.Multiline = true;
            this.faTB.Name = "faTB";
            this.faTB.ReadOnly = true;
            this.faTB.Size = new System.Drawing.Size(1328, 235);
            this.faTB.TabIndex = 3;
            // 
            // faLB
            // 
            this.faLB.AutoSize = true;
            this.faLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.faLB.Location = new System.Drawing.Point(36, 62);
            this.faLB.Name = "faLB";
            this.faLB.Size = new System.Drawing.Size(83, 29);
            this.faLB.TabIndex = 2;
            this.faLB.Text = "label2";
            // 
            // istMinorAdvising
            // 
            this.istMinorAdvising.Controls.Add(this.maLV);
            this.istMinorAdvising.Controls.Add(this.maLB);
            this.istMinorAdvising.Location = new System.Drawing.Point(4, 29);
            this.istMinorAdvising.Name = "istMinorAdvising";
            this.istMinorAdvising.Padding = new System.Windows.Forms.Padding(3);
            this.istMinorAdvising.Size = new System.Drawing.Size(1401, 790);
            this.istMinorAdvising.TabIndex = 3;
            this.istMinorAdvising.Text = "IST Minor Advising";
            this.istMinorAdvising.UseVisualStyleBackColor = true;
            // 
            // maLV
            // 
            this.maLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.maLV.Location = new System.Drawing.Point(33, 152);
            this.maLV.Name = "maLV";
            this.maLV.Size = new System.Drawing.Size(1325, 228);
            this.maLV.TabIndex = 3;
            this.maLV.UseCompatibleStateImageBehavior = false;
            // 
            // maLB
            // 
            this.maLB.AutoSize = true;
            this.maLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maLB.Location = new System.Drawing.Point(28, 84);
            this.maLB.Name = "maLB";
            this.maLB.Size = new System.Drawing.Size(83, 29);
            this.maLB.TabIndex = 2;
            this.maLB.Text = "label2";
            // 
            // StudentServicesPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1434, 980);
            this.Controls.Add(this.advisingTab);
            this.Controls.Add(this.label1);
            this.Name = "StudentServicesPopup";
            this.Text = "Student Services";
            this.Load += new System.EventHandler(this.StudentServicesPopup_Load);
            this.advisingTab.ResumeLayout(false);
            this.academicAdvisors.ResumeLayout(false);
            this.academicAdvisors.PerformLayout();
            this.professonalAdvisors.ResumeLayout(false);
            this.professonalAdvisors.PerformLayout();
            this.facultyAdvisors.ResumeLayout(false);
            this.facultyAdvisors.PerformLayout();
            this.istMinorAdvising.ResumeLayout(false);
            this.istMinorAdvising.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl advisingTab;
        private System.Windows.Forms.TabPage academicAdvisors;
        private System.Windows.Forms.TabPage professonalAdvisors;
        private System.Windows.Forms.ListView aaLV;
        private System.Windows.Forms.TextBox aaTB;
        private System.Windows.Forms.Label aaLB;
        private System.Windows.Forms.Label paLB;
        private System.Windows.Forms.ListView paLV;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TabPage facultyAdvisors;
        private System.Windows.Forms.TextBox faTB;
        private System.Windows.Forms.Label faLB;
        private System.Windows.Forms.TabPage istMinorAdvising;
        private System.Windows.Forms.ListView maLV;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label maLB;
    }
}
namespace ClientProgrammingProject3.Shuang
{
    partial class studentAmbassadorsPopup
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
            this.saPB = new System.Windows.Forms.PictureBox();
            this.saLB = new System.Windows.Forms.Label();
            this.saLV = new System.Windows.Forms.ListView();
            this.saLinkLB = new System.Windows.Forms.LinkLabel();
            this.saTB = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.saPB)).BeginInit();
            this.SuspendLayout();
            // 
            // saPB
            // 
            this.saPB.Location = new System.Drawing.Point(19, 103);
            this.saPB.Name = "saPB";
            this.saPB.Size = new System.Drawing.Size(941, 568);
            this.saPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.saPB.TabIndex = 0;
            this.saPB.TabStop = false;
            // 
            // saLB
            // 
            this.saLB.AutoSize = true;
            this.saLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saLB.Location = new System.Drawing.Point(12, 27);
            this.saLB.Name = "saLB";
            this.saLB.Size = new System.Drawing.Size(144, 49);
            this.saLB.TabIndex = 1;
            this.saLB.Text = "label1";
            // 
            // saLV
            // 
            this.saLV.Location = new System.Drawing.Point(12, 746);
            this.saLV.Name = "saLV";
            this.saLV.Size = new System.Drawing.Size(1423, 233);
            this.saLV.TabIndex = 2;
            this.saLV.UseCompatibleStateImageBehavior = false;
            // 
            // saLinkLB
            // 
            this.saLinkLB.ActiveLinkColor = System.Drawing.Color.DarkGreen;
            this.saLinkLB.AutoSize = true;
            this.saLinkLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saLinkLB.LinkColor = System.Drawing.Color.Teal;
            this.saLinkLB.Location = new System.Drawing.Point(12, 686);
            this.saLinkLB.Name = "saLinkLB";
            this.saLinkLB.Size = new System.Drawing.Size(179, 40);
            this.saLinkLB.TabIndex = 3;
            this.saLinkLB.TabStop = true;
            this.saLinkLB.Text = "linkLabel1";
            this.saLinkLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.saLinkLB_LinkClicked);
            // 
            // saTB
            // 
            this.saTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.saTB.Location = new System.Drawing.Point(1070, 519);
            this.saTB.Multiline = true;
            this.saTB.Name = "saTB";
            this.saTB.ReadOnly = true;
            this.saTB.Size = new System.Drawing.Size(264, 152);
            this.saTB.TabIndex = 4;
            // 
            // studentAmbassadorsPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1447, 1060);
            this.Controls.Add(this.saTB);
            this.Controls.Add(this.saLinkLB);
            this.Controls.Add(this.saLV);
            this.Controls.Add(this.saLB);
            this.Controls.Add(this.saPB);
            this.Name = "studentAmbassadorsPopup";
            this.Text = "Student Ambassadors";
            this.Load += new System.EventHandler(this.studentAmbassadorsPopup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.saPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox saPB;
        private System.Windows.Forms.Label saLB;
        private System.Windows.Forms.ListView saLV;
        private System.Windows.Forms.LinkLabel saLinkLB;
        private System.Windows.Forms.TextBox saTB;
    }
}
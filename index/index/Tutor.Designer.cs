namespace ClientProgrammingProject3.Shuang
{
    partial class Tutor
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
            this.tlLB = new System.Windows.Forms.Label();
            this.tlTB = new System.Windows.Forms.TextBox();
            this.tlLinkLB = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // tlLB
            // 
            this.tlLB.AutoSize = true;
            this.tlLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlLB.Location = new System.Drawing.Point(294, 88);
            this.tlLB.Name = "tlLB";
            this.tlLB.Size = new System.Drawing.Size(144, 49);
            this.tlLB.TabIndex = 0;
            this.tlLB.Text = "label1";
            // 
            // tlTB
            // 
            this.tlTB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlTB.Location = new System.Drawing.Point(303, 193);
            this.tlTB.Multiline = true;
            this.tlTB.Name = "tlTB";
            this.tlTB.ReadOnly = true;
            this.tlTB.Size = new System.Drawing.Size(780, 102);
            this.tlTB.TabIndex = 1;
            // 
            // tlLinkLB
            // 
            this.tlLinkLB.ActiveLinkColor = System.Drawing.Color.DarkSeaGreen;
            this.tlLinkLB.AutoSize = true;
            this.tlLinkLB.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlLinkLB.LinkColor = System.Drawing.Color.Teal;
            this.tlLinkLB.Location = new System.Drawing.Point(296, 340);
            this.tlLinkLB.Name = "tlLinkLB";
            this.tlLinkLB.Size = new System.Drawing.Size(402, 40);
            this.tlLinkLB.TabIndex = 2;
            this.tlLinkLB.TabStop = true;
            this.tlLinkLB.Text = "Tutoring Lab Hours Link";
            this.tlLinkLB.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.tlLinkLB_LinkClicked);
            // 
            // Tutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 987);
            this.Controls.Add(this.tlLinkLB);
            this.Controls.Add(this.tlTB);
            this.Controls.Add(this.tlLB);
            this.Name = "Tutor";
            this.Text = "Tutors And Lab Information";
            this.Load += new System.EventHandler(this.Tutor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tlLB;
        private System.Windows.Forms.TextBox tlTB;
        private System.Windows.Forms.LinkLabel tlLinkLB;
    }
}
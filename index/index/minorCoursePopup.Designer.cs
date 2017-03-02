namespace ClientProgrammingProject3.Shuang
{
    partial class MinorCoursePopup
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
            this.idlabel = new System.Windows.Forms.Label();
            this.titleTxB = new System.Windows.Forms.TextBox();
            this.descriptTxB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // idlabel
            // 
            this.idlabel.AutoSize = true;
            this.idlabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idlabel.Location = new System.Drawing.Point(209, 124);
            this.idlabel.Name = "idlabel";
            this.idlabel.Size = new System.Drawing.Size(122, 29);
            this.idlabel.TabIndex = 0;
            this.idlabel.Text = "course id";
            // 
            // titleTxB
            // 
            this.titleTxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titleTxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleTxB.Location = new System.Drawing.Point(213, 169);
            this.titleTxB.Name = "titleTxB";
            this.titleTxB.ReadOnly = true;
            this.titleTxB.Size = new System.Drawing.Size(972, 23);
            this.titleTxB.TabIndex = 1;
            // 
            // descriptTxB
            // 
            this.descriptTxB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descriptTxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptTxB.Location = new System.Drawing.Point(214, 214);
            this.descriptTxB.Multiline = true;
            this.descriptTxB.Name = "descriptTxB";
            this.descriptTxB.ReadOnly = true;
            this.descriptTxB.Size = new System.Drawing.Size(971, 232);
            this.descriptTxB.TabIndex = 2;
            // 
            // MinorCoursePopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1418, 990);
            this.Controls.Add(this.descriptTxB);
            this.Controls.Add(this.titleTxB);
            this.Controls.Add(this.idlabel);
            this.Name = "MinorCoursePopup";
            this.Text = "Course Detail";
            this.Load += new System.EventHandler(this.MinorCoursePopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label idlabel;
        private System.Windows.Forms.TextBox titleTxB;
        private System.Windows.Forms.TextBox descriptTxB;
    }
}
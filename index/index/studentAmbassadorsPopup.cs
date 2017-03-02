using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientProgrammingProject3.Shuang
{
    public partial class studentAmbassadorsPopup : Form
    {
        private Index _index;
        private StudentAmbassadors _student;
        public studentAmbassadorsPopup(Index index, StudentAmbassadors student)
        {
            _index = index;
            _student = student;
            InitializeComponent();
        }

        private void studentAmbassadorsPopup_Load(object sender, EventArgs e)
        {
            saPB.Load(_student.ambassadorsImageSource);
            saTB.Text = _student.note;
            saLB.Text = _student.title;
            saLinkLB.Text = _student.applicationFormLink;
            saLV.Clear();
            saLV.View = View.Details;
            saLV.GridLines = true;
            saLV.Columns.Add("", 50);
            saLV.Columns.Add("", 600);
            for (var i = 0; i < _student.subSectionContent.Count; i++)
            {
                var item = new ListViewItem(new string[]
                {
                    _student.subSectionContent[i].title,
                    _student.subSectionContent[i].description
                });
                saLV.Items.Add(item);
            }
        }

        private void saLinkLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(_student.applicationFormLink.ToString());
        }
    }
}

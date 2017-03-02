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
    public partial class Tutor : Form
    {
        private Index _index;
        private TutorsAndLabInformation _tutorsAndLab;
        public Tutor(Index index,TutorsAndLabInformation tutorsAndLab)
        {
            _index = index;
            _tutorsAndLab = tutorsAndLab;
            InitializeComponent();
        }

        private void Tutor_Load(object sender, EventArgs e)
        {
            tlLB.Text = _tutorsAndLab.title;
            tlTB.Text = _tutorsAndLab.description;
            
        }

        private void tlLinkLB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.tlLinkLB.LinkVisited = true;
            System.Diagnostics.Process.Start(_tutorsAndLab.tutoringLabHoursLink.ToString());
        }
    }
}

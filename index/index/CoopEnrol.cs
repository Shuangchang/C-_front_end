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
    public partial class CoopEnrol : Form
    {
         private Index _index;
        private CoopEnrollment _cop;
        public CoopEnrol(Index index, CoopEnrollment cop)
         {
             _index = index;
             _cop = cop;
            InitializeComponent();
        }

        private void CoopEnrol_Load(object sender, EventArgs e)
        {
            label2.Text = _cop.enrollmentInformationContent[0].title;
            label3.Text = _cop.enrollmentInformationContent[1].title;
            label4.Text = _cop.enrollmentInformationContent[2].title;
            label5.Text = _cop.enrollmentInformationContent[3].title;
            textBox1.Text = _cop.enrollmentInformationContent[0].description;
            textBox2.Text = _cop.enrollmentInformationContent[1].description;
            textBox3.Text = _cop.enrollmentInformationContent[2].description;
            textBox4.Text = _cop.enrollmentInformationContent[3].description;
        }
    }
}

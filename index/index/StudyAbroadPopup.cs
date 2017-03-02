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
    public partial class StudyAbroadPopup : Form
    {
        private Index _index;
        private StudyAbroad _studyAbroad;
        public StudyAbroadPopup(Index index, StudyAbroad studyAbroad)
        {
            _index = index;
            _studyAbroad = studyAbroad;
            InitializeComponent();
        }

        private void StudyAbroadPopup_Load(object sender, EventArgs e)
        {
            label1.Text = _studyAbroad.title;
            sapTB.Text = _studyAbroad.description;
            label2.Text = _studyAbroad.places[0].nameOfPlace;
            textBox1.Text = _studyAbroad.places[0].description;
            label3.Text = _studyAbroad.places[1].nameOfPlace;
            textBox2.Text = _studyAbroad.places[1].description;
        }
    }
}

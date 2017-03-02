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
    public partial class mapPopup : Form
    {
        private Index _index;
        public mapPopup(Index indexform)
        {
            _index = indexform;
            InitializeComponent();
            webBrowser1.Navigate("http://ist.rit.edu/api/map");
        }

        private void mapPopup_Load(object sender, EventArgs e)
        {
            //System.Diagnostics.Process.Start("http://ist.rit.edu/api/map");
        }
    }
}

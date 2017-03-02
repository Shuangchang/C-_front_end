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
    public partial class ContactForm : Form
    {
        private Index _index;
        public ContactForm(Index index)
        {
            _index = index;
            InitializeComponent();
            webBrowser1.Navigate("http://ist.rit.edu/api/contactForm");
        }
    }
}

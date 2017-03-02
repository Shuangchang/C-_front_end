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
    public partial class FormsPop : Form
    {
        private Index _index;
        private Forms _forms;
        public FormsPop(Index index, Forms forms)
        {
            _index = index;
            _forms = forms;
            InitializeComponent();
        }

        private void FormsPop_Load(object sender, EventArgs e)
        {
            listView1.Clear();
            listView1.GridLines = true;
            listView1.View = View.Details;
            listView1.Columns.Add("", 100);
            listView1.Columns.Add("", 500);

            for (int i = 0; i < _forms.graduateForms.Count; i++)
            {
                var item = new ListViewItem(new String[]
                {
                     _forms.graduateForms[i].formName,
                      _forms.graduateForms[i].href   
                });
                listView1.Items.Add(item);
            }

            listView2.Clear();
            listView2.GridLines = true;
            listView2.View = View.Details;
            listView2.Columns.Add("", 100);
            listView2.Columns.Add("", 500);

            for (int i = 0; i < _forms.undergraduateForms.Count; i++)
            {
                var item = new ListViewItem(new String[]
                {
                     _forms.undergraduateForms[i].formName,
                      _forms.undergraduateForms[i].href
                });
                listView2.Items.Add(item);
            }


        }
    }
}

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
    public partial class StudentServicesPopup : Form
    {
        private Index _index;
        private StudentServices _studentServices;
        public StudentServicesPopup(Index index, StudentServices studentServices)
        {
            _index = index;
            _studentServices = studentServices;
            InitializeComponent();
        }

        private void StudentServicesPopup_Load(object sender, EventArgs e)
        {
            label1.Text = _studentServices.title;
            
        }

        private void advisingTab_Enter(object sender, EventArgs e)
        {
           aaLB.Text = _studentServices.academicAdvisors.title;
            aaTB.Text = _studentServices.academicAdvisors.description;
            
            aaLV.GridLines = true;
            aaLV.View = View.Details;
            var item = new ListViewItem(new String[]
            {
                _studentServices.academicAdvisors.faq.title,
                _studentServices.academicAdvisors.faq.contentHref
            });
            aaLV.Items.Add(item);
        }

        private void advisingTab_Selected(object sender, TabControlEventArgs e)
        {
           
            if (advisingTab.SelectedTab == professonalAdvisors)
            {
                paLB.Text = _studentServices.professonalAdvisors.title;
                paLV.Clear();
                paLV.Columns.Add("", 150);
                paLV.Columns.Add("", 250);
                paLV.Columns.Add("", 200);
                paLV.GridLines = true;
                paLV.View = View.Details;               
                for (var i = 0; i < _studentServices.professonalAdvisors.advisorInformation.Count; i++)
                {
                    var item = new ListViewItem(new String[]
                    {
                        _studentServices.professonalAdvisors.advisorInformation[i].name,
                        _studentServices.professonalAdvisors.advisorInformation[i].department,
                        _studentServices.professonalAdvisors.advisorInformation[i].email,
                    });
                    paLV.Items.Add(item);
                }
            }
            if(advisingTab.SelectedTab == facultyAdvisors)
            {
                faLB.Text = _studentServices.facultyAdvisors.title;
                faTB.Text = _studentServices.facultyAdvisors.description;
            }
            if (advisingTab.SelectedTab == istMinorAdvising)
            {
                
                maLB.Text = _studentServices.istMinorAdvising.title;
                maLV.Clear();
                maLV.View = View.Details;              
                maLV.Columns.Add("", 150);
                maLV.Columns.Add("", 300);
                maLV.Columns.Add("", 200);
                for (var i = 0; i < _studentServices.istMinorAdvising.minorAdvisorInformation.Count; i++)
                {
                    var item = new ListViewItem(new String[]
                    {
                        _studentServices.istMinorAdvising.minorAdvisorInformation[i].advisor,
                        _studentServices.istMinorAdvising.minorAdvisorInformation[i].title,
                        _studentServices.istMinorAdvising.minorAdvisorInformation[i].email
                    });
                    maLV.Items.Add(item);
                }
            }
        }
    }
}

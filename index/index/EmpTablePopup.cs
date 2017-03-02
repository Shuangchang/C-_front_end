using RestUtil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ClientProgrammingProject3.Shuang
{
    public partial class EmpTablePopup : Form
    {
        private readonly Rest _rest = new Rest("http://ist.rit.edu/api");
        Index _index;
        private Employments _employments;

        public EmpTablePopup(Index indexform)
        {
            this._index = indexform;
            InitializeComponent();
        }

        private void EmpTablePopup_Load(object sender, EventArgs e)
        {
            var cooptablestring = _rest.getRestData("/employment");
            _employments = JToken.Parse(cooptablestring).ToObject<Employments>();
            empPopupDGV.Columns[0].Width = 300;
            empPopupDGV.Columns[1].Width = 200;
            empPopupDGV.Columns[2].Width = 200;
            empPopupDGV.Columns[3].Width = 100;
            for (int i = 0; i < _employments.EmploymentTable.ProfessionalEmploymentInformation.Count; i++)
            {
                empPopupDGV.Rows.Add();

                empPopupDGV.Rows[i].Cells[0].Value =
                    _employments.EmploymentTable.ProfessionalEmploymentInformation[i].Employer;
                empPopupDGV.Rows[i].Cells[1].Value = _employments.EmploymentTable.ProfessionalEmploymentInformation[i].Degree;
                empPopupDGV.Rows[i].Cells[2].Value = _employments.EmploymentTable.ProfessionalEmploymentInformation[i].City;
                empPopupDGV.Rows[i].Cells[3].Value = _employments.EmploymentTable.ProfessionalEmploymentInformation[i].Title;
                empPopupDGV.Rows[i].Cells[3].Value = _employments.EmploymentTable.ProfessionalEmploymentInformation[i].StartDate;
            }
        }
    }
}

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
    public partial class CoopTablePopupp : Form
    {
        private readonly Rest _rest = new Rest("http://ist.rit.edu/api");
        Index _index;
        private Employments _employments;
      
        public CoopTablePopupp(Index indexform)
        {
            this._index = indexform;
            InitializeComponent();
        }

        private void CoopTablePopupp_Load(object sender, EventArgs e)
        {
            var cooptablestring = _rest.getRestData("/employment");
            _employments = JToken.Parse(cooptablestring).ToObject<Employments>();
            coopTableDataGridView.Columns[0].Width = 300;
            coopTableDataGridView.Columns[1].Width = 200;
            coopTableDataGridView.Columns[2].Width = 200;
            coopTableDataGridView.Columns[3].Width = 100;
            for (int i = 0; i < _employments.CoopTable.CoopInformation.Count; i++)
            {
                coopTableDataGridView.Rows.Add();
                
                coopTableDataGridView.Rows[i].Cells[0].Value = _employments.CoopTable.CoopInformation[i].Employer;
                coopTableDataGridView.Rows[i].Cells[1].Value = _employments.CoopTable.CoopInformation[i].Degree;
                coopTableDataGridView.Rows[i].Cells[2].Value = _employments.CoopTable.CoopInformation[i].City;
                coopTableDataGridView.Rows[i].Cells[3].Value = _employments.CoopTable.CoopInformation[i].Term;
            }
        }
    }
}

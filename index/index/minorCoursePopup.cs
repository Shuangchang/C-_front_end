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
    
    public partial class MinorCoursePopup : Form
    {
        Index _index;

        public MinorCoursePopup(Index indexform, Courses course)
        {
            this._index = indexform;
            InitializeComponent();
            titleTxB.Text = course.Title;
            descriptTxB.Text = course.Description;
            idlabel.Text = course.CourseId;
        }

        private void MinorCoursePopup_Load(object sender, EventArgs e)
        {
            
        }
    }

}

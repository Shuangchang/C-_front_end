using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using BrightIdeasSoftware;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestUtil;

namespace ClientProgrammingProject3.Shuang
{
    public partial class Index : Form
    {
        private readonly Rest _rest = new Rest("http://ist.rit.edu/api");
        public Index()
        {
            InitializeComponent();
            PopulateAbout();
        }

        private Footer _footer;
        private void PopulateAbout()
        {
            //get about information
            var stringAbout = _rest.getRestData("/about");
            
            //parse string data to json object
            var about = JToken.Parse(stringAbout).ToObject<About>();

            //displaying about information on the index page
            aboutText.Text = about.Description;
            aboutTitle.Text = about.Title;
            quote.Text = about.Quote;
            quoteLB2.Text = about.QuoteAuthor;
            
            //footer
            var footerString = _rest.getRestData("/footer");
            _footer = JToken.Parse(footerString).ToObject<Footer>();
            linkLabel1.Text = _footer.quickLinks[0].title;
            linkLabel2.Text = _footer.quickLinks[1].title;
            linkLabel3.Text = _footer.quickLinks[2].title;
            linkLabel4.Text = _footer.quickLinks[3].title;
        }

        private void degreeTab_Enter(object sender, EventArgs e)
        {
            var stringDegree = _rest.getRestData("/degrees/undergraduate");
            var undergradutes = JToken.Parse(stringDegree).ToObject<Undergraduates>();
            foreach (var item in undergradutes.Undergraduate)
            {

                undergraduatelistview.TryAddItem(item.Title);
                undergraduatelistview.TryAddItem(item.Description);
                undergraduatelistview.TryAddItem("\n");
            } 
        }

        private void degreeTabs_Selected(object sender, TabControlEventArgs e)
        {
            graduatelistview.Items.Clear();
            if (degreeTabs.SelectedTab == Graduate)
            {
                var stringDegree = _rest.getRestData("/degrees/graduate");
                var gradutes = JToken.Parse(stringDegree).ToObject<Graduates>();
                foreach (var item in gradutes.Graduate)
                {
                    // Add Either Titile or Degree if it exists
                    if (!graduatelistview.TryAddItem(item.Title))
                    {
                        // Add degreeName if exist
                        graduatelistview.TryAddItem(item.DegreeName);
                    }

                    // Add description if exist
                    graduatelistview.TryAddItem(item.Description);
                    // Add concentrations if exist
                    graduatelistview.TryAddItems(item.Concentrations);
                    // Add Certificate if exist
                    graduatelistview.TryAddItems(item.AvailableCertificates);
                    graduatelistview.TryAddItem("\n");
                }
            }
        }

        private People _people;
        private Research _research;
        private Resources _resources;
        private void mainCtrl_Selected(object sender, TabControlEventArgs e)
        {
            
            if (mainCtrl.SelectedTab == minorTab)
            {
               
                var minorString = _rest.getRestData("/minors");
                var minors = JToken.Parse(minorString).ToObject<Minors>();

                objectListView1.RowHeight = 256;
                objectListView1.CellEditActivation = ObjectListView.CellEditActivateMode.SingleClick;

                var myUiObjects = minors.UgMinors.Select(ugMinor => new MyUiObject(ugMinor)).ToList();            
                objectListView1.SetObjects(myUiObjects);
            }
            if (mainCtrl.SelectedTab == employmentTab)
            {
  
                var emloymentString = _rest.getRestData("/employment");
                var employments = JToken.Parse(emloymentString).ToObject<Employments>();

                empIntroTextbox.Text = employments.Introduction.Title;
                degreeStatTitle.Text = employments.DegreeStatistics.Title;

                empTB.Text = employments.Introduction.Content[0].Description;
                coopTB.Text = employments.Introduction.Content[1].Description;

                empLV.Clear();
                empLV.GridLines = true;
                foreach (var x in employments.Employers.EmployerNames)
                {
                    empLV.Items.Add(x.ToString());
                }

                coopLV.Clear();
                coopLV.GridLines = true;
                foreach (var x in employments.Careers.CareerNames)
                {
                    coopLV.Items.Add(x.ToString());
                }

                degreeStatListView.Clear();
                degreeStatListView.GridLines = true;
                degreeStatListView.View = View.Details;
                degreeStatListView.Columns.Add("", 100);
                degreeStatListView.Columns.Add("", 450);

                for (int i = 0; i < employments.DegreeStatistics.Statistics.Count; i++)
                {
                    var item = new ListViewItem(new String[]
                    {
                        employments.DegreeStatistics.Statistics[i].Value,
                        employments.DegreeStatistics.Statistics[i].Description
                    });
                    degreeStatListView.Items.Add(item);
                }

            }
            if (mainCtrl.SelectedTab == peopleTab)
            {
                var peopleString = _rest.getRestData("/people");
                _people = JToken.Parse(peopleString).ToObject<People>();
                pplSubtitleLB.Text = _people.SubTitle;
                peopleDGV.Columns[0].Width = 200;
                peopleDGV.Columns[1].Width = 200;
                for (var i = 0; i < _people.Faculty.Count; i++)
                {
                    peopleDGV.Rows.Add();
                    peopleDGV.Rows[i].Cells[0].Value = _people.Faculty[i].Name;
                    if (i < _people.Staff.Count)
                    {
                        peopleDGV.Rows[i].Cells[1].Value = _people.Staff[i].Name;
                    }
                }
            }
            if (mainCtrl.SelectedTab == researchTab)
            {
                var researchString = _rest.getRestData("/research");
                _research = JToken.Parse(researchString).ToObject<Research>();
                researchDGV.Columns[0].Width = 150;
                for (var i = 0; i < _research.byInterestArea.Count; i++)
                {
                    researchDGV.Rows.Add();
                    researchDGV.Rows[i].Cells[0].Value = _research.byInterestArea[i].areaName;
                }
            }
            if (mainCtrl.SelectedTab == resourceTab)
            {
                var resourceString = _rest.getRestData("/resources");
                _resources = JToken.Parse(resourceString).ToObject<Resources>();

            }
        }

        private void coopTableBtn_Click(object sender, EventArgs e)
        {
            CoopTablePopupp coopTablePopupp = new CoopTablePopupp(this);
            coopTablePopupp.Show();
        }


        private void objectListView1_CellEditStarting(object sender, CellEditEventArgs e)
        {
            if (e.Column.Text != "Courses")
                return;

            //Person personBeingEdited = (Person)e.RowObject;
            var cb = new ComboBox
            {
                Bounds = e.CellBounds,
                Font = ((ObjectListView) sender).Font,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            cb.Items.AddRange(e.Value.ToString().Split('\n').ToArray());
            cb.SelectedIndex = 0;

            cb.SelectedIndexChanged += delegate (object o, EventArgs args)
            {
                // cb.SelectedText;
                //Debug.WriteLine("CB = " + cb.SelectedItem.ToString());
                var stringCourse = _rest.getRestData("/course/courseID="+cb.SelectedItem.ToString());
                Courses courses = JToken.Parse(stringCourse).ToObject<Courses>();
               
                MinorCoursePopup minorCoursePopup = new MinorCoursePopup(this, courses);
                minorCoursePopup.Show();
            };
            e.Control = cb;
        }

        private void objectListView1_CellEditFinishing(object sender, CellEditEventArgs e)
        {
            if (e.Column.Text != "Courses")
                return;

            ((ObjectListView)sender).RefreshItem(e.ListViewItem);         
            e.Cancel = true;
        }

        private void peopleDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView) sender;
            if (dataGridView != null)
            {
                var selectedCell = dataGridView.SelectedCells[0];
                if (selectedCell != null)
                {
                    //need to refine try catch
                    var selectedString = selectedCell.Value.ToString();

                    testTB.Text = selectedString;

                    GetSingleInstance(selectedString);
                }
            }
    }

        //1 selected
        private void GetSingleInstance(string name)
        {
            //lamba
            
            var result = _people.Faculty.Find(x => x.Name == name);
          
            if (result != null)
            {
                pplPB.Load(result.ImagePath);
                taglineTB.Text = result.Tagline;
                titleTB.Text = result.Title;
                interestAreaTB.Text = result.InterestArea;
                OfficeTB.Text = result.Office;
                webSiteTB.Text = result.Website;
                phoneTB.Text = result.Phone;
                emailTB.Text = result.Email;
                twitterTB.Text = result.Twitter;
                facebookTB.Text = result.Facebook;
            }
            else
            {
                var result2 = _people.Staff.Find(x => x.Name == name);
                pplPB.Load(result2.ImagePath);
                taglineTB.Text = result2.Tagline;
                titleTB.Text = result2.Title;
                interestAreaTB.Text = result2.InterestArea;
                OfficeTB.Text = result2.Office;
                webSiteTB.Text = result2.Website;
                phoneTB.Text = result2.Phone;
                emailTB.Text = result2.Email;
                twitterTB.Text = result2.Twitter;
                facebookTB.Text = result2.Facebook;
            }
        }

        private void employmentTab_Enter(object sender, EventArgs e)
        {

        }

        private void empBT_Click(object sender, EventArgs e)
        {
            EmpTablePopup empTablePopup = new EmpTablePopup(this);
            empTablePopup.Show();
        }

        private void peopleDGV_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void map_Click(object sender, EventArgs e)
        {
            mapPopup mapPopup = new mapPopup(this);
            mapPopup.Show();
        }

        private void quote_TextChanged(object sender, EventArgs e)
        {

        }

        private void researchDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            var dataGridView = (DataGridView)sender;
            if (dataGridView != null)
            {
                var selectedCell = dataGridView.SelectedCells[0];
                if (selectedCell != null)
                {
                    //need to refine try catch
                    var selectedString = selectedCell.Value.ToString();

                    areaLB.Text = selectedString;

                    GetSingleArea(selectedString);
                }
            }
        }
        private void GetSingleArea(string name)
        {
            //lamba

            var result = _research.byInterestArea.Find(x => x.areaName == name);

            if (result != null)
            {
                byAreaDGV.Rows.Clear();

                for (var i = 0; i < result.citations.Count; i++)
                {
                    byAreaDGV.Rows.Add();
                    byAreaDGV.Rows[i].Cells[0].Value = result.citations[i];
                }
            }

        }

        private void researchByTab_Selected(object sender, TabControlEventArgs e)
        {
            byfacDGV.Rows.Clear();
            if (researchByTab.SelectedTab == byFaculty)
            {
                byfacDGV.Columns[0].Width = 150;
                for (var i = 0; i < _research.byFaculty.Count; i++)
                {
                    byfacDGV.Rows.Add();
                    byfacDGV.Rows[i].Cells[0].Value = _research.byFaculty[i].facultyName;
                }
            }
        }

        private void byfacDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dataGridView = (DataGridView)sender;
            if (dataGridView != null)
            {
                var selectedCell = dataGridView.SelectedCells[0];
                if (selectedCell != null)
                {
                    //need to refine try catch
                    var selectedString = selectedCell.Value.ToString();

                    facLB.Text = selectedString;

                    GetSingleFacArea(selectedString);
                }
            }
        }
        private void GetSingleFacArea(string name)
        {
          
            var result = _research.byFaculty.Find(x => x.facultyName == name);

            if (result != null)
            {
                byfacAreDGV.Rows.Clear();
                for (var i = 0; i <result.citations.Count; i++)
                {
                    byfacAreDGV.Rows.Add();
                    byfacAreDGV.Rows[i].Cells[0].Value =result.citations[i];
                }
            }

        }

        private void coopEnroll_Click(object sender, EventArgs e)
        {
            CoopEnrollment reso = _resources.coopEnrollment;
            CoopEnrol coopEnrol = new CoopEnrol(this, reso);
            coopEnrol.Show();
        }

        private void forms_Click(object sender, EventArgs e)
        {
            Forms forms = _resources.Forms;
            FormsPop formsPop = new FormsPop(this, forms);
            formsPop.Show();
        }

        private void tutorLab_Click(object sender, EventArgs e)
        {
            TutorsAndLabInformation ta = _resources.tutorsAndLabInformation;
            Tutor tutor = new Tutor(this,ta);
            tutor.Show();
        }

        private void courseEnroll_Click(object sender, EventArgs e)
        {
            
            
        }

        private void studentAdvi_Click(object sender, EventArgs e)
        {
          StudentServices studentServices = _resources.studentServices;
          StudentServicesPopup studentServicesPopup = new StudentServicesPopup(this, studentServices);
       
          studentServicesPopup.Show();
        }

        private void studAmb_Click(object sender, EventArgs e)
        {
            StudentAmbassadors student = _resources.studentAmbassadors;
            studentAmbassadorsPopup sa = new studentAmbassadorsPopup(this,student);
            sa.Show();
        }

        private void studyAborad_Click(object sender, EventArgs e)
        {
            StudyAbroad studyAbroad = _resources.studyAbroad;
            StudyAbroadPopup studyAbroadPopup = new StudyAbroadPopup(this,studyAbroad);
            studyAbroadPopup.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start(_footer.quickLinks[0].href);
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel2.LinkVisited = true;
            System.Diagnostics.Process.Start(_footer.quickLinks[1].href);
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel3.LinkVisited = true;
            System.Diagnostics.Process.Start(_footer.quickLinks[2].href);
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel4.LinkVisited = true;
            System.Diagnostics.Process.Start(_footer.quickLinks[3].href);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ContactForm contactForm = new ContactForm(this);
            contactForm.Show();

        }
    }

}

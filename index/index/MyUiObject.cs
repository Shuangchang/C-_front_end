using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientProgrammingProject3.Shuang
{
    public class MyUiObject
    {
        private readonly UgMinor _minor;

        public MyUiObject(UgMinor minor)
        {
            _minor = minor;
            Title = _minor.Title;
            Description = _minor.Description;
            Note = _minor.Note;

            Courses = string.Join("\n", _minor.Courses);
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Note { get; set; }

        public string Courses { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientProgrammingProject3.Shuang
{

    public class MyFaculties
    {
        private readonly Faculty _faculty;

        public MyFaculties(Faculty faculty)
        {
            _faculty = faculty;
            Username = faculty.Username;
            Name = faculty.Name;
            Tagline = faculty.Tagline;
            ImagePath = faculty.ImagePath;

        }
        public string Username { get; set; }
        public string Name { get; set; }
        public string Tagline { get; set; }
        public string ImagePath { get; set; }

    }
}

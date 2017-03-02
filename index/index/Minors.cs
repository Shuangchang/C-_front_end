using System.Collections.Generic;

namespace ClientProgrammingProject3.Shuang
{
    class Minors
    {

       public List<UgMinor> UgMinors { get; set; }
    }

    public class UgMinor
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Courses { get; set; }
        public string Note { get; set; }
    }

   
}

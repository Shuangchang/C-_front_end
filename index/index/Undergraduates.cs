using System.Collections.Generic;

namespace ClientProgrammingProject3.Shuang
{
   class Undergraduates
    {
        public List<Undergraduate> Undergraduate { get; set; }
    }
    public class Undergraduate
    {
        public string DegreeName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Concentrations { get; set; }
    }

}

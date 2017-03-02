using System.Collections.Generic;

namespace ClientProgrammingProject3.Shuang
{
    class Graduates
    {
        public List<Graduate> Graduate { get; set; }
    }
    public class Graduate
    {
        public string DegreeName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public List<string> Concentrations { get; set; }
        public List<string> AvailableCertificates { get; set; }
    }
}

using WebApplication3.Areas.Identity.Data;

namespace WebApplication3.Models
{
    public enum Class
    {
        ART9, ART10, APA11, APD11, APA12, APD12, PHO12, APA13, APD13, PHO13
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string AC { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Class Class { get; set; }

    }
}

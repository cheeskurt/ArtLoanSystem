using WebApplication3.Areas.Identity.Data;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public enum Class
    {
        [Display(Name = "9ART")]
        NINEART,
        [Display(Name = "10ART")]
        TENART,
        [Display(Name = "11APA")]
        ELEVENAPA,
        [Display(Name = "11APD")]
        ELEVENAPD,
        [Display(Name = "12APA")]
        TWELVEAPA,
        [Display(Name = "12APD")]
        TWELVEAPD,
        [Display(Name = "12PHO")]
        TWELVEPHO,
        [Display(Name = "13APA")]
        THIRTEENAPA,
        [Display(Name = "13APD")]
        THIRTEENAPD,
        [Display(Name = "13PHO")]
        THIRTEENPHO
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

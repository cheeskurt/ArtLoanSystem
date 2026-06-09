using System.ComponentModel.DataAnnotations;
using WebApplication3.Areas.Identity.Data;

namespace WebApplication3.Models
{
    public class Subject
    {
        [Key]
        public int SubjectID { get; set; }
        public string SubjectName { get; set; }

        public ICollection<User>? Users { get; set; }
        public ICollection<Issue>? Issues { get; set; }
    }
}

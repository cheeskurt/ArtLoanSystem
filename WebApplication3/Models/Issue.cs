
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Issue
    {
        public int IssueID { get; set; }     
        public DateTime DateIssued { get; set; }
        public DateTime DateReturned { get; set; }
        public DateTime DateDue { get; set; }

        public ICollection<ItemIssue>? ItemIssues { get; set; }
    }
}

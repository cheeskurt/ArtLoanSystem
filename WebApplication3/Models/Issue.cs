
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public enum Status
    {
         
    }
    public class Issue
    {
        public int IssueID { get; set; }     
        public Status Status { get; set; }
        public DateTime DateIssued { get; set; }
        public DateTime DateReturned { get; set; }
        public DateTime DateDue { get; set; }

        public ICollection<ItemIssued>? ItemIssueds { get; set; }
    }
}

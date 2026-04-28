using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public enum Category
    { 
        Storage, Tablets, Paints, Photography
    }
    public enum Condition
    {
        Excellent, Good, Poor, Damaged
    }

    public class ItemIssue
    {
        public int ItemIssueID { get; set; }
        public int IssueID { get; set; }
        public int ItemID { get; set; }
        public Category Category { get; set; }
        public Condition Condition { get; set; }

        [MaxLength(150), MinLength(1)]
        public string Note { get; set; }
        

    }
}

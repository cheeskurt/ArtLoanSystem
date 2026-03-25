using System.ComponentModel;

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
        public string Note { get; set; }

    }
}

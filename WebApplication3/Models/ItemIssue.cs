using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    // An enum declaring the category of an item.
    public enum Category
    { 
        Storage, Tablets, Paints, Photography
    }

    // An enum declaring the condition of a returned item.
    public enum Condition
    {
        Excellent, Good, Poor, Damaged
    }

    public class ItemIssue
    {
        [Key]
        public int ItemIssueID { get; set; }

        [Required]
        [ForeignKey("Issue")]
        public int IssueID { get; set; }

        [Required] 
        [ForeignKey("Item")]
        public int ItemID { get; set; }

        [Required]
        public Category Category { get; set; }

        [Required]
        public Condition Condition { get; set; }


        // A maximum length of 150 is configured for an optional note
        [Required]
        [MaxLength(150)]
        public string Note { get; set; }
        

    }
}

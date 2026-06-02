using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Item
    {
        [Key]
        public int ItemID { get; set; }

        [Display(Name = "Item Name")]
        public string TheItem { get; set; }

        // Adjust to display proper imagery
        public string ImageURL { get; set; } 

        public ICollection<Stock>? Stocks { get; set; }
        public ICollection<ItemIssue>? ItemIssues { get; set; }
    }
}

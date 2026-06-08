using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Stock
    {
        [Key]
        public int StockID {  get; set; } 

        [Required]
        [ForeignKey("Item")]
        public int ItemID { get; set; }

        [Display(Name = "Stock #")]
        public string StockTag {  get; set; }

        public Item Items { get; set; }
    }
}

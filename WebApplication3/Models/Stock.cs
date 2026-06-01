using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication3.Models
{
    public class Stock
    {
        [Key]
        public int StockID {  get; set; }
        public int ItemID { get; set; }

    }
}

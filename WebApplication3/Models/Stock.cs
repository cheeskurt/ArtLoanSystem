namespace WebApplication3.Models
{
    public class Stock
    {
        public int StockID {  get; set; }
        public string TheStock {  get; set; }

        public bool Available { get; set; }

        public ICollection<>? Items { get; set; }
    }
}

namespace WebApplication3.Models
{
    public class Item
    {
        public int ItemID { get; set; }
        public string TheItem { get; set; }
        public string ImageURL { get; set; }

        public ICollection<Stock>? Stocks { get; set; }
        public ICollection<ItemIssue>? ItemIssues { get; set; }
    }
}

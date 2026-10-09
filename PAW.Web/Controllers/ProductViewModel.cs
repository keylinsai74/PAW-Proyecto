namespace PAW.Web.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? Description { get; set; }
        public decimal? Rating { get; set; }
        public DateTime? LastModified { get; set; }
    }
}
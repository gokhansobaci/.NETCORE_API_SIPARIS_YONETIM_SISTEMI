namespace SignalR.DTOLayer.ProductDto
{
    public class UpdateProductDto
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public bool ProductStatus { get; set; }
		public int CategoryID { get; set; }
	}
}

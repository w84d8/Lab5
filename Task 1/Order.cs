class Order
{
    public List<Product> Products { get; set; }
    public Dictionary<Product, int> ProductQuantities { get; set; }
    public decimal TotalCost => Products.Sum(product => product.Price * ProductQuantities[product]);
    public string Status { get; set; }

    public Order()
    {
        Products = new List<Product>();
        ProductQuantities = new Dictionary<Product, int>();
        Status = "Pending";
    }
}
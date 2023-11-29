class Store : ISearchable
{
    public List<User> Users { get; set; }
    public List<Product> Products { get; set; }
    public List<Order> Orders { get; set; }

    public Store()
    {
        Users = new List<User>();
        Products = new List<Product>();
        Orders = new List<Order>();
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public void RegisterUser(User user)
    {
        Users.Add(user);
    }

    public void PlaceOrder(User user, Order order)
    {
        user.PurchaseHistory.Add(order);
        Orders.Add(order);
    }

    public List<Product> SearchByCriteria(Func<Product, bool> criteria)
    {
        return Products.Where(criteria).ToList();
    }
}
using static System.Formats.Asn1.AsnWriter;

class Program
{
    static void Main()
    {
        Store store = new Store();

        store.AddProduct(new Product("Laptop", 1000, "Powerful laptop", "Electronics", 5));
        store.AddProduct(new Product("Book", 20, "Interesting book", "Books", 4));
        store.AddProduct(new Product("Headphones", 150, "High-quality headphones", "Electronics", 4));

        User user = new User("john_doe", "password123");
        store.RegisterUser(user);

        Order order = new Order();
        order.Products.Add(store.Products[0]);
        order.ProductQuantities[store.Products[0]] = 2;

        store.PlaceOrder(user, order);

        List<Product> electronics = store.SearchByCriteria(product => product.Category == "Electronics");
        Console.WriteLine("Electronics:");
        foreach (var product in electronics)
        {
            Console.WriteLine($"{product.Name} - {product.Price}");
        }
    }
}

//var products = new List<Product>
//{
//    new() {Title = "Smartphone 1", Category = "Electronics", Price = 150.00m},
//    new() {Title = "Smartphone 2", Category = "Electronics", Price = 150.00m},
//    new() {Title = "T-Shirt", Category = "Clothing", Price = 50.00m},
//    new() {Title = "Laptop", Category = "Electronics", Price = 200.00m},
//    new() {Title = "Jeans 1", Category = "Clothing", Price = 75.00m},
//    new() {Title = "Jeans 2", Category = "Clothing", Price = 75.00m},
//};

//// группировка по двум атрибутам (отдельная коллекция c двумя параметрами)
//var result = products.GroupBy(x => new { x.Category, x.Price });

//foreach (var categories in result)
//{
//    Console.WriteLine(categories.Key);
//    foreach(var product in categories)
//    {
//        Console.WriteLine($" {product}");
//    }
//}


//public class Product
//{
//    public string Title { get; set; }
//    public string Category { get; set; }
//    public decimal Price { get; set; }
//    public override string ToString()
//    {
//        return $"Title: {Title}, Price:{Price}";
//    }
//}
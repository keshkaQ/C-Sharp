
//var products = new List<Product>
//{
//    new() {Title = "Smartphone", Category = "Electronics", Price = 150.00m},
//    new() {Title = "T-Shirt", Category = "Clothing", Price = 50.00m},
//    new() {Title = "Laptop", Category = "Electronics", Price = 200.00m},
//    new() {Title = "Jeans", Category = "Clothing", Price = 75.00m},
//};

//// группировка среднее значение каждой категории
//var result = products.GroupBy(x => x.Category).ToDictionary(group=>group.Key,group =>group.Average(x=>x.Price));

//foreach (var categories in result)
//{
//    Console.WriteLine(categories.Key);
//    Console.WriteLine(result[categories.Key]);
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
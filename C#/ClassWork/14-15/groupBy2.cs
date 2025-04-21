
//internal class Program
//{
//    private static void Main(string[] args)
//    {
//        var product = new List<Product>();
//        // группировка по категории
//        var group = product.GroupBy(x => x.Category).ToList();
//        // количество продуктов, которые соответствуют этой категории
//        var group2 = product.GroupBy(x => x.Category).Count();
//        // количество продуктов, стоимостью больше 200
//        var price = product.GroupBy(x => x.Price >200).Count();


//        foreach (var groupProduct in group)
//        {
//            Console.WriteLine(groupProduct.Key);
//            foreach (var prod in groupProduct)
//            {
//                Console.WriteLine($"   {prod}");
//            }
//        }
//    }
//}

//class Product
//{
//    public string Title { get; set; }
//    public string Category { get; set; }
//    public int Price { get; set; }
//    public override string ToString()
//    {
//        return $"Title: {Title}, Price: {Price}";
//    }
//}
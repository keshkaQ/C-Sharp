//var product = new List<Product>
//{
//    new() {Title = "Smartphone", CategoryID = 1, Amount = 150.00m},
//    new() {Title = "T-Shirt", CategoryID = 2, Amount = 50.00m},
//    new() {Title = "Laptop", CategoryID = 1, Amount = 200.00m},
//    new() {Title = "Jeans", CategoryID = 2, Amount = 75.00m},
//};

//var categories = new List<Category>
//{
//    new Category{Id = 1, Name = "Electronics"},
//    new Category{Id = 2, Name = "Clothing"},
//};

//string privet = nameof(privet);
//Console.WriteLine(privet);

//var join = product.Join(categories,
//    product => product.CategoryID,
//    categories => categories.Id,
//    (product, categories) => new
//    {
//        Title = product.Title,
//        Amount = product.Amount,
//        TitleCategory = categories.Name
//    }).ToList();

//foreach (var item in join)
//{
//    Console.WriteLine(item);
//}


//public class Product
//{
//    public string Title { get; set; }
//    public int CategoryID { get; set; }
//    public decimal Amount { get; set; }
//}

//public class Category
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}
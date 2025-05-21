//using System.Text.Json;

//var book = new Book()
//{
//    Title = "Warren Buffetts Investment Rules",
//    Author = "Miller Jeremy",
//    PublishedDate = new DateTime(2015, 7, 20)
//};

//var jsonSerializerOptions = new JsonSerializerOptions
//{
//    WriteIndented = true, // для преобразования с отступами
//    PropertyNamingPolicy = JsonNamingPolicy.CamelCase // Все в camelCase
//};

//var bookToJson = string.Empty;
//try
//{
//    bookToJson = JsonSerializer.Serialize(book, jsonSerializerOptions);
//}
//catch (JsonException ex)
//{
//    Console.WriteLine($"Ошибка сериализации: {ex.Message}");
//}

//Console.WriteLine($"Json:\n{bookToJson}");
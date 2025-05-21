//using System.Text.Json;
//var books = new List<Book>
//{
//    new(){Title = "Pale Fire",Author = "Vladimir Nabokov",PublishedDate = new DateTime(1962,1,3)},
//    new(){Title = "Ulysses",Author = "Thomas Pynchon",PublishedDate = new DateTime(1922,4,5)},
//    new(){Title = "The Public Burning",Author = "Robert Coover", PublishedDate = new DateTime(1973, 2, 1)},
//    new(){Title = "The Sound and the Fury",Author = "William Faulkner", PublishedDate = new DateTime(1977, 12, 1)}
//};

//var booksToJson = string.Empty;
//var jsonSerializerOptions = new JsonSerializerOptions
//{
//    WriteIndented = true,
//    PropertyNamingPolicy = JsonNamingPolicy.CamelCase
//};

////books[0].SomeBooks = books; // Ссылка на саму коллекцию, пробую вызвать ошибку сериализации


//// Сериализация списка книг в строку JSON
//try
//{
//    booksToJson = JsonSerializer.Serialize(books, jsonSerializerOptions);
//    Console.WriteLine($"Books to JSON:\n{booksToJson}");
//}
//catch (JsonException ex)
//{
//    Console.WriteLine($"Ошибка сериализации {ex.Message}");
//}

//// Десериализация строки JSON обратно в список объектов Book.
//try
//{
//    Console.WriteLine("------------\nBooks from JSON");
//    var booksFromJson = JsonSerializer.Deserialize<List<Book>>(booksToJson);
//    for (int i = 0; i < booksFromJson.Count; i++)
//    {
//        Console.WriteLine(booksFromJson[i]);
//    }
//}

//catch (JsonException ex)
//{
//    Console.WriteLine($"Ошибка десериализации {ex.Message}");
//}



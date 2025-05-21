//using System.Text.Json;

//var books = new List<Book>
//{
//    new(){Title = "Pale Fire",Author = "Vladimir Nabokov",PublishedDate = new DateTime(1962,1,3)},
//    new(){Title = "Ulysses",Author = "Thomas Pynchon",PublishedDate = new DateTime(1922,4,5)},
//    new(){Title = "The Public Burning",Author = "Robert Coover", PublishedDate = new DateTime(1973, 2, 21)},
//    new(){Title = "The Sound and the Fury",Author = "William Faulkner", PublishedDate = new DateTime(1977, 12, 1)}
//};
//string path = @"C:\Users\TitanPC\Desktop\Books.json";

//// Запись в файл
//try
//{
//    var options = new JsonSerializerOptions
//    {
//        WriteIndented = true,
//        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
//    };
//    string booksToJson = string.Empty;

//    try
//    {
//        booksToJson = JsonSerializer.Serialize(books, options);
//        using (var streamWriter = new StreamWriter(path))
//        {
//            streamWriter.Write(booksToJson);
//        }
//        Console.WriteLine($"Данные успешно записаны в файл: {Path.GetFileName(path)}");
//        Console.WriteLine("----------------------------------------");
//    }
//    catch (JsonException ex)
//    {
//        Console.WriteLine($"Ошибка сериализации: {ex.Message}");
//        return;
//    }

//    // Чтение из файла
//    string jsonFromFile = string.Empty;
//    try
//    {
//        if (!File.Exists(path))
//        {
//            Console.WriteLine("Ошибка: файл не существует");
//            return;
//        }

//        using (var streamReader = new StreamReader(path))
//        {
//            jsonFromFile = streamReader.ReadToEnd();
//        }

//        Console.WriteLine($"Содержимое файла {Path.GetFileName(path)}:");
//        Console.WriteLine(jsonFromFile);
//    }
//    catch (JsonException ex)
//    {
//        Console.WriteLine($"Ошибка десериализации: {ex.Message}");
//        return;
//    }

//    //Десериализация объектов обратно
//    Console.WriteLine("\nДесериализация обратно в список объектов:");
//    Console.WriteLine("----------------------------------------");

//    try
//    {
//        var newBooks = JsonSerializer.Deserialize<List<Book>>(jsonFromFile);

//        foreach (var book in newBooks)
//        {
//            Console.WriteLine($"- {book}");
//        }
//    }
//    catch (JsonException ex)
//    {
//        Console.WriteLine($"Ошибка десериализации: {ex.Message}");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Возникла ошибка: {ex.Message}");
//}
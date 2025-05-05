//using System.Text.Json;

//var student = new Student
//{
//    Name = "Kirill",
//    Age = 22,
//    Grades = { 4, 5, 5, 4 }
//};

//var studentToJson = string.Empty;
//try
//{
//    var options = new JsonSerializerOptions { WriteIndented = true };
//    studentToJson = JsonSerializer.Serialize(student, options);
//    Console.WriteLine($"Json:\n{studentToJson}");
//}
//catch (JsonException ex)
//{
//    Console.WriteLine($"Ошибка сериализации: {ex.Message}");
//    return;
//}

//Console.WriteLine("--------------");
//try
//{
//    // строка для вызова исключения при десереализации
//    //string errorJson = "{\r\n  \"Name\": \"Kirill\",\r\n  \"Age\": \"twenty-two\",\r\n  \"Grades\": [\r\n    4,\r\n    5,\r\n    5,\r\n    4\r\n  ]\r\n}";
//    var studFromJson = JsonSerializer.Deserialize<Student>(studentToJson);
//    Console.WriteLine("Student from Json:");
//    studFromJson.DisplayInfo();
//}
//catch (JsonException ex)
//{
//    Console.WriteLine($"Ошибка десериализации: {ex.Message}");
//}

//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = @"C:\Users\TitanPC\Desktop\FileStream.txt";

//        // Запись в файл
//        try
//        {
//            // можно и не создавать fileStream, streamWriter сделает это сам
//            //using var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write);
//            using var streamWriter = new StreamWriter(path);

//            streamWriter.WriteLine("Первая строчка");
//            streamWriter.WriteLine("Вторая строчка");

//            Console.WriteLine("Данные успешно записаны в файл.");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка при записи: {ex.Message}");
//        }

//        // Чтение из файла
//        Console.WriteLine("\n----------\nЧтение из файла\n-----------");
//        ReadFromFile(path);

//        static void ReadFromFile(string filePath)
//        {
//            try
//            {
//                using var streamReader = new StreamReader(filePath);

//                Console.WriteLine("Содержимое файла:");
//                string line;
//                while ((line = streamReader.ReadLine()) != null)
//                {
//                    Console.WriteLine(line);
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка при чтении: {ex.Message}");
//            }
//        }
//    }
//}


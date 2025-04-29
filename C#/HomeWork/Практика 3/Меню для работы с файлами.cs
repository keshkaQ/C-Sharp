//using System;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        string path = @"C:\Users\TitanPC\Desktop\text.txt";
//        bool exit = false;

//        while (!exit)
//        {
//            Console.WriteLine("1 - Записать текст в файл");
//            Console.WriteLine("2 - Прочитать текст из файла");
//            Console.WriteLine("3 - Удалить файл");
//            Console.WriteLine("4 - Выйти из программы");
//            Console.Write("Выберите действие (1-4): ");

//            string input = Console.ReadLine();
//            int choice;

//            try
//            {
//                choice = int.Parse(input);
//                if (choice >= 1 && choice <= 4)
//                {
//                    switch (choice)
//                    {
//                        case 1:
//                            WriteTextToFile(path);
//                            break;
//                        case 2:
//                            ReadTextFromFile(path);
//                            break;
//                        case 3:
//                            DeleteFile(path);
//                            break;
//                        case 4:
//                            Console.WriteLine("Выход из программы");
//                            exit = true;
//                            break;
//                    }
//                }
//                else
//                {
//                    Console.WriteLine("Ошибка: Введите число от 1 до 4.");
//                }
//            }
//            catch (FormatException)
//            {
//                Console.WriteLine("Ошибка: Введите корректное число.");
//            }
//        }
//    }

//    static void WriteTextToFile(string path)
//    {
//        Console.Write("Введите текст: ");
//        string inputText = Console.ReadLine();

//        try
//        {
//            using (StreamWriter writer = new StreamWriter(path))
//            {
//                writer.Write(inputText);
//            }
//            Console.WriteLine("Данные успешно записаны в файл");
//        }
//        catch (Exception ex)
//        {
//            Console.WriteLine($"Ошибка записи: {ex.Message}");
//        }
//    }

//    static void ReadTextFromFile(string path)
//    {
//        if (File.Exists(path))
//        {
//            try
//            {
//                using (StreamReader reader = new StreamReader(path))
//                {
//                    Console.WriteLine($"Содержимое файла ({path}):");
//                    Console.WriteLine(reader.ReadToEnd());
//                }
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка чтения: {ex.Message}");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Файл не найден: {path}");
//        }
//    }

//    static void DeleteFile(string path)
//    {
//        if (File.Exists(path))
//        {
//            try
//            {
//                File.Delete(path);
//                Console.WriteLine("Файл успешно удален");
//            }
//            catch (Exception ex)
//            {
//                Console.WriteLine($"Ошибка удаления: {ex.Message}");
//            }
//        }
//        else
//        {
//            Console.WriteLine($"Файл не найден: {path}");
//        }
//    }
//}

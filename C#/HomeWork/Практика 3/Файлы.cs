//using System.Diagnostics;
//using System.IO;

//class Program
//{
//    static void Main()
//    {
//        try
//        {
//            // Основной блок выполнения операций с файлами
//            Console.WriteLine("\nЗапись в файл\n-----------");
//            string path = @"C:\Users\TitanPC\Desktop\text.txt"; // Путь к основному файлу

//            /************************************************
//             * ЗАПИСЬ В ФАЙЛ
//             ***********************************************/
//            try
//            {
//                var str = "Hello,World!";
//                // Запись текста в файл (создаст файл, если его нет)
//                File.WriteAllText(path, str);
//                Console.WriteLine($"Файл создан и в него записана строка {str}");
//            }
//            catch (Exception ex) // Обработка ошибок записи
//            {
//                Console.WriteLine($"Ошибка записи в файл: {ex.Message}");
//            }

//            /************************************************
//             * ДОБАВЛЕНИЕ ТЕКСТА В КОНЕЦ ФАЙЛА
//             ***********************************************/
//            try
//            {
//                // Добавление новой строки в конец файла
//                AppendToFile(path, "\nЭто новая строка, добавленная в конец файла.");
//                Console.WriteLine("В файл добавлена новая строка.");
//            }
//            catch (Exception ex) // Обработка ошибок добавления текста
//            {
//                Console.WriteLine($"Ошибка добавления текста: {ex.Message}");
//            }

//            /************************************************
//             * ЧТЕНИЕ ИЗ ФАЙЛА
//             ***********************************************/
//            Console.WriteLine("\n----------\nЧтение из файла\n-----------");
//            try
//            {
//                if (File.Exists(path))
//                {
//                    Console.WriteLine("Чтение файла построчно с выводом номеров строк");
//                    ReadFromFile(path);
//                    Console.WriteLine("Чтение и вывод всего содержимого файла");
//                    Console.WriteLine(File.ReadAllText(path));
//                }
//                else
//                {
//                    Console.WriteLine("Файл для чтения не найден");
//                }
//            }
//            catch (Exception ex) // Обработка других ошибок чтения
//            {
//                Console.WriteLine($"Ошибка чтения: {ex.Message}");
//            }

//            /************************************************
//             * КОПИРОВАНИЕ ФАЙЛА
//             ***********************************************/
//            Console.WriteLine("\n----------\nКопирование файла\n-----------");
//            string targetDirectory = @"C:\Users\TitanPC\Desktop\Домашние задания академия топ";
//            // Формирование пути для копии файла
//            string targetFile = targetDirectory + "\\" + Path.GetFileName(path); // Формируем путь вручную

//            try
//            {
//                // Создание целевой директории, если она не существует
//                if (!Directory.Exists(targetDirectory))
//                {
//                    Directory.CreateDirectory(targetDirectory);
//                }

//                // Копирование файла с разрешением перезаписи
//                File.Copy(path, targetFile, true);
//                Console.WriteLine($"Файл успешно скопирован в: {targetDirectory}");
//            }
//            catch (Exception ex) // Обработка ошибок копирования
//            {
//                Console.WriteLine($"Ошибка копирования: {ex.Message}");
//            }

//            /************************************************
//             * ПЕРЕМЕЩЕНИЕ ФАЙЛА
//             ***********************************************/
//            Console.WriteLine("\n----------\nПеремещение файла\n-----------");
//            string fileForMove = @"C:\Users\TitanPC\Desktop\move.txt"; // Файл для перемещения

//            try
//            {
//                // Создание файла для теста перемещения
//                File.WriteAllText(fileForMove, "Это файл для перемещения");

//                // Формирование целевого пути
//                string targetFile2 = targetDirectory + "\\" + Path.GetFileName(fileForMove); ;
//                // Перемещение файла с разрешением перезаписи
//                File.Move(fileForMove, targetFile2, true);
//                Console.WriteLine($"Файл перемещён в: {targetFile2}");
//            }
//            catch (Exception ex) // Обработка ошибок перемещения
//            {
//                Console.WriteLine($"Ошибка перемещения: {ex.Message}");
//            }
//        }
//        catch (Exception ex) // Обработка ошибок всего кода
//        {
//            Console.WriteLine($"Произошла ошибка: {ex.Message}");
//        }
//    }

//    /************************************************
//     * МЕТОД ДОБАВЛЕНИЯ ТЕКСТА В КОНЕЦ ФАЙЛА
//     ***********************************************/
//    static void AppendToFile(string filePath, string text)
//    {
//        // Проверка на пустую строку
//        if (string.IsNullOrWhiteSpace(text))
//        {
//            throw new ArgumentException("Строка не может быть пустой");
//        }
//        // Добавление текста в конец файла
//        File.AppendAllText(filePath, text);
//    }

//    /************************************************
//     * МЕТОД ЧТЕНИЯ ФАЙЛА ПОСТРОЧНО
//     ***********************************************/
//    static void ReadFromFile(string filePath)
//    {
//        // Чтение всех строк файла
//        var lines = File.ReadAllLines(filePath);
//        // Вывод каждой строки с номером
//        for (int i = 0; i < lines.Length; i++)
//        {
//            Console.WriteLine($"{i + 1}-ая строка: {lines[i]} ");
//        }
//    }
//}



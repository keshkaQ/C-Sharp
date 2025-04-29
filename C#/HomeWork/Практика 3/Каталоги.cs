//// Пути для основного каталога и подкаталогов
//string path = "C:\\Users\\TitanPC\\Desktop\\Example";
//string subFolder1 = "C:\\Users\\TitanPC\\Desktop\\Example\\Subfolder1";
//string subFolder2 = "C:\\Users\\TitanPC\\Desktop\\Example\\Subfolder2";

//if (!Directory.Exists(path)) // Проверяем, существует ли основной каталог
//{
//    try
//    {
//        // Создаем основной каталог
//        Directory.CreateDirectory(path);
//        Console.WriteLine($"Основной каталог создан: {path}");

//        // Создаем первый подкаталог (если не существует)
//        if (!Directory.Exists(subFolder1))
//        {
//            Directory.CreateDirectory(subFolder1);
//            Console.WriteLine($"Подкаталог 1 создан: {subFolder1}");
//        }

//        // Создаем второй подкаталог (если не существует)
//        if (!Directory.Exists(subFolder2))
//        {
//            Directory.CreateDirectory(subFolder2);
//            Console.WriteLine($"Подкаталог 2 создан: {subFolder2}");
//        }
//    }
//    catch (Exception ex) // Обрабатываем ошибки создания каталогов
//    {
//        Console.WriteLine($"Ошибка при создании каталогов: {ex.Message}");
//    }
//}
//else
//{
//    Console.WriteLine($"Основной каталог уже существует: {path}");
//}

//Console.WriteLine();

//// Вывод на экран
//// Получаем имя корневой папки
//string directoryName = Path.GetFileName(path);
//Console.WriteLine($"Имя корневой папки: {directoryName}");

//// Выводим список подкаталогов
//Console.WriteLine("-----Подкаталоги----");
//string[] dirs = Directory.GetDirectories(path); // Получаем все подкаталоги

//foreach (string dir in dirs)
//{
//    Console.WriteLine($"Подкаталог: {Path.GetFileName(dir)}");
//}


//Console.WriteLine("-----Удаление каталогов----");

//// Ждем подтверждения пользователя
//Console.WriteLine("Нажмите любую клавишу для удаления каталогов");
//Console.ReadKey();
//Console.WriteLine();

//try
//{
//    if (Directory.Exists(path)) // Проверка на существование каталога перед удалением
//    {
//        // Запрашиваем подтверждение удаления
//        Console.WriteLine("Вы уверены, что хотите удалить каталог и все его содержимое? (y/n)");
//        if (Console.ReadKey().Key == ConsoleKey.Y)
//        {
//            // Удаляем каталог рекурсивно (со всем содержимым если передать true)
//            Directory.Delete(path, true);
//            Console.WriteLine($"\nКаталог {path} и все его содержимое удалены.");
//        }
//        else
//        {
//            Console.WriteLine("\nУдаление отменено");
//        }
//    }
//    else
//    {
//        Console.WriteLine($"Каталог {path} не существует, удаление не требуется.");
//    }
//}
//catch (Exception ex) // Обрабатываем ошибки удаления
//{
//    Console.WriteLine($"Ошибка при удалении каталогов: {ex.Message}");
//}
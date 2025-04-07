
//var dict = new Dictionary<int, int>();

//dict.Add(1, 1); // o(1)
//dict.Remove(1); // o(1)
//var value = dict[1]; // o(1)
//var iscontains = dict.ContainsKey(1); // o(1)


//// Какой символ встречается больше всего раз
//// Исходная строка для анализа
//string str = "fjjfjfsdjfsdjfdsjfsdfsdfslkfsfklsfksflsffslflssf";

//// Создаем словарь для подсчета частоты символов
//// Ключ - символ (char), значение - количество повторений (int)
//var dictionary = new Dictionary<char, int>();

//// Переменные для хранения самого частого символа
//int maxElem = -1;    // Максимальное количество повторений
//char elem = ' ';     // Самый часто встречающийся символ

//// Проходим по всем символам строки (O(n), где n - длина строки)
//for (int i = 0; i < str.Length; i++)
//{
//    var currentchar = str[i];

//    // Если символа еще нет в словаре, добавляем его с счетчиком 1
//    if (!dictionary.ContainsKey(currentchar))
//    {
//        dictionary.Add(str[i], 1);
//    }
//    else
//    {
//        // Если символ уже есть, увеличиваем счетчик
//        dictionary[currentchar]++;
//    }

//    // Проверяем, стал ли текущий символ самым частым
//    if (dictionary[currentchar] > maxElem)
//    {
//        maxElem = dictionary[currentchar];
//        elem = currentchar;
//    }
//}

//// Выводим самый часто встречающийся символ и его частоту
//Console.WriteLine($"Самый частый символ: {elem}:{maxElem}");

//// Выводим частоту всех символов
//Console.WriteLine("\nЧастота всех символов:");
//foreach (var item in dictionary)
//{
//    Console.WriteLine($"{item.Key}: {item.Value}");
//}


///*

//sub main
//set a 3
//set b 4
//call foo
//print a
//call foo2
//print b
//sub foo
//set a 25
//sub foo2
//set b 40

//*/
//class Program
//{
//    static Dictionary<string, int> variables = new Dictionary<string, int>();
//    static void Main() 
//    {
//        List<string> lines = new List<string>();  // массив строк входных
//        string line;                              // строка для считывания
//        string currentSub = null;


//        Console.WriteLine("Введите команды (пустая строка - завершение):");
//        while (!string.IsNullOrWhiteSpace(line = Console.ReadLine())) // до тех пор пока не ввели пустую строку, добавляем их в массив строк
//        {
//            lines.Add(line.Trim()); //  удаляем пробелы в начале и в конце
//        }

//        var dict = new Dictionary<string, List<string>>(); // словарь с ключом функции и значением список инструкций
//        foreach(var lin in lines)
//        {
//            if(lin.StartsWith("sub ")) // если строка начинается с sub
//            {
//                currentSub = lin.Substring(4);  // убираем sub из названия 
//                dict[currentSub] = new List<string>(); // создаем список инструкций с ключом после sub
//            }
//            else if (dict.ContainsKey(currentSub))// если значения в словаре по ключу уже есть, добавляем инструкции по этому ключу
//            {
//                dict[currentSub].Add(lin);
//            }

//        }

//        ExecuteCommand(dict, "main"); // начинаем выполнение с кода main
//    }
//    static void ExecuteCommand(Dictionary<string, List<string>> command, string subName) //  функция  для выполнения команд
//    {
//        // проходим по ключу main
//        foreach (var item in command[subName])
//        {
//            if (item.StartsWith("set ")) // устанавливаем имя переменной и значение
//            {
//                var nameVariable = item.Substring(4, 1); // получаем имя переменной
//                var value = int.Parse(item.Substring(6).Trim()); // получаем значение переменной
//                variables[nameVariable] = value; // добавляем переменную в словарь
//            }
//            else if (item.StartsWith("print ")) // выводим значение переменной
//            {
//                var nameVariable = item.Substring(6).Trim(); // получаем имя переменной и выводим ее значение из словаря
//                if (variables.ContainsKey(nameVariable))
//                {
//                    Console.WriteLine(variables[nameVariable]);
//                }
//            }
//            else if (item.StartsWith("call ")) // вызываем функцию
//            {
//                var funcName = item.Substring(5).Trim(); // получаем имя функции
//                ExecuteCommand(command, funcName); // выполняем функцию
//            }
//        }
//    }
// }



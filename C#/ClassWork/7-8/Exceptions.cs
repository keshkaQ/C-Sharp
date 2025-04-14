//var client = new HttpClient();

//try
//{
//    var data = Console.ReadLine();
//    var strings = data.Split(" ");

//    var numbers = new int[strings.Length];
//    for(int i = 0; i < numbers.Length; i++)
//    {
//        numbers[i] = int.Parse(strings[i]);
//    }
//    var last = numbers.Length;

//    //var data = client.GetAsync("/");

//    //var value = inputData();
//    //for (int i = 0; i < value; i++)
//    //{
//    //    Console.WriteLine(i);
//    //}
//}
//catch (FormatException exp)
//{
//    Console.WriteLine("Неверный формат данных");
//    //Console.WriteLine(exp.Message); // сообщение ошибки
//    //Console.WriteLine(exp.StackTrace); // посмотреть где ошибка
//}
//catch (IndexOutOfRangeException ex) // исключение выхода за границы
//{
//    Console.WriteLine("Выход за границы массива");
//}
//finally // вызывается в независимости от того поймано ли исключено
//{
//    client.Dispose();
//}


//int inputData()
//{
//    return int.Parse(Console.ReadLine());
//}

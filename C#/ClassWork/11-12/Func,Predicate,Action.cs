//Action принимает в себе 16 параметров. Он не возвращает ничего. Базовый делегат, когда необходимо передать аргументов до 16 и ничего не возвращать
// Func имеет количество параметров и возвращает количество параметров
//Func<int,int,int> func;
//func = Add;
//func.Invoke(5, 6);
//int Add(int x, int y)
//{
//    return x + y;
//}
//Predicate возвращает bool и принимает выражение (абстракция над функцией)
//Predicate<int> predicate;
//predicate = isEven;
//Console.WriteLine(predicate.Invoke(5));

//bool isEven(int x)
//{
//    return x % 2 == 0;
//}


//var bank = new Bank();
//bank.RegisterPopup(PrintSimpleMessage);
//bank.Add(400);
//bank.RegisterPopup(PrintColorMessage);
//bank.Add(600);


//void PrintSimpleMessage(string message)
//{
//    Console.WriteLine(message);
//}

//void PrintColorMessage(string message)
//{
//    Console.ForegroundColor = ConsoleColor.Green;
//    Console.WriteLine(message);
//    Console.ResetColor(); // сбросить подстветку
//}

//public class Bank
//{
//    public delegate void Popup(string message);
//    public int Sum { get; set; }
//    private Popup _popup;
//    public void RegisterPopup(Popup popup)
//    {
//        _popup = popup;
//    }
//    public void Add(int sum)
//    {
//        Sum += sum;
//        _popup.Invoke($"Баланс: {sum}");
//    }

//    public void Take(int sum)
//    {
//        Sum -= sum;
//        _popup.Invoke($"Баланс: {sum}");
//    }

//}




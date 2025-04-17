////Action принимает в себе 16 параметров. Он не возвращает ничего. Базовый делегат, когда необходимо передать аргументов до 16 и ничего не возвращать
//// Func имеет количество параметров и возвращает количество параметров
////Func<int,int,int> func;
////func = Add;
////func.Invoke(5, 6);
////int Add(int x, int y)
////{
////    return x + y;
////}
////Predicate возвращает bool и принимает выражение (абстракция над функцией)
////Predicate<int> predicate;
////predicate = isEven;
////Console.WriteLine(predicate.Invoke(5));

////bool isEven(int x)
////{
////    return x % 2 == 0;
////}


////var bank = new Bank();
////bank.RegisterPopup(PrintSimpleMessage);
////bank.Add(400);
////bank.RegisterPopup(PrintColorMessage);
////bank.Add(600);


////void PrintSimpleMessage(string message)
////{
////    Console.WriteLine(message);
////}

////void PrintColorMessage(string message)
////{
////    Console.ForegroundColor = ConsoleColor.Green;
////    Console.WriteLine(message);
////    Console.ResetColor(); // сбросить подстветку
////}

////public class Bank
////{
////    public delegate void Popup(string message);
////    public int Sum { get; set; }
////    private Popup _popup;
////    public void RegisterPopup(Popup popup)
////    {
////        _popup = popup;
////    }
////    public void Add(int sum)
////    {
////        Sum += sum;
////        _popup.Invoke($"Баланс: {sum}");
////    }

////    public void Take(int sum)
////    {
////        Sum -= sum;
////        _popup.Invoke($"Баланс: {sum}");
////    }

////}


//// Func
//int result1 = DoOperation(6, DoubleNumber); // 12
//Console.WriteLine(result1);

//int result2 = DoOperation(6, SquareNumber); // 36
//Console.WriteLine(result2);

//int DoOperation(int n, Func<int, int> operation) => operation(n);
//int DoubleNumber(int n) => 2 * n;
//int SquareNumber(int n) => n * n;

//// Predicat
//Predicate<int> isPositive = (int x) => x > 0;

//Console.WriteLine(isPositive(20));
//Console.WriteLine(isPositive(-20));


//// Action
//DoOperations(10, 6, Add);        // 10 + 6 = 16
//DoOperations(10, 6, Multiply);   // 10 * 6 = 60

//void DoOperations(int a, int b, Action<int, int> op) => op(a, b);

//void Add(int x, int y) => Console.WriteLine($"{x} + {y} = {x + y}");
//void Multiply(int x, int y) => Console.WriteLine($"{x} * {y} = {x * y}");
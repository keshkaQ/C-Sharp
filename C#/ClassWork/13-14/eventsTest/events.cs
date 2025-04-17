//var account = new Account();

//// Регистрируем стандартный обработчик (вывод в консоль)
//account.RegisterAccountHandler(Console.WriteLine);

//account.Put(299);
//account.Put(499);

//account.Notify += ConsoleGreen;


//account.Put(200);
//account.Put(222);

//account.Notify -= ConsoleGreen;

//void ConsoleGreen(string message)
//{
//    Console.BackgroundColor = ConsoleColor.Green;
//    Console.WriteLine(message);  
//    Console.ResetColor();
//}

//public class Account
//{
//    // Текущая сумма на счету
//    public int Sum { get; private set; }

//    // Делегат для обработки событий счета
//    public delegate void AccountHandler(string message);

//    // Приватное поле для хранения подписчиков
//    private event AccountHandler notify;

//    // Публичное событие с add/remove
//    public event AccountHandler Notify
//    {
//        add
//        {
//            Console.WriteLine($"Подписали метод {value.Method.Name}");
//            notify += value;  // Добавляем подписчика
//        }
//        remove
//        {
//            Console.WriteLine($"Отписали метод {value.Method.Name}");
//            notify -= value;  // Удаляем подписчика
//        }
//    }

//    // Метод для регистрации обработчика
//    public void RegisterAccountHandler(AccountHandler accountHandler)
//    {
//        Notify += accountHandler;
//    }

//    // Метод внесения денег
//    public void Put(int sum)
//    {
//        Sum += sum;
//        notify.Invoke($"На счету: {Sum} денег"); 
//    }

//    // Метод снятия денег
//    public void Take(int sum)
//    {
//        Sum -= sum;
//        notify.Invoke($"На счету: {Sum} денег");
//    }
//}
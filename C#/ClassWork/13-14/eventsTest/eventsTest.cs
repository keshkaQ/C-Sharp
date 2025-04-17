//public delegate void EventDelegate();
//public class MyClass
//{
//    EventDelegate myEvent;
//    public event EventDelegate MyEvent // создаем событие
//    {
//        // методы доступа для событий
//        add { myEvent += value; } // подписать
//        remove { myEvent -= value; } // отписать
//    }
//    // Событие служит "интерфейсом" для взаимодействия с делегатом, на который можно подписывать/отписывать события

//    public void InvokeEvent()
//    {
//        myEvent.Invoke();
//    }
//}

//class Program
//{
//    static private void Handler1()
//    {
//        Console.WriteLine("Обработчик события 1");
//    }
//    static private void Handler2()
//    {
//        Console.WriteLine("Обработчик события 2");
//    }
//    static void Main()
//    {
//        MyClass instance = new MyClass();

//        // подписка на событие
//        instance.MyEvent += Handler1;
//        instance.MyEvent += Handler2;

//        instance.InvokeEvent();

//        Console.WriteLine("-----");

//        instance.MyEvent -= Handler2;

//        instance.InvokeEvent();

//        Console.ReadKey();
//    }
//}
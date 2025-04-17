//public delegate void KeyPressEventDelegate();
//public class KeyBoardMaster
//{
//    public event KeyPressEventDelegate wKeyPressedEvent; 
//    public event KeyPressEventDelegate sKeyPressedEvent;

//    public void WkeyPressedEvent()
//    {
//        if (wKeyPressedEvent != null)
//        {
//            wKeyPressedEvent.Invoke();
//        }
//    }
//    public void SkeyPressedEvent()
//    {
//        if (sKeyPressedEvent != null)
//        {
//            sKeyPressedEvent.Invoke();
//        }
//    }
//}

//class Program
//{
//    static private void ButtonW_Click()
//    {
//        Console.WriteLine("Вперед");
//    }
//    static private void ButtonS_Click()
//    {
//        Console.WriteLine("Назад");
//     }
//    static void Main()
//    {
//        KeyBoardMaster kM = new();
//        kM.wKeyPressedEvent += ButtonW_Click;
//        kM.sKeyPressedEvent += ButtonS_Click;

//        ConsoleKey pressedKey;

//        while(true)
//        {
//            pressedKey = Console.ReadKey().Key;
//            switch(pressedKey)
//            {
//                case ConsoleKey.W:
//                    kM.WkeyPressedEvent();
//                    break;
//                case ConsoleKey.S:
//                    kM.SkeyPressedEvent();
//                    break;
//            }
//        }
//    }
//}
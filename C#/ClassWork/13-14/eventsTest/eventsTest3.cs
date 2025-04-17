//public delegate void MidpointDelegate(int nun);

//public class Counter
//{
//    public event MidpointDelegate onMidpoint;
//    public void Count(int start, int end)
//    {
//        for(int i = start; i <= end; i++)
//        {
//            if(i == start+(end-start)/2)
//            {
//                if(onMidpoint != null)
//                    onMidpoint.Invoke(i);
//            }
//            Console.Write("\n");

//        }
//    }
//}

//class Test
//{
//    public static void SayHello()
//    {
//        Console.WriteLine("Hello");
//    }
//}

//class Program
//{
//    public static void WriteMidpoint(int n)
//    {
//        Console.WriteLine(n);
//    }
//    public static void Subscribe()
//    {
//        Console.WriteLine("Подпишитесь на канал");
//    }
//    public static void Main()
//    {
//        Counter counter = new();
//        //counter.onMidpoint += Subscribe;
//        //counter.onMidpoint += Test.SayHello;

//        counter.onMidpoint += WriteMidpoint;


//        counter.Count(1, 5);

//        Console.ReadLine();
//    }
//}
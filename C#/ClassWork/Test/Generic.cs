//using System.Security.Principal;

//public class Program
//{
//    public static void Main()
//    {
//        Account <string,int> acc1 = new Account<string,int>("cid2373", 5000);
//        Account <int,string> acc2 = new Account<int,string>(37, "1000");
//        Console.WriteLine($"Id 1: {acc1.getId()}");
//        Console.WriteLine($"Id 1: {acc2.getId()}");
//        Console.WriteLine($"Sum 1: {acc1.getSum()}");
//        Console.WriteLine($"Sum 2: {acc2.getSum()}");

//    }
//}

//public class Account<T,U>
//{
//    public T _id;
//    public U _sum;
     
//    public Account(T id, U sum)
//    {
//        _id = id;
//        _sum = sum;
//    }

//    public T getId() { return _id; }
//    public U getSum() { return _sum; }
//    public void setSum(U sum) { _sum = sum; }
//}

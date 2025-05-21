//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_.ClassWork.Test;

//class Program
//{
//    delegate R MyDelegate<T, R>(T data);
//    delegate T MyDelegate<T>();

//    static int GetStrLength(string str)
//    {
//        return str.Length;
//    }
//    static int GetStrLength()
//    {
//        return 222;
//    }
//    static void Main()
//    {
//        MyDelegate<string, int> myDelegate = GetStrLength;
//        MyDelegate<int> myDelegate1 = GetStrLength;

//        Console.WriteLine(myDelegate.Invoke("Hello,World!"));
//        Console.WriteLine(myDelegate1.Invoke());

//    }
//}

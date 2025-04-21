//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace C_.ClassWork.Test;

//class WeekEnumerator: IEnumerator
//{
//    string[] days;
//    int position = -1;
//    public WeekEnumerator(string[] days)
//    {
//        this.days = days;
//    }
//    public object Current
//    {
//        get
//        {
//            if (position == -1 ||position > days.Length)
//            {
//                throw new IndexOutOfRangeException();
//            }
//            return days[position];
//        }
//    }
//    public bool MoveNext()
//    {
//        if (position < days.Length - 1)
//        {
//            position++;
//            return true;
//        }
//        else return false;
//    }
//    public void Reset()
//    {
//        position = -1;
//    }
//}
//class Week: IEnumerable
//{
//    string[] days =
//        {"Monday",
//        "Tuesday",
//        "Wednesday",
//        "Thursday",
//        "Friday",
//        "Saturday",
//        "Sunday",
//    };
//    public IEnumerator GetEnumerator()
//    {
//        return new WeekEnumerator(days);
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Week week = new Week();

//        foreach (var day in week)
//        {
//            Console.WriteLine(day);
//        }


//        //int[] numbers = { 0, 2, 4, 6, 8, 10 };
//        //IEnumerator enumerator = numbers.GetEnumerator();

//        //while (enumerator.MoveNext())
//        //{
//        //    int item = (int)enumerator.Current;
//        //    Console.WriteLine(item);
//        //}
//        //enumerator.Reset();
//    }
//}
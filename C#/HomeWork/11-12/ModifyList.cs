//using System;
//using System.Linq;

//var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//list = list.ModifyList(x => x * 10);
//Console.WriteLine(string.Join(",", list));

//public static class ListExtensions
//{
//    public static List<int> ModifyList(this List<int> list, Func<int, int> lambdaFunc)
//    {
//        if (list == null)
//        {
//            throw new ArgumentNullException(nameof(list));
//        }
//        var newList = new List<int>();

//        for (int i = 0; i < list.Count; i++)
//        {
//            var res = lambdaFunc.Invoke(list[i]);
//            newList.Add(res);
//        }
//        return newList;
//    }
//}
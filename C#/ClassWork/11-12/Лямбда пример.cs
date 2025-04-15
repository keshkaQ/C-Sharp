//var list = new List<int> { 1, 2, 3, 4, 5, 6, 8 };
//list = list.FilterByRule(x => x % 2 == 0);
//Console.WriteLine(string.Join(",", list));

//public static class MyList
//{
//    public static List<int> FilterByRule(this List<int> list,Predicate<int> predicate)
//    {
//        var newList = new List<int>();

//        for(int i = 0; i< list.Count;i++)
//        {
//            if (predicate.Invoke(list[i]))
//            {
//                newList.Add(list[i]);
//            }
//        }
//        return newList;
//    }
//}
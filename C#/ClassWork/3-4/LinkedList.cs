//var list = new LinkedList<int>();
//list.AddFirst(1); // O(n)
//list.AddLast(1); // O(n)
//list.AddLast(3); // O(n)
//list.AddLast(4); // O(n)
//list.AddLast(5); // O(n)

//foreach(var item in list)
//{
//    Console.Write($"{item} ");
//}
//Console.WriteLine();
//var first = list.First;
//int index = 0;
//while (first != null)
//{
//    if (index == 5)
//    {
//        list.AddAfter(first, new LinkedListNode<int>(5)); // o(n)
//        //list.AddBefore(first, new LinkedListNode<int>(5)); // o(n)
//    }
//    first = first.Next;
//    index++;
//}
//foreach (var item in list)
//{
//    Console.Write($"{item} ");
//}

//using System.Collections;

////var list = new List<int> { 1, 2, 4, 5, 6, 7, 88, 9 };
////var myEnumerable = new MyEnumerable(list);

////foreach(var item in myEnumerable)
////{
////    Console.WriteLine(item);
////}




//foreach (var fibonacciNum in GetEnumerator(5))
//{
//    Console.WriteLine(fibonacciNum);
//}

//IEnumerable<int> GetEnumerator(int n)
//{
//    int first = 0;
//    int second = 1;
//    int res = 0;

//    for (int i = 0; i < n; i++)
//    {
//        yield return res;
//        res = first + second; // новое число = сумма двух предыдущих
//        second = first;       // обновляем "предыдущее" число
//        first = res;          // обновляем "текущее" число
//        if (res > 1000)
//        {
//            yield break; // прекратить итерации по итератору
//        }
//    }
//}




//void Foo(IEnumerable enumerable)
//{
//    var enumerator = enumerable.GetEnumerator();

//    while (enumerator.MoveNext())
//    {
//        Console.WriteLine(enumerator.Current);
//    }
//}
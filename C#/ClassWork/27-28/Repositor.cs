
//var repInt = new Repositor<int>();
//repInt.Add(1);

//var repDouble = new Repositor<double>();
//repDouble.Add(33.2);

//var repString = new Repositor<string>();
//repString.Add("33.2");


//// Кода генерации, во время работы программы дописывать логику
////@"if(x==6)
////{
////    x = 10;
////}"

////public class SomeClass
////{
////    public void SomeAction()
////    {
////        if(x==6)
////        {
////            x = 10;
////        }
////    }
////}


//public class Repositor<T> where T: IComparable <T>
//{
//    private List<T> _items;
//    public void Add(T value)
//    {
//        _items.Add(value);
//    }
//    public void Remove(T value)
//    {
//        _items.RemoveAll(x => x.CompareTo(value) == 0);
//    }
//    public void Update(T value,int index)
//    {
//        _items[index] = value;
//    }
//    public bool IsContains(T value)
//    {

//        return _items.Contains(value);
//        //var item = _items.FirstOrDefault(x => x.CompareTo(value) == 0);
//        //return item != null;


//        //for (int i = 0; i<_items.Count; i++)
//        //{
//        //    if (_items[i].CompareTo(_items[i]) == 0)
//        //    {
//        //        return true;
//        //    }
//        //}
//        //return false;
//    }
//}
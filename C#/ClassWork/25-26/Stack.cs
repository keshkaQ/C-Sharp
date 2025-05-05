//myStack<int> stack = new myStack<int>();
//Console.WriteLine(stack.Count);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//stack.Push(2);
//Console.WriteLine(stack.Count);

//public class myStack<T>
//{
//    private T[] _elements = new T[8];

//    public int Count { get; private set; } = 0;
//    public void Push(T value)
//    {
//        if (_elements.Length == Count)
//        {
//            var newArray = new T[_elements.Length * 2];
//            for (int i = 0; i < _elements.Length; i++)
//            {
//                newArray[i] = _elements[i];
//            }
//            _elements = newArray;
//        }
//        _elements[Count] = value;
//        Count++;
//    }
//    public T Pop(T value)
//    {
//        T item = _elements[Count - 1];
//        Count--;
//        return item;
//    }
//}

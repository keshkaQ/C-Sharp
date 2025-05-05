//using System.Xml.Linq;

//MyStack<int> stack = new MyStack<int>();

//// Добавление элементов
//Console.WriteLine("Добавляем элементы в стек: 1, 2, 3");
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);

//// Просмотр верхнего элемента без удаления
//Console.WriteLine($"\nВерхний элемент стека (Peek): {stack.Peek()}");

//// Извлечение элементов методом Pop с удалением
//Console.WriteLine("\nДостаем элементы из стека:");
//Console.WriteLine($"Извлеченный элемент: {stack.Pop()}");
//Console.WriteLine($"Извлеченный элемент: {stack.Pop()}");
//Console.WriteLine($"Извлеченный элемент: {stack.Pop()}");

//// Попытка достать из пустого стека
//Console.WriteLine("\n-----Попытка достать элемент из пустого стека-----");
//try
//{
//    stack.Pop();
//}
//catch (InvalidOperationException ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//// Очистка стека
//Console.WriteLine("\n-----Проверка метода Clear-----");
//Console.WriteLine("\nДобавляем элементы: 1, 2, 3");
//stack.Push(1);
//stack.Push(2);
//stack.Push(3);
//Console.WriteLine($"Количество элементов в стеке до очистки: {stack.Count}");
//stack.Clear();
//Console.WriteLine($"Количество элементов в стеке после очистки: {stack.Count}");


//public class MyStack<T>
//{
//    private List<T> _items = new List<T>();
//    public int Count => _items.Count;
//    public void Clear() => _items.Clear();
//    public void Push(T item)
//	{
//        _items.Add(item);
//    }
//    public T Pop()
//    {
//        if(Count == 0)
//        {
//            throw new InvalidOperationException("Стек пуст");
//        }
//        var lastIndex = Count - 1;
//        T item = _items[lastIndex];
//        _items.RemoveAt(lastIndex);
//        return item;

//    }
//    public T Peek()
//    {
//        if (Count == 0)
//        {
//            throw new InvalidOperationException("Стек пуст");
//        }
//        return _items[Count - 1];
//    }
//}
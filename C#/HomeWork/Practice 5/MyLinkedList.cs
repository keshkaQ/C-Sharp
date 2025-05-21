//using System;
//using System.Collections;
//using System.Collections.Generic;

//MyLinkedList<string> list = ["Первый элемент", "Второй элемент", "Третий элемент"];

//Console.WriteLine("Список содержит 'Первый элемент': " + list.Contains("Первый элемент"));
//Console.WriteLine("Список содержит 'Нулевой элемент': " + list.Contains("Нулевой элемент"));

//Console.WriteLine("Элементы списка:");
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


//public class MyLinkedList<T> : IEnumerable<T>
//{
//    private class Node
//    {
//        // данные
//        public T Data { get; set; }
//        // ссылка на следующий узел
//        public Node? Next { get; set; }

//        public Node(T data)
//        {
//            Data = data;
//            Next = null;
//        }
//    }
//    // головной элемент
//    private Node head;

//    // метод по добавлению элемента
//    public void Add(T data)
//    {
//        // создаем новый узел
//        Node newNode = new Node(data);
//        // если головного элемента нет - новый узел становится головным элементом
//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            // получаем головной элемент и проходимся до последнего узла
//            Node current = head;
//            while (current.Next != null)
//            {
//                // переход на следующий узел
//                current = current.Next;
//            }
//            // после того, как дошли до конечного узла, добавляем новый узел в конец
//            current.Next = newNode;
//        }
//    }
//    // метод для проверки элемента в списке
//    public bool Contains(T data)
//    { 
//        // получаем голову и проходим по всем узлам
//        Node current = head;
//        while (current != null)
//        {
//            // если данные текущего узла равны переданным данным
//            if (current.Data.Equals(data))
//            {
//                return true;
//            }
//            // если нет, то переход на следующий узел
//            current = current.Next;
//        }
//        // если дошли до конца и не нашли ничего
//        return false;
//    }
//    // реализация интерфейса IENumerable<T> для того, чтобы перебирать список через foreach
//    public IEnumerator<T> GetEnumerator()
//    {
//        // получаем головной элемент и проходим по всем элементам
//        Node current = head;
//        while (current != null)
//        {
//            // для каждого узла возвращаем данные, перебираем элементы по одному
//            yield return current.Data;
//            // переход на следующий узел
//            current = current.Next;
//        }
//    }
//    // необобщенная версия GetEnumerator для совместимости со старыми версиями, где нет обобщений
//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}




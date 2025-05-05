using System;
using System.Collections;
using System.Collections.Generic;

LinkedList<string> list = new LinkedList<string>();
list.Add("Первый элемент");
list.Add("Первый элемент");
list.Add("Третий элемент");

Console.WriteLine("Список содержит 'Первый элемент': " + list.Contains("Первый"));
Console.WriteLine("Список содержит 'Нулевой элемент': " + list.Contains("Нулевой"));

Console.WriteLine("Элементы списка:");
foreach (var item in list)
{
    Console.WriteLine(item);
}
public class LinkedList<T> : IEnumerable<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Next { get; set; }

        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head; 

    public LinkedList()
    {
        head = null;
    }

    public void Add(T data)
    {
        Node newNode = new Node(data);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    public bool Contains(T data)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    public IEnumerator<T> GetEnumerator()
    {
        Node current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

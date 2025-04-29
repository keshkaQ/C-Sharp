using System.Collections;

public class myEnumerator : IEnumerator <int>
{
    private List<int> _list;
    private int index = -1; // счетчик для индекса
    // -1 изначально, в первой итерации увеличится на один (на случай, если коллекция пустая)

    public myEnumerator(List<int> list)
    {
        _list = list;
    }
    public int Current => _list[index]; // возвращает текущий элемент итерации

    // возвращает верхний current, тип int
    object IEnumerator.Current => Current;

    public bool MoveNext()
    {
        // проверка не вышел ли за границы списка
        if (index < _list.Count - 1)
        {
            index++;
            // если есть следующий элемент, возврат true
            return true;
        }
        // когда элементы кончились, возврат false
        return false;
    }

    public void Reset() // сброс индекса и обнуление коллекции
    {
        _list.Clear();
        index = -1;
    }

    public void Dispose()
    {
        
    }
}
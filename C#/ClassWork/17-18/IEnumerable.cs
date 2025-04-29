using System.Collections;

public class MyEnumerable : IEnumerable
{
    // список с которым будет работать enumerator
    private List<int> _list;
    public MyEnumerable(List<int> list)
    {
        _list = list;
    }
    public IEnumerator GetEnumerator()
    {
        return new myEnumerator(_list);
    }
}
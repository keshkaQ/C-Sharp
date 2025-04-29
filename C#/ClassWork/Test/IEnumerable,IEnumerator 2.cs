///* interface IEnumerator<T>
// * {
// *      Возвращает текущий элемент коллекции
// *      T Current{get};
// *      
// *      Переходит к следующему элементу коллекции
// *      bool MoveNext();
// * 
// *      Сбрасывает итератор к начальной позиции
// *      void Reset();
// * }
// * */

///* interface IEnumerable<T>
// * {
// *      Возвращает объект IEnumerator<T> для выполнения итерации
// *      IEnumerator<T> GetEnumerator();
// * }
// * */

//using System.Collections;
//using System.Drawing;

//internal class Program
//{
//    static void Main()
//    {
//        IEnumerable<int> sequence = new NumberSequence(10, 3);

//        foreach (var number in sequence)
//        {
//            Console.WriteLine(number);
//        }
//    }
//}
//public class NumberSequence: IEnumerable<int>
//{
//    private readonly int _start;
//    private readonly int _count;
//    public NumberSequence(int start,int count)
//    {
//        _start = start;
//        _count = count;
//    }
//    public IEnumerator<int> GetEnumerator()
//    {
//        return new NumberEnumerator(_start, _count);
//    }

//    IEnumerator IEnumerable.GetEnumerator()
//    {
//        return GetEnumerator();
//    }
//}
//public class NumberEnumerator : IEnumerator<int>
//{
//    private readonly int _start;
//    private readonly int _count;
//    private int _currentIndex;
//    public NumberEnumerator(int start, int count)
//    {
//        _start = start;
//        _count = count;
//        _currentIndex = -1;
//    }
//    public int Current
//    {
//        get
//        {
//            if(_currentIndex < 0|| _currentIndex >=_count)
//            {
//                throw new InvalidOperationException("Enumerator is in an invalid state");
//            }
//            return _start + _currentIndex;        }
//    }

//    object IEnumerator.Current => Current;

//    public bool MoveNext()
//    {
//        if(_currentIndex + 1 < _count)
//        {
//            _currentIndex++;
//            return true;
//        }
//        return false;
//    }

//    public void Reset()
//    {
//        _currentIndex = -1;
//    }
//    public void Dispose()
//    {
       
//    }
//}

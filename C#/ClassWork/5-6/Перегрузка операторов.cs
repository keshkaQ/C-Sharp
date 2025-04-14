////// + - * / == && != || << >> >= <= += ++ -- |^


//var num1 = new Number(1);
//var num2 = new Number(2);

//int t = new Number(10); // срабатывает implicit неявное преобразование
//double t1 = (double) new Number(10); // явное преобразование с помощью explicit
//Console.WriteLine((num1 + num2).Value);


//public class Number
//{
//    public int Value { get; set; }
//    public Number(int value)
//    {
//        Value = value;
//    }

//    public static Number operator +(Number a, Number b)
//    {
//        return new Number(a.Value + b.Value);
//    }

//    public static Number operator -(Number a, Number b)
//    {
//        return new Number(a.Value - b.Value);
//    }
//    public static Number operator *(Number a, Number b)
//    {
//        return new Number(a.Value * b.Value);
//    }
//    public static Number operator /(Number a, Number b)
//    {
//        if (b.Value == 0)
//        {
//            return a;
//        }
//        return new Number(a.Value / b.Value);
//    }
//    public static bool operator >(Number a, Number b)
//    {
//        return a.Value > b.Value;
//    }
//    public static bool operator <(Number a, Number b)
//    {
//        return a.Value < b.Value;
//    }
//    public static bool operator >=(Number a, Number b)
//    {
//        return a.Value >= b.Value;
//    }
//    public static bool operator <=(Number a, Number b)
//    {
//        return a.Value <= b.Value;
//    }

//    public static bool operator ==(Number a, Number b)
//    {
//        return a.Value == b.Value;
//    }
//    public static bool operator !=(Number a, Number b)
//    {
//        return a.Value != b.Value;
//    }
//    public static Number operator ++(Number a)
//    {
//        return new Number(a.Value++);
//    }
//    public static Number operator --(Number a)
//    {
//        return new Number(a.Value--);
//    }
//    public static bool operator !(Number a)
//    {
//        return a.Value == 0;
//    }
//    public static implicit operator int(Number a)
//    {
//        return a.Value;
//    }
//    public static explicit operator double(Number a)
//    {
//        return (double)a.Value;
//    }
//}
//// Первый способ
//int a = 5;
//var str = SomeMethod(a);

//var array = str.Split(" "); 
////выполняет разделение строки на подстроки
////(массив строк) с использованием пробела (" ") в качестве разделителя
//var t1 = array[0]; // a
//var t2 = array[1]; // 5

//string SomeMethod(int a)
//{
//    string str = a + " " + "5";
//    return str;
//}

//// второй способ
//string left = "";
//string right = "";
//bool isEmpty = false;

//for (int i = 0; i < str.Length;i++)
//{
//    if(!isEmpty)
//    {
//        left = left + str[i];
//    }
//    if(isEmpty)
//    {
//        right = right + str[i];
//    }
//    if (str[i] == ' ')
//    {
//        isEmpty = true;
//    }
//}

//// Третий способ через структуру
//var par = MethodSome(5);
//var p1 = par.Arg1;
//var p2 = par.Arg2;
//Params MethodSome(int a)
//{
//    var myparams = new Params(a, "foo");
//    return myparams;
//}
//struct Params
//{
//    public int Arg1 { get; set; }
//    public string Arg2 { get; set; }
//    public Params(int arg1, string arg2)
//    {
//        Arg1 = arg1; Arg2 = arg2;
//    }
//}

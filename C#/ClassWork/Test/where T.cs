
//MyClass1<string> myClass1 = new MyClass1<string>(); //строка ссылочный тип,поэтому можно передать в качестве параметров
//MyClass2<int> myClass2 = new MyClass2<int>(); //число значимый тип,поэтому можно передать в качестве параметров
//MyClass3<Test> test = new MyClass3<Test>(); // нужен конструктор без параметров

//// тип в <> должен быть наследником либо базовым классом
//MyClass<Derived> myClass = new MyClass<Derived>(); 
//MyClass<Base> myClasss = new MyClass<Base>(); 

//class MyClass1<T> where T: class
//{
//}

//class MyClass2<T> where T : struct
//{
//}
//class MyClass3<T> where T : new()
//{
//}
//public class Test
//{
//    // в классе есть свой конструктор без параметров,но можно создать свой
//}


//class Base { }
//class Derived : Base { }
//class MyClass<T> where T : Base { }

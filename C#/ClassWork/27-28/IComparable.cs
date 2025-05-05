//var p1 = new Person("Kirill",15);
//var p2 = new Person("Alex", 16);
//var p3 = new Person("misha", 1);

//var persons = new Person[3] { p2, p1 ,p3};
//Array.Sort(persons); // перейдет в метод CompareTo
//foreach (var person in persons)
//{
//    Console.WriteLine(persons);
//}

////Console.WriteLine(p1.CompareTo(p2));

//public class Person : IComparable<Person>
//{
//    public string Name { get; set; }
//    public  int Age { get; }
//    public Person(string name, int age)
//    {
//        Name = name;
//        Age = age;
        
//    }
//    // можно сделать любую логику сравнения
//    public int CompareTo(Person other)
//    {
//        return other.Age - Age; // от большого к меньшему
//        //return  Age - other.Age; // от меньшего к большему
//    }
//    public override string ToString()
//    {
//        return $"Name: {Name}, Age: {Age}";
//    }
//}
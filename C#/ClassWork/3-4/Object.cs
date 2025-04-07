//var person1 = new Person("Kirill", "Banar", 22);
//var person2 = new Person("Kirill", "Banar", 22);

//var isEquals = person1.Equals(person2);
//Console.ReadLine(); // чтение из консоли
//Console.WriteLine(person1); // Для ссылочных типов: возвращает полное имя типа ("Namespace.ClassName").
////Если переопределить метод ToString то выведет то, что возвращается в методе
//Console.WriteLine(person1); 


//class Person
//{
//    public string FirstName { get; }
//    public string LastName { get; }
//    public int Age { get; }
//    public Person(string firstName, string lastName, int age)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//    }
//    public override bool Equals(object obj)
//    {
//       if (obj == null)
//       {
//            return false;
//       }
//       Person currentPerson = (Person)obj;
//        return FirstName == currentPerson.FirstName && LastName == currentPerson.LastName
//             && Age == currentPerson.Age;
//    }
//    public override string ToString()
//    {
//        return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}";
//    }
//}

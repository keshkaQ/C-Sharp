//var person = new Person("Ivan", "ivanov");
//var obj = (object)person; // боксинг - преобразование дочернего типа к базовому

//SomeFunc(person);

//void SomeFunc(IHasName hasName)
//{
//   // var person = (Person)obj; // анбоксинг - операция преобразования базового типа к дочернему 
//    Console.WriteLine(hasName.FirstName);
//}
//public interface IHasName
//{
//    public string FirstName { get; set; }
//}

//struct Person: IHasName
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }

//    public Person(string firstName, string lastName)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//    }
//}
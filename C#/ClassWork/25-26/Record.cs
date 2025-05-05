
//var person = new Person("Kirill", "Banar");
//var person2 = new Person("Kirill", "Banar");

//// вызов свойства в рекорде
//Console.WriteLine(person2.FullName);

//// возьми рекорд и раздели на две переменных (деконструкция)
//var (firstName, lastName) = person;
//Console.WriteLine(firstName);
//Console.WriteLine(lastName);

//// Изменить свойство
//var per = person with { FirstName = "Alex" };
//Console.WriteLine(per); // У объекта per поменяется FirstName на Alex
//Console.WriteLine(person); // у исходного ничего не изменится

////// уже переопределены методы Equals,ToString,GetHashCode
//Console.WriteLine(person == person2);
//Console.WriteLine(person);

//// person.FirstName = "NewName"; нельзя сделать

//// свойство является неизменяемым
//public record Person(string FirstName, string LastName)
//{
//    public string FullName => $"{FirstName} {LastName}";
//    // метод тоже можно реализовать в рекордах
//    public void SomeAction()
//    {

//    }
//}
//// наследование рекордов
//public record Employee(string FirstName, string LastName, string Position) : Person(FirstName, LastName);

//public class SomeClass
//{
//    public string SomeProperty { get; init; }
//}

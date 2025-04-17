
//var personList = new List<Person>
//{
//    new() {FirstName = "Anton", LastName = "Antonov", Age = 30},
//    new() {FirstName = "Anton", LastName = "Sidorov", Age = 20},
//    new() {FirstName = "Ivan", LastName = "Ivanov", Age = 43},
//    new() {FirstName = "Ivan", LastName = "Repin", Age = 43},
//    new() {FirstName = "Ivan", LastName = "Lapin", Age = 43},
//};


//// GroupBy - определяем группу, по ключу можем сказать принадлежит ли какая-либо сущность этой группе или нет
//// Получилась коллекция тех объектов, у которых имя совпадает
//// Запись по ключу - имени
//var groupBy = personList.GroupBy(x => x.FirstName).ToList();
//foreach(var item in groupBy)
//{
//    Console.WriteLine(item.Key);
//    foreach(var person in item)
//    {
//        Console.WriteLine($" {person.LastName} {person.Age}");

//    }
//}


//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//    public override string ToString()
//    {
//        return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}";
//    }
//    public override bool Equals(object? obj)
//    {
//        var person = (Person)obj;
//        return person.FirstName == FirstName && person.LastName == LastName;
//    }
//    public override int GetHashCode()
//    {
//        return FirstName.GetHashCode() + LastName.GetHashCode() + LastName.GetHashCode();
//    }
//}

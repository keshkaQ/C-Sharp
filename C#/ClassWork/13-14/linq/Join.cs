
//var personList1 = new List<Person>
//{
//    new() {FirstName = "Anton", LastName = "Antonov", Age = 30},
//    new() {FirstName = "Danil", LastName = "Sidorov", Age = 20},
//    new() {FirstName = "Ivan", LastName = "Ivanov", Age = 43},
//};
//var personList2 = new List<Person>
//{
//    new() {FirstName = "Nik", LastName = "Antonov", Age = 34},
//    new() {FirstName = "Steve", LastName = "Sidorov", Age = 24},
//    new() {FirstName = "John", LastName = "Smith", Age = 12},
//};

//// Join - позволяет найти элементы по определенному свойству

//var join = personList1.Join(personList2, // список, с которым будет объединение
//    p1 => p1.LastName, // параметр первого списка
//    p2 => p2.LastName, // параметр второго списка
//    (p1, p2) => new { p1.FirstName, p2.LastName }).Distinct().ToList(); // создание нового объекта с параметрами имени первого списка и фамилии второго списка
//// Distinct - убирает дубликаты 

//for (int i = 0; i < join.Count;i++)
//{
//    Console.WriteLine ($"FirstName: {join[i].FirstName}, LastName: {join[i].LastName}");
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
//    // для Distinct необходимо переопределить эти функции, чтобы удалять одинаковые объекты из класса
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

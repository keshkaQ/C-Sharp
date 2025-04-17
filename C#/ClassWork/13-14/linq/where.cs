//using System.Xml.Linq;

//var list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
////Where - используется для выбора элементов по условию
//var evenNum = list.Where(x => x % 2 == 0).ToList(); // список четных чисел
//var oddNum = list.Where(x => x % 2 != 0).ToList(); // список нечетных чисел


//var personList = new List<Person>
//{
//    new() {FirstName = "Anton", LastName = "Antonov", Age = 18},
//    new() {FirstName = "Danil", LastName = "Sidorov", Age = 48},
//    new() {FirstName = "Ivan", LastName = "Ivanov", Age = 28},
//};

//// выбрать из списка все объекты, у которых длина имени равна 5
//personList = personList.Where(x => x.FirstName.Length == 5).ToList();

//// выбрать из списка все объекты, у которых длина имени и фамилии равна 5
//personList = personList.Where(x => x.FirstName.Length == 5 && x.LastName.Length == 5).ToList();

//// посчитать количество элементов в коллекции у которых длина имени равна 5
//var count = personList.Where(x => x.FirstName.Length == 5).Count();
//// получить элементы по имени и возрасту с условием, что возраст больше 18
//var whereAndSelect = personList.Select(x => new {x.FirstName,x.Age}).Where(x=>x.Age >18).ToList();
//// Если добавить Count можно посчитать их количество


//public class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//    public override string ToString()
//    {
//        return $"FirstName: {FirstName}, LastName: {LastName}, Age: {Age}";
//    }
//}
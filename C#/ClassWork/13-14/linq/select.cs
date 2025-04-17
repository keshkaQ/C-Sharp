
//var personList = new List<Person>
//{
//    new() {FirstName = "Anton", LastName = "Antonov", Age = 30},
//    new() {FirstName = "Danil", LastName = "Sidorov", Age = 20},
//    new() {FirstName = "Ivan", LastName = "Ivanov", Age = 43},
//};

//// Select позволяет выбрать атрибуты, которые необходимы (1 или несколько)

//// Выбор только имени у всего списка Person
//var firstName = personList.Select(x => x.FirstName).ToList();

//// Выбор имени и возраста у всего списка Person
//var nameAndAge = personList.Select(x => new { x.FirstName, x.Age }).ToList();
//// nameAndAge[0].FirstName - можно получить имя и возраст, фамилия недоступна


//// избавляемся от анонимного типа, полученного в результате применения
//// метода Select при получении списка по нескольким параметрам
//var personDto = personList.Select(x => new PersonDTO { FirstName = x.FirstName, Age = x.Age }).ToList();
////на выходе получаем класс PersonDto с нужными параметрами
////получить элементы по имени и возрасту с условием, что возраст больше 18
//var whereAndSelect = personList.Select(x => new { x.FirstName, x.Age }).Where(x => x.Age > 18).ToList();
////Если добавить Count можно посчитать их количество

//var r = (from p in personList select p.FirstName).ToList(); // такой же селект как у списка
//var rs = personList.Select(x=>x.FirstName).ToList(); // одинаковые с верхним

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
//// с помощью этого класса избавляемся от анонимного типа, полученного в результате применения метода Select при получении списка по нескольким параметрам
//public class PersonDTO
//{
//    public string FirstName { get; set; }
//    public int Age { get; set; }
//}
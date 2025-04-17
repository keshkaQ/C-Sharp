//var personList = new List<Person>
//{
//    new() {FirstName = "Anton", LastName = "Antonov", Age = 30},
//    new() {FirstName = "Danil", LastName = "Sidorov", Age = 20},
//    new() {FirstName = "Ivan", LastName = "Ivanov", Age = 43},
//};



//var firstInList = personList.First(); // первая запись в списке
//var lastInList = personList.Last(); // последний в списке, если не найдет выбросит исключение
//var first = personList.First(x => x.FirstName.Length == 4); // получение первого, у кого в имени 4 буквы
//var firstt = personList.FirstOrDefault(x => x.FirstName.Length == 4); // бросает null если не нашел
//var lastt = personList.LastOrDefault(x => x.FirstName.Length == 4); // бросает null если не нашел

//var minLenght = personList.Min(x => x.FirstName.Length);// вернет минимальное значение длины объекта в коллекции
//var maxLenght = personList.Max(x => x.FirstName.Length);// вернет максимальное значение длины объекта в коллекции


//class Person
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }

//    public override string ToString()
//    {
//        return $"FirstName: {FirstName} LastName: {LastName}"; /*Age {Age}*/
//    }
//    public override bool Equals(object? obj)
//    {
//        var person = (Person)obj;
//        return person.FirstName == FirstName && person.LastName == LastName;
//    }
//    public override int GetHashCode()
//    {
//        return FirstName.GetHashCode() + LastName.GetHashCode() + Age.GetHashCode();
//    }
//}

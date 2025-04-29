//using System.Text.Json;
//using System.Text.Json.Serialization;

//var currentUser = new User();



//var user = new User()
//{
//    FirstName = "Ivan", SecondName = "ivanov",
//    Login = "IvanovVanya23", Password = "password"
//};


//var users = new List<User>
//{
//    new()
//    {
//        FirstName = "Ivan", SecondName = "ivanov",
//        Login = "IvanovVanya23", Password = "password"
//    },
//    new()
//    {
//        FirstName = "Ivan", SecondName = "ivanov",
//        Login = "IvanovVanya23", Password = "password"
//    },
//    new()
//    {
//        FirstName = "Ivan", SecondName = "ivanov",
//        Login = "IvanovVanya23", Password = "password"
//    }
//};
//var superUser = new User()
//{
//    FirstName = "Ivan",
//    SecondName = "ivanov",
//    Login = "IvanovVanya23",
//    Password = "password",
//    users = users,
//};

//var jsonSerializerOptionsnew = new JsonSerializerOptions
//{
//    WriteIndented = true,
//};

//var json = JsonSerializer.Serialize(users, jsonSerializerOptionsnew);

//File.WriteAllText("C:\\Users\\TitanPC\\Desktop\\Files\\Users.txt", json);
//var jsonFromFile = File.ReadAllText("C:\\Users\\TitanPC\\Desktop\\Files\\Users.txt");
//var userFromFile = JsonSerializer.Deserialize<User>(jsonFromFile);
//var usersFromFile = JsonSerializer.Deserialize<List<User>>(jsonFromFile);
//Console.WriteLine(user);




////File.WriteAllText("C:\\Users\\TitanPC\\Desktop\\Files\\data.txt", user.ToString());

//// Сериализация - берем данные и приводим в другой формат (obj,collection of obj->JSON)
//// Десериализация - из формата JSON приводим в формат obj, collection of obj

//// var user = File.ReadAllText("C:\\Users\\TitanPC\\Desktop\\Files\\Users.txt");
////var userProperties = user.Split(',');

////for (int i = 0; i < userProperties.Length;i++)
////{
////    var propertyValue = userProperties[i].Split(':');
////    var nameProperty = propertyValue[0].Trim();
////    var valueProperty = propertyValue[1].Trim();

////    if(nameProperty == nameof(User.FirstName))
////    {
////        currentUser.FirstName = valueProperty;
////    }
////    else if (nameProperty == nameof(User.SecondName))
////    {
////        currentUser.SecondName = valueProperty;
////    }
////    else if (nameProperty == nameof(User.Login))
////    {
////        currentUser.Login = valueProperty;
////    }
////    else if (nameProperty == nameof(User.Password))
////    {
////        currentUser.Password = valueProperty;
////    }
////}

////Console.WriteLine(user);



//public class User
//{
//    //[JsonIgnore] - игнорирование свойства
//    // [JsonPropertyName("firstName")] смена имени параметра (имени)
//    public string FirstName { get; set; } = string.Empty;
//    public string SecondName { get; set; } = string.Empty;
//    public string Login { get; set; } = string.Empty;
//    public string Password { get; set; } = string.Empty;
//    public override string ToString()
//    {
//        return $"FirstName: {FirstName}, SecondName: {SecondName},Login: {Login}, Password: {Password}";
//    }
//    public List<User> users;
//}


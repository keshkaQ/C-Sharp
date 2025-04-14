//// Яндекс.Директ:/ru
//// Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik
//// Газета уральских москвичей:/ru/msk,/ru/permobl,/ru/chelobl
//// Крутая реклама:/ru/svrd

//public class AdvertisementPlatform
//{
//    // словарь для хранения рекламных платформ (string) и их локаций (list<string>)
//    private Dictionary<string, List<string>> advertisementByLocation;

//    public AdvertisementPlatform()
//    {
//        advertisementByLocation = new(); // выделяем память под словарь
//    }

//    // Метод для добавления рекламной платформы и её локаций
//    public void AddAdvertisementPlatform(string advertisementLocation)
//    {

//        var parts = advertisementLocation.Split(':'); // разбиваем строку на массив строк, в котором 0 элемент это название платформы (до :) и список локаций (массив строк после :)
//        var platformName = parts[0]; // получаем имя платформы
//        var locations = parts[1].Split(','); // разбиваем строку локаций по запятым, чтобы получить полную локацию
//        // Если использовать /, то в локации /ru/msk,/ru/permobl,/ru/chelobl будет два раза /ru

//        // cоздаем список для хранения локаций
//        List<string> locationList = new List<string>();
//        foreach (var loc in locations)
//        {
//            locationList.Add(loc); // добавляем каждую локацию в список
//        }

//        // Добавляем список локаций в словарь по ключу названия платформы
//        advertisementByLocation[platformName] = locationList;
//    }

//    // Метод для получения списка рекламных платформ, подходящих для заданной локации
//    public List<string> GetAdvertisementPlatforms(string location)
//    {
//        var result = new List<string>(); // Список для хранения результата в виде списка платформ, которые подойдут

//        // Перебираем каждую рекламную платформу в словаре
//        foreach (var item in advertisementByLocation)
//        {
//            // Перебираем все локации для текущей платформы
//            foreach (var loc in item.Value)
//            {
//                // Проверяем, начинается ли локация с подстроки loc (каждого из элементов списка строк)
//                if (location.Contains(loc))
//                {
//                    result.Add(item.Key); // Если да, добавляем название платформы (ключ) в список платформ, которые подойдут
//                    break; // Выходим из цикла, когда добавили платформу
//                }
//            }
//        }

//        return result; // Возвращаем список подходящих платформ
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        var advertisementPlatform = new AdvertisementPlatform();

//        // Запрашиваем у пользователя количество платформ
//        Console.Write("Введите количество платформ: ");
//        // Конвертируем строку в число (для использования в цикле)
//        var countPlatforms = Convert.ToInt32(Console.ReadLine());

//        // Цикл для ввода данных о каждой платформе
//        for (int i = 0; i < countPlatforms; i++)
//        {
//            Console.WriteLine($"Введите имя платформы {i + 1} и её локации (Например Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik)");
//            var value = Console.ReadLine();
//            advertisementPlatform.AddAdvertisementPlatform(value); // Добавляем платформу в словарь
//        }

//        // Запрашиваем у пользователя локацию для поиска
//        Console.WriteLine("Введите локацию для поиска: (Например /ru/svrd) ");
//        var locationForSearch = Console.ReadLine();

//        // Получаем список подходящих рекламных платформ
//        var advertisementPlatforms = advertisementPlatform.GetAdvertisementPlatforms(locationForSearch);

//        Console.WriteLine("Подходящие рекламные площадки:");
//        foreach (var platform in advertisementPlatforms)
//        {
//            Console.WriteLine(platform);
//        }
//    }
//}
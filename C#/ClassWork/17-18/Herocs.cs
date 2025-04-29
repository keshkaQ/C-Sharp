//internal class Program
//{
//    static void Main()
//    {
//        var hero = new Hero();

//        foreach (var expensiveStaff in hero)
//        {
//            Console.WriteLine(expensiveStaff.ToString());
//        }
//    }
//}


//public class Hero
//{
//    private List<Staff> staffs = new();
//    public Hero()
//    {
//        staffs.Add(new Staff { Title = "Staff1", CountGold = 100 });
//        staffs.Add(new Staff { Title = "Staff2", CountGold = 1000 });
//        staffs.Add(new Staff { Title = "Staff3", CountGold = 3000 });
//    }

    
//    public IEnumerator<Staff> GetEnumerator()
//    {
//        for (int i = 0; i < staffs.Count; i++)
//        {
//            if (staffs[i].CountGold >= 1000)
//                // позволяет не создавать коллекцию, а сразу вернуть элемент
//                yield return staffs[i];
//        }
//    }
//    // позволяет пробежаться по коллекции и получить элементы
//    public IEnumerator<Staff> GetExpensiveStaff()
//    {
//        // список дорогих предметов
//        var expensiveStaff = new List<Staff>();
//        for (int i = 0; i < staffs.Count; i++)
//        {
//            // если стоимость предмета больше 1000, возвращаем его
//            if (staffs[i].CountGold >= 1000)
//            {
//                expensiveStaff.Add(staffs[i]);
//            }
//        }
//        return expensiveStaff.GetEnumerator();
//    }
//}
//// инвентарь
//public class Staff
//{
//    public string Title { get; set; }
//    public int CountGold { get; set; }
//    public override string ToString()
//    {
//        return $"Title: {Title}, CountGold {CountGold}";
//    }
//}
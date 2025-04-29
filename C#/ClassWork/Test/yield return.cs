
//using System.Collections;
//using System.Drawing;

//internal class Program
//{
//    static void Main()
//    {
//        foreach (var student in GenerateStudentByYield())
//        {
//            Console.WriteLine(student.Name);
//        }
//    }
//    private static IEnumerable<Student> GetStudentsByYield()
//    {
//        // по очереди возвращает студентов на каждой итерации
//        // выделяется в памяти место под одного студента
//        yield return new Student { Name = "Max" };
//        yield return new Student { Name = "Alex" };
//        yield return new Student { Name = "Misha" };
//    }
//    // создаем массив и возвращаем сразу всех студентов
//    // выделяется память под весь массив студентов
//    private static IEnumerable<Student> GetStudents()
//    {
//        return
//        [
//            new Student { Name = "Max" },
//            new Student { Name = "Alex" },
//            new Student { Name = "Misha" },
//        ];
//    }
//    private static IEnumerable<Student> GenerateStudentByYield()
//    {
//        for (var i = 0;true ;i++)
//        {
//            yield return new Student { Name = $"Student {i}" };
//        }
//    }
//}

//public class Student
//{
//    public string Name { get; set; }
//}
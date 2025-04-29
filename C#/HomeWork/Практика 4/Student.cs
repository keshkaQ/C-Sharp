
using System.Runtime.InteropServices;

public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public List<int> Grades { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
        Console.Write("Grades: ");
        for(int i = 0; i < Grades.Count; i++)
        {
            Console.Write($" {Grades[i]}");
        }
    }
}

//using System.Diagnostics;

//var students = new List<Student>
//{
//    new Student { Id = 1, Name = "Alice" },
//    new Student { Id = 2, Name = "Bob" }
//};
//var grades = new List<Grade>
//{
//    new Grade { StudentId = 1, Subject = "Math", LetterGrade = 'A' },
//    new Grade { StudentId = 2, Subject = "Math", LetterGrade = 'B' },
//    new Grade { StudentId = 1, Subject = "Science", LetterGrade = 'A' }
//};



//var result = students.Join
//    (grades,
//    student => student.Id,
//    grade => grade.StudentId,
//    (student, grade) => new
//    { 
//        StudentName = student.Name, 
//        Grades = grade.LetterGrade,
//        Subject = grade.Subject,
//    }).ToList();


//foreach (var item in result)
//{
//    Console.WriteLine($"Name: {item.StudentName}, Subject: {item.Subject}, Grade: {item.Grades}");
//}

//public class Student
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//}


//public class Grade
//{
//    public int StudentId { get; set; }
//    public string Subject { get; set; }
//    public char LetterGrade { get; set; }
//}
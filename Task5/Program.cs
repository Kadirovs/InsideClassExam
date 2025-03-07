Student student1 = new Student(101, "###");
student1.Name = "Ali";
student1.Grade = 85;
Console.WriteLine(student1.GetStudentInfo()); 
Console.WriteLine($"Passed: {student1.IsPassed()}");

Console.WriteLine();

Student student2 = new Student(102, "###");
student2.Name = "An";
student2.Grade = 150;
Console.WriteLine(student2.GetStudentInfo());
Console.WriteLine($"Passed: {student2.IsPassed()}"); 
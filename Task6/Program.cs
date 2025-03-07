var emp1 = new Employee("Kamoliddin", 23200115, 1500m);
var emp2 = new Employee("Kadirovs", 23200114, 1800m);

Console.WriteLine(emp1==emp2);
Console.WriteLine($"Name: {emp1.FirstName}, Id: {emp1.ID}, Salary: {emp1.Salary}");
Console.WriteLine($"Name: {emp2.FirstName}, Id: {emp2.ID}, Salary: {emp2.Salary}");

public record Employee(string FirstName, int ID, decimal Salary);
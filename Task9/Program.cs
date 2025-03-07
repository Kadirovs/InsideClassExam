var emp1 = new Person("Kamoliddin", 23200115, 1500m);
var emp2 = new Person("Kadirovs", 23200114, 1800m);

Console.WriteLine(emp1==emp2);
public record Person(string FirstName, int ID, decimal Salary);
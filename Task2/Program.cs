Car car1 = new Car("Toyota", "Corolla", 2020);
car1.DisplayDetails();

Car car2 = new Car("Honda", "Civic", 2020);
car2.DisplayDetails();


public class Car
{
    public string make;
    
    public string model;
    
    public int year;

    public Car(string make, string model, int year)
    {
        this.make = make;
        this.model = model;
        this.year = year;
    }

    public void DisplayDetails()
    {
        Console.WriteLine($"{make} {model}, {year}");
    }
}
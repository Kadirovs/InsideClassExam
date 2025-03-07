public class Car
{
    public string make;
    
    public string model;
    
    public int year;

    public void DisplayDetails()
    {
        Console.WriteLine($"{make} {model}, {year}");
    }
}
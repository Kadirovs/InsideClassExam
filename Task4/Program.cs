Calculator calc = new Calculator();
Console.WriteLine(calc.Add(10, 5));
Console.WriteLine(calc.Subtract(10, 5));
Console.WriteLine(calc.Multiply(10, 5));
Console.WriteLine(calc.Divide(10, 5));


public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public int Subtract(int a, int b)
    {
        return a - b;
    }

    public int Multiply(int a, int b)
    {
        return a * b;
    }

    public double Divide(int a, int b)
    {
        if (b == 0)
        {
            Console.WriteLine("Cannot divide by zero");
        }
        // ReSharper disable once PossibleLossOfFraction
        return a / b;
    }
    
}
using System;

public class MainClass
{
    public static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Area Of equilateral triangle: " + (a * a * Math.Sqrt(3)) / 4);
        Console.WriteLine("Area of a regular hexagon: " + (3 * a * a * Math.Sqrt(3)) / 2);
    }
}
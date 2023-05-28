using System;

public class MainClass
{
    public static void Main()
    {
        double a = Convert.ToDouble(Console.ReadLine());
        double b = Convert.ToDouble(Console.ReadLine());
        double c = Convert.ToDouble(Console.ReadLine());

        double d = b * b - 4 * a * c;
        if (d < 0) {
            Console.WriteLine("There is no roots for quadratic equationn in real numbers.");
        } else if (d == 0) {
            double x = (-b / (2 * a));
            Console.WriteLine($"Quadratic equation has 1 real root: {x}.");
        } else {
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine($"Quadratic equation has 2 real roots: {x1} and {x2}.");
        }
    }
}

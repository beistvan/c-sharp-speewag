using System;

public class MainClass
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(( (n % 10) % 2 == 1 && (n % 100 / 10) % 2 == 1 && (n / 100) % 2 == 1 ) ? "Right" : "Wrong");
    }
}

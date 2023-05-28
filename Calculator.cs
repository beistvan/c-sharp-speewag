using System;

public class MainClass
{
    public static void Main()
    {
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        string c = Console.ReadLine();
        if (c == "+")
        {
            Console.WriteLine(a + b);
        }
        else if (c == "-")
        {
            Console.WriteLine(a - b);
        }
        else if (c == "*")
        {
            Console.WriteLine(a * b);
        }
        else if (c == "/")
        {
            if (b==0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine(a / b);
            }
        }
        else if (c == "%")
        {
            Console.WriteLine(a * 0.01 * b);
        }
    }
}
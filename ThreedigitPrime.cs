using System;

public class MainClass
{
    public static void Main()
    {
        int num = int.Parse(Console.ReadLine());
        if (num >= 100 && num <= 999) {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++) {
                if (num % i == 0) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) {
                Console.WriteLine("Threedigit Prime - Access Granted!");
            } else {
                Console.WriteLine("Access Denied!");
            }
        } else {
            Console.WriteLine("Access Denied!");
        }
    }
}

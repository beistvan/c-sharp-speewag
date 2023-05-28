using System;

public class MainClass
{
    public static void Main()
    {
       int n = 4;
       int popitka = 0;
       while(popitka < 4)
       {
            int gues_n = Convert.ToInt32(Console.ReadLine());
            popitka++;
            if (popitka > 3)
            {
                break;
            }
            else if (n == gues_n)
            {
                Console.WriteLine("You win!");
                break;
            }

            else if (gues_n != n)
            {

                if (popitka == 3)
                {
                    Console.WriteLine("Wrong guess...");
                }
                else
                {
                    Console.WriteLine($"Your guess is right, tryout nr. {popitka + 1}.");
                }
            }

        }
        if (popitka > 4)
        {
            Console.WriteLine("Wrong guess...");
        }
    }
}
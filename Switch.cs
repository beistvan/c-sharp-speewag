using System;

public class MainClass
{
    public static void Main()
    {
        string s = Console.ReadLine();
        switch (s)
        {
            case "Marlono Brando":
                Console.WriteLine("Stright To Heaven.");
                break;
            case "Bravl Starts":
                Console.WriteLine("No Way To Heaven.");
                break;
            default:
                Console.WriteLine("Wrong Sentence.");
                break;
        }
    }
}

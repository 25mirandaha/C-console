

using System.Globalization;
using System.Security.Authentication;

class Loops
{
    public static void ForLoops()
    {
        for(int i = 0; i <= 10; i++)
        {
            Console.WriteLine("Iterarion: " + i);
        }
    }

    public static void EvenLoop()
    {
        for(int i = 1; i <= 20; i++)
        {
            if(i % 2 ==1)
            {
            Console.WriteLine(i);
            }
        } 
    }

    public static void  HealthLoop()
    {
        int Health = 100;
        while(Health >= 0)
        {
            Console.WriteLine("Player is alive with health: " + Health);
            Health -= 10;
        }
    }

    public static void NestedLoops()
    {
        for(int i = 0; i <= 2; i++)
        {
            Console.WriteLine("Iterarion: i " + i);
            for (int j = 0; j <= 2; j++)
            {
                Console.WriteLine("     Iteration: j " + j);
                for (int k = 0; k <= 2; k++)
                {
                    Console.WriteLine("         Iteration: k " + k);
                }
            }
        }
    }
    public static void dowhile()
    {
        int number;
        do
        {
            Console.WriteLine("Enter a number greater than 0");
            number = Convert.ToInt32(Console.ReadLine());
        }
        while (number <= 0);
        {
            Console.WriteLine("You entered: " + number); 
        }
    }
}
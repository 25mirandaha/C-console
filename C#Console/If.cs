

class If 
{
    public static void Numbers(int number)
    {
            if(number > 0)
            {
                Console.WriteLine("Your number is positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("Your number is negative.");
            }
            else
            {
                Console.WriteLine("Your Number is zero");
            }
    }

    public static void Health(int Health)
    {
        if(Health > 75)
        {
            Console.WriteLine("Your Health is Great!!!");
        }
        else if (50 < Health && Health <= 75)
        {
            Console.WriteLine("Use some meds bro");
        }
        else if (1 <= Health && Health <= 50)
        {
            Console.WriteLine("HEAL!!!");
        }
        else
        {
            Console.WriteLine("Skill issue");
        }
    }
}
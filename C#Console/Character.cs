class Character
{
    public string Name = "Joe";
    public int Health;
    public int Strength;

    public static void Players()
    {
        Character Player1 = new Character();
        Player1.Name = "Hector";
        Player1.Health = 100;
        Player1.Strength = 34;

        Console.WriteLine("Player1 Name: " + Player1.Name);

        Character Player2 = new Character();
        Player2.Name = "Tom";
        Player2.Health = 65;
        Player2.Strength = 68;

        Console.WriteLine("Player2 Name: " + Player2.Name);
    }
}
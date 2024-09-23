

using System.ComponentModel;

class Dictionary1
{
    public static void Dict1(string[]args)
    {
        Dictionary<string, string> phonebook = new Dictionary<string, string>();
        phonebook.Add("Alice", "123-456-7890");
        phonebook.Add("Bob", "321-454-2135");
        
        Console.WriteLine(phonebook["Alice"]);
    }

    public static void Dict2(string[] args)
    {
        Dictionary<string, int> inventory = new Dictionary<string, int>();
        inventory.Add("Apples", 50);
        inventory.Add("Bananas", 30);
        inventory.Add("Mango", 30);
        inventory.Add("Grapes", 12);



        foreach(KeyValuePair<string, int> item in inventory)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
}
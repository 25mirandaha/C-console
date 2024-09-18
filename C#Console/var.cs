class Var
{
    public static void MyVar()
    {
        string myName = "Hector";
        Console.WriteLine(myName);
    }

    public static void DataType()
    {
        string firstName = "Hector";
        string lastName = "Miranda";
        string WholeName = firstName + " " + lastName;
        int age = 17;
        float GPA = 3.3f;
        double height = 6.1;
        decimal dollar =10.35m;
        bool is_teacher = true;
        char Grade = 'F';


        //Console.WriteLine(firstName);
        //Console.WriteLine(lastName);
        Console.WriteLine(WholeName);
        Console.WriteLine(age);
        Console.WriteLine(GPA);
        Console.WriteLine(height);
        Console.WriteLine(dollar);
        Console.WriteLine(is_teacher);
        Console.WriteLine(Grade);
    }
}
class Menu
{
    public static void ShowMenu()
    {
        Console.WriteLine("Welcome to Habit Tracker!");
        Console.WriteLine("==========================");
        Console.WriteLine();
        Console.WriteLine("1. Add Habit");
        Console.WriteLine("2. View Habits");
        Console.WriteLine("3. Exit");
        Console.WriteLine();
        Console.WriteLine("Choose an option: ");
    }

    public static int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.WriteLine("Choice must be a number");
            Console.WriteLine("Please try again");
            Console.WriteLine();
        }
        return choice;
    }

    public static bool exitApp()
    {
        Console.WriteLine();
        Console.WriteLine("See you next time!");
        Console.WriteLine("==========================");
        Console.WriteLine();
        
        return false;
    }
}
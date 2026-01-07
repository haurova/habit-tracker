using System;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to Habit Tracker!");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.WriteLine("1. Add Habit");
            Console.WriteLine("2. View Habits");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose an option: ");
            // Start by creating a simple menu system


            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("You chose: " + choice);
        }
    }
}

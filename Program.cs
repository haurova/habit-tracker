using System;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> habits = new List<string>();

            Console.WriteLine("Welcome to Habit Tracker!");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.WriteLine("1. Add Habit");
            Console.WriteLine("2. View Habits");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Choose an option: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Choice must be a number");
                return;
            }
            
            Console.WriteLine("You chose: " + choice);

            if (choice == 1)
            {
                Console.WriteLine("You chose to add a habit");
                string? habitName = string.Empty;

                while (habitName != "exit")
                {
                    Console.WriteLine("Enter the name of the habit (or 'exit' to finish): ");
                    habitName = Console.ReadLine();
                    if (!string.IsNullOrEmpty(habitName))
                    {
                        habits.Add(habitName);
                    }
                    else
                    {
                        Console.WriteLine("Habit name cannot be empty");
                    }
                }
                habits.Remove("exit");
                Console.WriteLine("Habits " + string.Join(", ", habits) + " added successfully");


            }
            else if (choice == 2)
            {
                Console.WriteLine("You chose to view habits");
                Console.WriteLine("Habits: " + string.Join(", ", habits));
                Console.WriteLine("Total habits: " + habits.Count);
            }
            else if (choice == 3)
            {
                Console.WriteLine("You chose to exit");
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
    }
}

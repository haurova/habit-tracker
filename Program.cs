using System;

namespace HabitTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> habits = new List<string>();
            bool appIsOn = true;
            int choice;

            while (appIsOn)
            {

                Console.WriteLine("Welcome to Habit Tracker!");
                Console.WriteLine("==========================");
                Console.WriteLine();

                Console.WriteLine("1. Add Habit");
                Console.WriteLine("2. View Habits");
                Console.WriteLine("3. Exit");
                Console.WriteLine();
                Console.WriteLine("Choose an option: ");

                while (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("==========================");
                    Console.WriteLine();
                    Console.WriteLine("Choice must be a number");
                    Console.WriteLine("Please try again");
                    Console.WriteLine();
                }

                Console.WriteLine("You chose: " + choice);
                Console.WriteLine();

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
                    Console.WriteLine("Habits " + string.Join(", ", habits) + " added successfully. Please choose another option.");
                    Console.WriteLine();
                    Console.WriteLine("==========================");
                    Console.WriteLine();


                }
                else if (choice == 2)
                {
                    Console.WriteLine("You chose to view habits");
                    Console.WriteLine("Habits: " + string.Join(", ", habits));
                    Console.WriteLine("Total habits: " + habits.Count);
                }
                else if (choice == 3)
                {
                    Console.WriteLine();
                    Console.WriteLine("See you next time!");
                    Console.WriteLine("==========================");
                    Console.WriteLine();
                    appIsOn = false;
                }
                else
                {
                    Console.WriteLine("Invalid choice, please try again");
                    Console.WriteLine();
                    Console.WriteLine("==========================");
                    Console.WriteLine();
                }
            }
        }
    }
}

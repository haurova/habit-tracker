using System;

namespace HabitTracker
{

    class Program
    {
        static void Main(string[] args)
        {
            Habit habit = new Habit();
            bool appIsOn = true;


            while (appIsOn)
            {

                Menu.ShowMenu();
                int choice = Menu.GetUserChoice();

                Console.WriteLine("You chose: " + choice);
                Console.WriteLine();

                if (choice == 1)
                {
                    Console.WriteLine("You chose to add a habit");
                    habit.AddHabit();


                }
                else if (choice == 2)
                {
                    habit.ShowHabitsList();
                }
                else if (choice == 3)
                {
                    habit.RemoveHabit();
                }
                else if (choice == 4)
                {
                    appIsOn = Menu.exitApp();
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

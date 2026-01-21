namespace HabitTracker
{
    public class Habit
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        List<string> habits = new List<string>();



        public void AddHabit()
        {
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

        public void ShowHabitsList()
        {
            Console.WriteLine("You chose to view habits");
            Console.WriteLine("Habits: " + string.Join(", ", habits));
            Console.WriteLine("Total habits: " + habits.Count);
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine();
        }
    
    }
}
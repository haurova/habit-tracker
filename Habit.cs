namespace HabitTracker
{
    public class Habit
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

        List<Habit> habits = new List<Habit>();

        public void AddHabit()
        {
            string? habitName = string.Empty;

            while (habitName != "exit")
            {
                Console.WriteLine("Enter the name of the habit (or 'exit' to finish): ");
                habitName = Console.ReadLine();
                if (!string.IsNullOrEmpty(habitName) && !habitName.Equals("exit"))
                {
                    Habit habit = new Habit();
                    habit.Name = habitName;
                    habit.CreatedDate = DateTime.Now;
                    habits.Add(habit);
                }
                else if (!string.IsNullOrEmpty(habitName) && habitName.Equals("exit"))
                {
                    Console.WriteLine();
                    Console.WriteLine("Returning to the menu");
                    Console.WriteLine();
                    Console.WriteLine("==========================");
                    Console.WriteLine();                    
                }
                else
                {
                    Console.WriteLine("Habit name cannot be empty");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Habits " + string.Join(", ", habits.Select(h => h.Name)) + " added successfully. Exiting to the menu.");
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine();
        }

        public void ShowHabitsList()
        {
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine();
            Console.WriteLine("You chose to view habits");
            Console.WriteLine();           


            foreach (Habit habit in habits)
            {
                Console.WriteLine("Habit " + habit.Name + " was added at " + habit.CreatedDate);
            }

            Console.WriteLine();           
            Console.WriteLine("Total habits: " + habits.Count);
            Console.WriteLine();
            Console.WriteLine("==========================");
            Console.WriteLine();
        }

        public void RemoveHabit()
        {
            string? habitName = string.Empty;

            while (habitName != "cancel")
            {
                Console.WriteLine("Enter the name of the habit to remove or type 'cancel' to exit to the menu");
                Console.WriteLine();
                Console.WriteLine("==========================");
                Console.WriteLine();
                habitName = Console.ReadLine();

                Habit found = habits.FirstOrDefault(h => h.Name == habitName);
                if (found != null && habitName != "cancel")
                {
                    Console.WriteLine();
                    Console.WriteLine($"Habit '{found.Name}' found and removed.");
                    Console.WriteLine();
                    habits.Remove(found);
                }
                else if (found == null && habitName == "cancel")
                {
                    Console.WriteLine("Returning to the menu");
                    Console.WriteLine();
                    Console.WriteLine("==========================");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"Habit {habitName} is not found, please try again or type 'cancel'");
                    Console.WriteLine();

                }
            }
            }
        }
    
    }

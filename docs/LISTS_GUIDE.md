# Complete Guide to Lists in C# - For Week 5

## What is a List?

A `List<T>` is a collection that can hold multiple items of the same type. Think of it like a shopping list - you can add items, remove items, and see how many items you have.

**Key Points:**
- `T` is the type of items the list holds (e.g., `string`, `int`, `Habit`)
- Lists can grow and shrink dynamically (unlike arrays)
- Items are stored in order (first added = first position)
- Lists start empty (0 items)

---

## Creating Lists

### Basic Syntax:
```csharp
List<Type> variableName = new List<Type>();
```

### Examples:
```csharp
List<string> names = new List<string>();           // List of strings
List<int> numbers = new List<int>();               // List of integers
List<Habit> habits = new List<Habit>();           // List of Habit objects
```

### Shorter Syntax (C# 9+):
```csharp
List<string> names = new();                       // Type inferred
```

---

## Essential List Operations

### 1. Adding Items

**Add a single item:**
```csharp
List<string> habits = new List<string>();
habits.Add("Exercise");        // Adds "Exercise" to the end
habits.Add("Read");            // Adds "Read" to the end
// List now contains: ["Exercise", "Read"]
```

**Add multiple items at once:**
```csharp
habits.AddRange(new[] { "Meditate", "Code" });
// List now contains: ["Exercise", "Read", "Meditate", "Code"]
```

**Add a Habit object:**
```csharp
List<Habit> habits = new List<Habit>();
Habit habit1 = new Habit();
habit1.Name = "Exercise";
habit1.CreatedDate = DateTime.Now;
habits.Add(habit1);
```

---

### 2. Accessing Items

**Get item by index (position):**
```csharp
List<string> habits = new List<string> { "Exercise", "Read", "Code" };
string first = habits[0];      // "Exercise" (first item, index 0)
string second = habits[1];     // "Read" (second item, index 1)
string last = habits[2];       // "Code" (third item, index 2)
```

**Important:** Indexes start at 0, not 1!

**Get item count:**
```csharp
int count = habits.Count;      // Returns 3
```

**Check if list is empty:**
```csharp
if (habits.Count == 0)
{
    Console.WriteLine("No habits yet!");
}
```

---

### 3. Removing Items

**Remove by value:**
```csharp
List<string> habits = new List<string> { "Exercise", "Read", "Code" };
habits.Remove("Read");        // Removes "Read"
// List now contains: ["Exercise", "Code"]
```

**Remove by index:**
```csharp
habits.RemoveAt(0);           // Removes first item ("Exercise")
// List now contains: ["Code"]
```

**Remove all items:**
```csharp
habits.Clear();               // List is now empty
```

**Remove if condition is true:**
```csharp
habits.RemoveAll(h => h == "Code");  // Removes all items equal to "Code"
```

---

### 4. Checking if Item Exists

```csharp
List<string> habits = new List<string> { "Exercise", "Read", "Code" };
bool exists = habits.Contains("Read");    // Returns true
bool notExists = habits.Contains("Sleep"); // Returns false
```

---

### 5. Finding Items

**Find first matching item:**
```csharp
List<Habit> habits = new List<Habit>();
Habit found = habits.FirstOrDefault(h => h.Name == "Exercise");
if (found != null)
{
    Console.WriteLine($"Found: {found.Name}");
}
```

**Find index of item:**
```csharp
int index = habits.IndexOf("Exercise");    // Returns 0 if found, -1 if not found
```

---

## Iterating Through Lists

### Method 1: foreach Loop (Most Common)
```csharp
List<string> habits = new List<string> { "Exercise", "Read", "Code" };

foreach (string habit in habits)
{
    Console.WriteLine(habit);
}
// Output:
// Exercise
// Read
// Code
```

**With Habit objects:**
```csharp
List<Habit> habits = new List<Habit>();

foreach (Habit habit in habits)
{
    Console.WriteLine($"Name: {habit.Name}, Created: {habit.CreatedDate}");
}
```

### Method 2: for Loop (When you need index)
```csharp
for (int i = 0; i < habits.Count; i++)
{
    Console.WriteLine($"{i + 1}. {habits[i]}");
}
```

### Method 3: foreach with LINQ (Advanced)
```csharp
habits.ForEach(h => Console.WriteLine(h));
```

---

## Converting Lists to Strings

**Join all items with separator:**
```csharp
List<string> habits = new List<string> { "Exercise", "Read", "Code" };
string joined = string.Join(", ", habits);
// Result: "Exercise, Read, Code"
```

**For Habit objects, you need to extract properties:**
```csharp
List<Habit> habits = new List<Habit>();
// Option 1: Join just the names
string names = string.Join(", ", habits.Select(h => h.Name));

// Option 2: Custom format
foreach (Habit habit in habits)
{
    Console.WriteLine($"{habit.Name} (Created: {habit.CreatedDate})");
}
```

---

## Working with List<Habit> Instead of List<string>

### The Problem You're Solving:
You currently have:
```csharp
List<string> habits = new List<string>();
habits.Add("Exercise");  // Just a string
```

You need:
```csharp
List<Habit> habits = new List<Habit>();
Habit habit = new Habit();
habit.Name = "Exercise";
habit.CreatedDate = DateTime.Now;
habits.Add(habit);  // A Habit object with properties
```

### Step-by-Step Migration:

**Step 1: Change the list type**
```csharp
// OLD:
List<string> habits = new List<string>();

// NEW:
List<Habit> habits = new List<Habit>();
```

**Step 2: When adding, create Habit objects**
```csharp
// OLD:
habits.Add(habitName);  // Just a string

// NEW:
Habit newHabit = new Habit();
newHabit.Name = habitName;
newHabit.CreatedDate = DateTime.Now;
habits.Add(newHabit);
```

**Step 3: When displaying, access properties**
```csharp
// OLD:
Console.WriteLine("Habits: " + string.Join(", ", habits));

// NEW:
foreach (Habit habit in habits)
{
    Console.WriteLine($"- {habit.Name} (Created: {habit.CreatedDate:yyyy-MM-dd})");
}
```

**Step 4: When removing, find the Habit object first**
```csharp
// OLD:
habits.Remove("Exercise");  // Remove by string value

// NEW:
Habit toRemove = habits.FirstOrDefault(h => h.Name == "Exercise");
if (toRemove != null)
{
    habits.Remove(toRemove);
}
```

---

## Common Patterns for Your Habit Tracker

### Pattern 1: Add a Habit
```csharp
public void AddHabit(string habitName)
{
    Habit newHabit = new Habit();
    newHabit.Name = habitName;
    newHabit.CreatedDate = DateTime.Now;
    habits.Add(newHabit);
}
```

### Pattern 2: Display All Habits
```csharp
public void ShowHabitsList()
{
    if (habits.Count == 0)
    {
        Console.WriteLine("No habits yet!");
        return;
    }
    
    Console.WriteLine("Your Habits:");
    for (int i = 0; i < habits.Count; i++)
    {
        Habit habit = habits[i];
        Console.WriteLine($"{i + 1}. {habit.Name} (Created: {habit.CreatedDate:yyyy-MM-dd})");
    }
}
```

### Pattern 3: Find a Habit by Name
```csharp
public Habit? FindHabit(string name)
{
    return habits.FirstOrDefault(h => h.Name == name);
}
```

### Pattern 4: Remove a Habit
```csharp
public bool RemoveHabit(string name)
{
    Habit? habit = habits.FirstOrDefault(h => h.Name == name);
    if (habit != null)
    {
        habits.Remove(habit);
        return true;  // Successfully removed
    }
    return false;  // Not found
}
```

### Pattern 5: Count Habits
```csharp
public int GetHabitCount()
{
    return habits.Count;
}
```

---

## Important Notes

1. **Indexes start at 0:** First item is at index 0, not 1
2. **Null safety:** When using `FirstOrDefault()`, always check for `null` before using the result
3. **Count vs Length:** Lists use `.Count`, arrays use `.Length`
4. **Type safety:** `List<Habit>` can only contain `Habit` objects, not strings or other types
5. **Order matters:** Items stay in the order you add them (unless you sort them)

---

## Quick Reference Cheat Sheet

```csharp
// Create
List<Habit> habits = new List<Habit>();

// Add
habits.Add(newHabit);

// Access
Habit first = habits[0];
int count = habits.Count;

// Remove
habits.Remove(habit);
habits.RemoveAt(0);

// Check
bool exists = habits.Contains(habit);
bool isEmpty = habits.Count == 0;

// Iterate
foreach (Habit habit in habits) { ... }

// Find
Habit found = habits.FirstOrDefault(h => h.Name == "Exercise");
```

---

## Practice Exercise

Try to refactor your current code:

1. Change `List<string> habits` to `List<Habit> habits`
2. Update `AddHabit()` to create `Habit` objects
3. Update `ShowHabitsList()` to display `Habit` properties
4. Test that everything still works!

Good luck! 🚀

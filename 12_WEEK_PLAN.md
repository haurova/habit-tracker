# 12-Week C# Learning Plan: Building a Habit Tracker

## Overview
This plan will guide you through learning C# from scratch while building a console-based habit tracker application. By the end, you'll have a working habit tracker and a solid foundation in C# programming.

---

## Week 1: C# Fundamentals & Project Setup
**Goal:** Set up development environment and understand basic C# syntax

### Learning Topics:
- Install .NET SDK
- Understand C# program structure (namespace, class, Main method)
- Variables and data types (int, string, bool, DateTime)
- Console input/output (ReadLine, WriteLine)
- Basic operators and expressions

### Practice Exercise:
- Create a simple "Hello World" program
- Build a program that asks for your name and displays a greeting
- Experiment with different data types

### Habit Tracker Feature:
- Set up project structure
- Create a simple menu that displays options (no functionality yet)
- Learn how to read user input

### Deliverable:
A console app with a basic menu system that asks the user what they want to do (e.g., "1. Add habit", "2. View habits", "3. Exit")

---

## Week 2: Control Flow & Loops
**Goal:** Make your program interactive with conditional logic

### Learning Topics:
- if/else statements
- switch/case statements
- while loops
- for loops
- do-while loops

### Practice Exercise:
- Build a number guessing game
- Create a simple calculator that can do basic math operations

### Habit Tracker Feature:
- Implement menu navigation (user can select options)
- Add basic validation (e.g., "Please enter a valid option")
- Create a loop so the menu keeps appearing until user exits

### Deliverable:
An interactive menu that loops until the user chooses to exit

---

## Week 3: Methods & Functions
**Goal:** Organize code into reusable functions

### Learning Topics:
- Method declaration and parameters
- Return types (void, int, string, etc.)
- Method overloading
- Passing parameters by value vs reference

### Practice Exercise:
- Refactor previous programs to use methods
- Create a utility class with helper methods (e.g., input validation)

### Habit Tracker Feature:
- Create separate methods for each menu option
- Build helper methods for input validation
- Organize code into logical functions (e.g., `ShowMenu()`, `GetUserChoice()`, `AddHabit()`, etc.)

### Deliverable:
A well-organized program where each feature is in its own method

---

## Week 4: Collections & Arrays
**Goal:** Store and manipulate multiple habits

### Learning Topics:
- Arrays
- Lists<T>
- Dictionary<TKey, TValue>
- Iterating through collections (foreach loops)
- LINQ basics (Select, Where, FirstOrDefault)

### Practice Exercise:
- Create programs that work with lists of numbers, names, etc.
- Practice filtering and searching collections

### Habit Tracker Feature:
- Store habits in a List<string>
- Add functionality to view all habits
- Add functionality to remove a habit
- Count how many habits you have

### Deliverable:
A habit tracker that can add, view, and delete habits from a list

---

## Week 5: Classes & Objects (OOP Part 1)
**Goal:** Model real-world entities using classes

### Learning Topics:
- Class definition
- Objects and instances
- Fields and properties
- Constructors
- Access modifiers (public, private, protected)

### Practice Exercise:
- Create a Person class with name, age properties
- Create a BankAccount class with balance and deposit/withdraw methods

### Habit Tracker Feature:
- Create a `Habit` class with properties:
  - Name (string)
  - Description (string)
  - CreatedDate (DateTime)
- Refactor your list to store `Habit` objects instead of strings
- Update all methods to work with Habit objects

### Deliverable:
A habit tracker using a proper Habit class with properties

---

## Week 6: Object-Oriented Programming (OOP Part 2)
**Goal:** Build more complex relationships between objects

### Learning Topics:
- Encapsulation
- Static members
- Value types vs reference types
- Nullable types
- String formatting and interpolation

### Practice Exercise:
- Create classes with private fields and public properties
- Work with nullable types and null checking

### Habit Tracker Feature:
- Create a `HabitTracker` class to manage the collection of habits
- Add a `HabitRecord` class to track when a habit was completed
- Implement relationship: Habit has many HabitRecords
- Show habit completion dates

### Deliverable:
A more structured application with multiple related classes

---

## Week 7: File I/O & Persistence
**Goal:** Save and load data from files

### Learning Topics:
- File class and FileInfo
- StreamReader and StreamWriter
- Working with file paths
- Exception handling basics (try-catch)
- JSON serialization (using System.Text.Json)

### Practice Exercise:
- Create a program that writes/reads text files
- Build a simple note-taking app that saves to files

### Habit Tracker Feature:
- Save habits to a JSON file when program exits
- Load habits from JSON file when program starts
- Handle cases where file doesn't exist yet
- Persist habit completion records

### Deliverable:
A habit tracker that saves your data between program runs

---

## Week 8: Exception Handling & Validation
**Goal:** Make your application robust and error-resistant

### Learning Topics:
- try-catch-finally blocks
- Different exception types
- Throwing exceptions
- Input validation techniques
- Guard clauses

### Practice Exercise:
- Practice handling common exceptions (FormatException, FileNotFoundException, etc.)
- Create robust input validation methods

### Habit Tracker Feature:
- Add comprehensive input validation
- Handle file I/O errors gracefully
- Validate dates and prevent invalid data entry
- Add user-friendly error messages

### Deliverable:
A robust application that handles errors gracefully

---

## Week 9: Advanced C# Features
**Goal:** Use modern C# features to improve your code

### Learning Topics:
- LINQ (advanced queries)
- Lambda expressions
- Extension methods
- var keyword and type inference
- DateTime and TimeSpan manipulation

### Practice Exercise:
- Use LINQ to filter and transform data
- Create extension methods for common operations

### Habit Tracker Feature:
- Use LINQ to query habits (e.g., find habits created this week)
- Calculate streaks (days in a row a habit was completed)
- Show statistics: total habits, completion rate, longest streak
- Add date filtering (show completions for last week, month, etc.)

### Deliverable:
A habit tracker with statistics and advanced querying capabilities

---

## Week 10: Data Structures & Algorithms
**Goal:** Optimize your application and learn efficient data handling

### Learning Topics:
- HashSet<T>
- Stack<T> and Queue<T>
- Sorting algorithms (basic)
- Search algorithms (basic)
- Performance considerations

### Practice Exercise:
- Use different collections for different scenarios
- Practice searching and sorting

### Habit Tracker Feature:
- Optimize habit lookup
- Add ability to search habits by name
- Sort habits by various criteria (name, date created, completion rate)
- Track completion streaks efficiently

### Deliverable:
An optimized habit tracker with search and sort features

---

## Week 11: Refactoring & Best Practices
**Goal:** Clean up code and follow C# conventions

### Learning Topics:
- Code organization and namespaces
- XML documentation comments
- Naming conventions
- Single Responsibility Principle
- DRY (Don't Repeat Yourself) principle

### Practice Exercise:
- Refactor old code to follow best practices
- Add documentation to your code

### Habit Tracker Feature:
- Organize code into multiple files/namespaces
- Add XML comments to public methods
- Refactor duplicate code
- Ensure consistent coding style
- Add a settings/config file for customization

### Deliverable:
A clean, well-documented, and maintainable codebase

---

## Week 12: Final Features & Polish
**Goal:** Complete your habit tracker with advanced features

### Learning Topics:
- Events and delegates (intro)
- Async programming basics (if time permits)
- Unit testing basics (optional)
- Packaging and distribution

### Practice Exercise:
- Add final features you want
- Create a simple test project

### Habit Tracker Feature:
- Add reminder notifications (optional)
- Export data to CSV
- Add data visualization (ASCII charts showing streak history)
- Create a README with instructions
- Add help/documentation within the app
- Polish user interface and messages

### Final Deliverable:
A complete, polished habit tracker application with:
- Add/Edit/Delete habits
- Mark habits as complete
- View completion history
- Track streaks
- View statistics
- Data persistence
- Error handling
- Clean, documented code

---

## Resources for Learning C#

### Official Documentation:
- [Microsoft C# Documentation](https://learn.microsoft.com/en-us/dotnet/csharp/)
- [.NET Documentation](https://learn.microsoft.com/en-us/dotnet/)

### Recommended Learning Path:
1. **Microsoft Learn**: Free C# courses with hands-on exercises
2. **YouTube**: "C# Tutorial" playlists for visual learners
3. **Books**: "C# in Depth" by Jon Skeet (advanced), "Head First C#" for beginners

### Tools You'll Need:
- **.NET SDK** (latest LTS version)
- **Visual Studio Code** or **Visual Studio** (IDE)
- **Git** (for version control)

---

## Tips for Success

1. **Code Daily**: Even 30 minutes of practice helps
2. **Type Everything**: Don't copy-paste; typing helps you learn
3. **Experiment**: Try modifying code to see what happens
4. **Ask Questions**: Use Stack Overflow, Reddit (r/csharp), or Discord communities
5. **Read Error Messages**: They're actually helpful once you understand them
6. **Use Version Control**: Commit your code regularly to track progress
7. **Build Projects**: The habit tracker is great, but build other small projects too

---

## Project Structure (by Week 12)

```
habit-tracker/
├── HabitTracker/
│   ├── Models/
│   │   ├── Habit.cs
│   │   ├── HabitRecord.cs
│   │   └── HabitTracker.cs
│   ├── Services/
│   │   ├── FileService.cs
│   │   └── StatisticsService.cs
│   ├── UI/
│   │   └── Menu.cs
│   └── Program.cs
├── data/
│   └── habits.json
└── README.md
```

---

## Milestones Checklist

- [ ] Week 1: Basic menu works
- [ ] Week 2: Interactive menu with validation
- [ ] Week 3: Code organized into methods
- [ ] Week 4: Can add/view/delete habits
- [ ] Week 5: Using Habit class
- [ ] Week 6: Multiple classes working together
- [ ] Week 7: Data persists between runs
- [ ] Week 8: Robust error handling
- [ ] Week 9: Statistics and streaks working
- [ ] Week 10: Search and sort implemented
- [ ] Week 11: Clean, documented code
- [ ] Week 12: Complete, polished application

---

Good luck on your C# learning journey! 🚀

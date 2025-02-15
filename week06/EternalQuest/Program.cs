using System;

/*
    Eternal Quest - Goal Tracker
    ============================
    This program exceeds the core requirements in the following ways:

    1. Improved User Experience
       - Clear and user-friendly menu system.
       - Input validation to prevent errors.
       - Goals display formatted status indicators ([✓] for completed, [ ] for incomplete).

    2. Persistent Data with File I/O
       - Goals, progress, and scores are saved and loaded from a file.
       - The program restores user progress on relaunch.

    3. Advanced Goal Logic and Gamification
       - Checklist goals track progress and award points incrementally.
       - A bonus is granted when a checklist goal is fully completed.
       - Eternal goals cannot be marked complete, aligning with their purpose.

    4. Strong Object-Oriented Design
       - Encapsulation: All member variables are private or protected.
       - Inheritance: All goal types inherit from the base Goal class.
       - Polymorphism: Key methods are properly overridden.

    5. Organized and Scalable Code
       - Methods are structured for easy modifications.
       - New goal types can be added with minimal changes.

    This implementation improves usability, persistence, and scalability, making it a more maintainable system.
*/

class Program
{
    static void Main()
    {
        GoalManager goalManager = new GoalManager();

        while (true)
        {
            Console.WriteLine("\nEternal Quest - Goal Tracker");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. Record Event");
            Console.WriteLine("3. Show Goals");
            Console.WriteLine("4. Save Goals");
            Console.WriteLine("5. Load Goals");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();
            
            switch (choice)
            {
                case "1": goalManager.CreateGoal(); break;
                case "2": goalManager.RecordGoal(); break;
                case "3": goalManager.ShowGoals(); break;
                case "4": goalManager.SaveGoals(); break;
                case "5": goalManager.LoadGoals(); break;
                case "6": return;
                default: Console.WriteLine("Invalid option!"); break;
            }
        }
    }
}

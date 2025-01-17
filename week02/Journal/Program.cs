using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        
        while (true)
        {
            Console.WriteLine("1. Add Entry");
            Console.WriteLine("2. Display Entries");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter the date (yyyy-mm-dd): ");
                DateTime date = DateTime.Parse(Console.ReadLine());

                Console.Write("Enter your entry: ");
                string text = Console.ReadLine();

                Entry entry = new Entry(date, text);
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayEntries();
            }
            else if (choice == "3")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid option. Try again.");
            }
        }
    }
}

/*
   Exceeding Requirements:
   1. The program supports user-defined scriptures, allowing them to input their own text and save it to a file.
   2. It supports a library of predefined scriptures.
   3. Users can choose a random scripture to memorize.
   4. Scriptures are stored in a text file for persistence.
   5. Users can select a specific scripture to memorize from a numbered list.
*/

using System;
using System.Collections.Generic;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        List<Scripture> scriptures = new List<Scripture>
        {
            new Scripture(new Reference("Proverbs", 3, "5", "6"), "Trust in the Lord with all your heart and lean not on your own understanding."),
            new Scripture(new Reference("John", 3, "16"), "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life."),
            new Scripture(new Reference("Philippians", 4, "13"), "I can do all this through him who gives me strength."),
            new Scripture(new Reference("Psalm", 23, "1", "2"), "The Lord is my shepherd, I lack nothing. He makes me lie down in green pastures."),
            new Scripture(new Reference("Isaiah", 41, "10"), "So do not fear, for I am with you; do not be dismayed, for I am your God. I will strengthen you and help you; I will uphold you with my righteous right hand."),
            new Scripture(new Reference("Romans", 8, "28"), "And we know that in all things God works for the good of those who love him, who have been called according to his purpose."),
        };

        Scripture scripture;

        Console.WriteLine("Welcome to the Scripture Memorizer!");
        Console.WriteLine("Would you like to (1) use a predefined scripture, (2) write your own scripture, or (3) choose a random scripture?");
        string choice = Console.ReadLine();

        if (choice == "2")
        {
            Console.WriteLine("Enter the book name:");
            string book = Console.ReadLine();

            Console.WriteLine("Enter the chapter number:");
            int chapter = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the verse(s) (e.g., '5' or '5-6'):");
            string verses = Console.ReadLine();

            Console.WriteLine("Enter the scripture text:");
            string text = Console.ReadLine();

            Reference reference = new Reference(book, chapter, verses);
            scripture = new Scripture(reference, text);

            File.AppendAllText("scriptures.txt", $"{reference}\n{text}\n\n");
            Console.WriteLine("Your scripture has been saved to scriptures.txt");
        }
        else if (choice == "3")
        {
            Random random = new Random();
            scripture = scriptures[random.Next(scriptures.Count)];
        }
        else
        {
            Console.WriteLine("Choose a scripture by number:");
            for (int i = 0; i < scriptures.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {scriptures[i].ToString().Split('\n')[0]}");
            }
            int selected = int.Parse(Console.ReadLine()) - 1;
            scripture = scriptures[Math.Max(0, Math.Min(selected, scriptures.Count - 1))];
        }

        Console.Clear();
        Console.WriteLine(scripture);

        while (true)
        {
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                break;
            }

            scripture.HideRandomWords();
            Console.Clear();
            Console.WriteLine(scripture);

            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Well done!");
                break;
            }
        }
    }
}

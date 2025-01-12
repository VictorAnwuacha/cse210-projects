using System;

class Program
{
    static void Main(string[] args)
    {
        // Random number generator
        Random randomGenerator = new Random();
        string playAgain;

        do
        {
            // Step 1: Generate the magic number
            int magicNumber = randomGenerator.Next(1, 101);
            int guess = -1; // Initialize with a value that won't match the magic number
            int attempts = 0;

            Console.WriteLine("Welcome to 'Guess My Number'!");

            // Step 2: Game Loop
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();
                guess = int.Parse(input);
                attempts++;

                if (guess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {attempts} attempts.");
                }
            }

            // Step 3: Ask if they want to play again
            Console.Write("Do you want to play again (yes/no)? ");
            playAgain = Console.ReadLine().ToLower();

        } while (playAgain == "yes");

        Console.WriteLine("Thanks for playing! Goodbye.");
    }
}

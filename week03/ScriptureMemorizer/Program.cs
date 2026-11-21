
using System;

class Program
{
    static void Main(string[] args)
    {
        // EXCEEDING REQUIREMENTS:
        // The program tracks and displays the number of visible words remaining.
        // It also selects only visible words when hiding random words,
        // preventing previously hidden words from being selected again.

        Reference reference = new Reference("Proverbs", 3, 5, 6);

        string text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";

        Scripture scripture = new Scripture(reference, text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine($"Words remaining: {scripture.GetVisibleWordCount()}");

        Console.WriteLine();
        Console.Write("Press Enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine($"Words remaining: {scripture.GetVisibleWordCount()}");

            if (scripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine();
            Console.Write("Press Enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();
        }
    }
}

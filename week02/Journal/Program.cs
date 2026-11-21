using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal myJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();

        string choice = "0";

        while (choice != "5")
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
                if (choice == "1")
{
                Entry myEntry = new Entry();

                myEntry._date = DateTime.Now.ToShortDateString();
                myEntry._promptText = promptGenerator.GetRandomPrompt();

                Console.WriteLine(myEntry._promptText);
                Console.Write("> ");
                myEntry._entryText = Console.ReadLine();

                myJournal.AddEntry(myEntry);

                Console.WriteLine("Entry added successfully!");
}
            else if (choice == "2")
            {
                myJournal.DisplayAll();
            }

            else if (choice == "3")
{
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                myJournal.LoadFromFile(filename);

                Console.WriteLine("Journal loaded successfully!");
}
            else if (choice == "4")
{
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                myJournal.SaveToFile(filename);

                Console.WriteLine("Journal saved successfully!");
            }
        }
    }
}
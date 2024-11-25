using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static List<JournalEntry> journal = new List<JournalEntry>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please choose a valid option.");
                    break;
            }
        }
    }

    static void WriteEntry()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();
        DateTime date = DateTime.Now;

        journal.Add(new JournalEntry { Date = date, Prompt = prompt, Response = response });
        Console.WriteLine("Entry added successfully!");
    }

    static void DisplayJournal()
    {
        if (!journal.Any())
        {
            Console.WriteLine("Journal is empty.");
            return;
        }

        foreach (var entry in journal)
        {
            Console.WriteLine($"Date: {entry.Date}");
            Console.WriteLine($"Prompt: {entry.Prompt}");
            Console.WriteLine($"Response: {entry.Response}\n");
        }
    }

    static void SaveJournal()
    {
        Console.Write("Enter the filename to save the journal: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in journal)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.Response}");
            }
        }
        Console.WriteLine($"Journal saved to {filename}");
    }

    static void LoadJournal()
    {
        Console.Write("Enter the filename to load the journal from: ");
        string filename = Console.ReadLine();
        journal.Clear();

        try
        {
            using (StreamReader reader = new StreamReader(filename))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    DateTime date = DateTime.Parse(parts[0]);
                    string prompt = parts[1];
                    string response = parts[2];

                    journal.Add(new JournalEntry { Date = date, Prompt = prompt, Response = response });
                }
            }
            Console.WriteLine($"Journal loaded from {filename}");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"No file named {filename} found.");
        }
    }

    static string GetRandomPrompt()
    {
        var prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "What new thing did I learn today?",
            "What did I accomplish today that I'm proud of?",
            "How did I step out of my comfort zone today?",
            "What is something I am grateful for today?",
            "What did I do today to make someone else's day better?"
        };

        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
}
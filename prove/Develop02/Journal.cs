using System.IO;
using System.Collections.Generic;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(PromptGenerator promptGenerator)
    {
        Console.Write("Enter the date (YYYY-MM-DD): ");
        string date = Console.ReadLine();
        string prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Enter the text: ");
        string text = Console.ReadLine();

        _entries.Add(new Entry(date, prompt, text));
        Console.WriteLine("Entry added successfully!");
    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    writer.WriteLine(entry.Date);
                    writer.WriteLine(entry.PromptText);
                    writer.WriteLine(entry.EntryText);
                    writer.WriteLine("---");
                }
            }
            Console.WriteLine("Entries saved successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occurred while saving the entry: {e.Message}");
        }
    }
    public void LoadFromFile(string file)
    {
        try
        {
            if (File.Exists(file))
            {
                _entries.Clear();
                using (StreamReader reader = new StreamReader(file))
                {
                    string date;
                    while((date = reader.ReadLine()) != null)
                    {
                        string promptText = reader.ReadLine();
                        string entryText = reader.ReadLine();
                        reader.ReadLine();

                        _entries.Add(new Entry(date, promptText, entryText));
                    }
                }
                Console.WriteLine("Entries loaded successfully!");
            }
            else
            {
                Console.WriteLine("File does not exist.");
            }
        }
        catch (Exception e)
        {
            Console.WriteLine($"An error occured while loading the entries: {e.Message}");
        }
    }
}
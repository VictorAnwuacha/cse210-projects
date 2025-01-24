using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response, string date, string time, string mood)
    {
        _entries.Add(new Entry(prompt, response, date, time, mood));
    }

    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in _entries)
            {
                // Save to CSV format
                writer.WriteLine($"{EscapeCsvValue(entry.Date)}|{EscapeCsvValue(entry.Prompt)}|{EscapeCsvValue(entry.Response)}|{EscapeCsvValue(entry.Time)}|{EscapeCsvValue(entry.Mood)}");
            }
        }
    }

    private string EscapeCsvValue(string value)
    {
        if (value.Contains(",") || value.Contains("\""))
        {
            value = "\"" + value.Replace("\"", "\"\"") + "\"";
        }
        return value;
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (var line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 5)
                {
                    AddEntry(parts[1], parts[2], parts[0], parts[3], parts[4]);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}

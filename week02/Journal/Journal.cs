using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> _entries;

    // Constructor
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // Add an entry to the journal
    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    // Display all journal entries
    public void DisplayEntries()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }
}

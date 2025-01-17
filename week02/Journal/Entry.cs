using System;

public class Entry
{
    public DateTime Date { get; set; }
    public string Text { get; set; }

    // Constructor
    public Entry(DateTime date, string text)
    {
        Date = date;
        Text = text;
    }

    // Method to display the entry
    public void Display()
    {
        Console.WriteLine($"{Date.ToShortDateString()}: {Text}");
    }
}

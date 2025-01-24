public class Entry
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public string Date { get; set; }
    public string Time { get; set; }  // New Time property
    public string Mood { get; set; }  // New Mood property

    public Entry(string prompt, string response, string date, string time, string mood)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
        Time = time;
        Mood = mood;
    }

    public override string ToString()
    {
        return $"{Date} {Time} | Mood: {Mood} | {Prompt}: {Response}";
    }
}

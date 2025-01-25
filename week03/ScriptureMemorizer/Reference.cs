using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private string _verses;

    public Reference(string book, int chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
    }

    public Reference(string book, int chapter, string startVerse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{startVerse}-{endVerse}";
    }

    public override string ToString()
    {
        return $"{_book} {_chapter}:{_verses}";
    }
}
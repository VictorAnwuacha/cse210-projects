using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords()
    {
        Random random = new Random();
        var wordsToHide = _words.Where(word => !word.IsHidden()).OrderBy(_ => random.Next()).Take(3);

        foreach (var word in wordsToHide)
        {
            word.Hide();
        }
    }

    public bool AllWordsHidden()
    {
        return _words.All(word => word.IsHidden());
    }

    public override string ToString()
    {
        string text = string.Join(" ", _words);
        return $"{_reference}\n{text}";
    }
}

using System;

class Word
{
    private string _word;
    private bool hidden = false;

    public Word(string word)
    {
        _word = word;
    }

    public string GetWord()
    {
        return _word;
    }
}
using System;

class Reference
{
    private string _book;
    private int _chapter;
    private int _firstVerse;
    private int _lastVerse;
    private string _fullReference;

    public Reference(string book, int chapter, int firstVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _fullReference = $"{_book} {_chapter}:{_firstVerse}";
    }

    public Reference(string book, int chapter, int firstVerse, int lastVerse)
    {
        _book = book;
        _chapter = chapter;
        _firstVerse = firstVerse;
        _lastVerse = lastVerse;
        _fullReference = $"{_book} {_chapter}:{_firstVerse}-{_lastVerse}";
    }

    public string GetFullReference()
    {
        return _fullReference;
    }
}
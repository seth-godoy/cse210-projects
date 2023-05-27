using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _scriptureReference;
    private string _text;
    private List<Word> _wordList = new List<Word>();
    private int _hiddenWords = 0;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        _scriptureReference = reference;
        _text = text;
        CreateWordList();
    }

    private void CreateWordList()
    {
        List<string> stringList = _text.Split(' ').ToList();

        foreach (string word in stringList)
        {
            _wordList.Add(new Word(word));
        }
    }

    public void DisplayScripture()
    {
        Console.Write($"{_scriptureReference.GetFullReference()} — ");
        foreach (Word word in _wordList)
        {
            Console.Write($"{word.GetWord()} ");
        }
        Console.WriteLine();
    }

    public void HideRandomWord()
    {
        if (_hiddenWords != _wordList.Count)
        {
            Word wordToHide = _wordList[_random.Next(0, _wordList.Count)];

            while (wordToHide.CheckIfWordHidden())
            {
                wordToHide = _wordList[_random.Next(0, _wordList.Count)];
            }

            wordToHide.HideWord();
            _hiddenWords++;
        }
    }

    public void ShowRandomWord()
    {
        if (_hiddenWords != 0)
        {
            Word wordToHide = _wordList[_random.Next(0, _wordList.Count)];

            while (!wordToHide.CheckIfWordHidden())
            {
                wordToHide = _wordList[_random.Next(0, _wordList.Count)];
            }

            wordToHide.ShowWord();
            _hiddenWords--;
        }
    }

    public bool AllWordsHidden()
    {
        if (_hiddenWords == _wordList.Count)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
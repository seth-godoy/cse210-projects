using System;
using System.Collections.Generic;

class Scripture
{
    private Reference _scriptureReference;
    private string _text;
    private List<Word> _wordList = new List<Word>();

    public Scripture(Reference reference)
    {
        _scriptureReference = reference;
        _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
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
        
    }
}
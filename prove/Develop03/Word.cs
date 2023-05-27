using System;

class Word
{
    private string _word;
    private string _underscores;
    private string _backupWord;
    private bool _hidden = false;

    public Word(string word)
    {
        _word = word;
        _underscores = new string('_', _word.Length);
        _backupWord = _word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void HideWord()
    {
        _word = _underscores;
        _hidden = true;
    }

    public void ShowWord()
    {
        _word = _backupWord;
        _hidden = false;
    }

    public bool CheckIfWordHidden()
    {
        return _hidden;
    }
}
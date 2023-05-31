class MathAssignment : Assignment
{
    private string _textbookSections;
    private string _problems;

    public MathAssignment(string name, string topic, string sections, string problems) : base(name, topic) 
    {
        _textbookSections = sections;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_textbookSections} {_problems}";
    }
}
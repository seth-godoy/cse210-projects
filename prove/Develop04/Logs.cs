using System;
using System.Collections.Generic;
using System.IO;

class Logs
{
    private string _filename = "logs.txt";

    public void SaveLog(string line)
    {
        using (StreamWriter outputFile = new StreamWriter(_filename, true))
        {
            outputFile.WriteLine(line);
        }
    }
}
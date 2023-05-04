using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "Intel";
        job1._jobTitle = "Software Engineer";
        job1._startYear = 2015;
        job1._endYear = 2023;

        Job job2 = new Job();
        job2._company = "Google";
        job2._jobTitle = "Project Manager";
        job2._startYear = 2013;
        job2._endYear = 2021;

        Resume resume1 = new Resume();
        resume1._name = "John Doe";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
    }
}
using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        job1._company = "MicroSoft";
        job1._jobTitle = "Software Engineer";
        job1._startYear = "2012";
        job1._endYear = "2020";

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Software Engineer";
        job2._startYear = "2020";
        job2._endYear = "2023";

        Resume resume = new Resume();
        resume._name = "Sakhile Mamba";
        
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();


    }
}
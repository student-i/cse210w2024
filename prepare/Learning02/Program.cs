using System;


class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        Job job2 = new Job();
        Resume resume1 = new Resume();


        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1._startYear = 2019;
        job1._endYear = 2021;

        job2._jobTitle = "IT manager";
        job2._company = "Apple";
        job2._startYear = 2010;
        job2._endYear = 2019;

        resume1._name = "Emily Wicker";
        resume1._jobs.Add(job1);
        resume1._jobs.Add(job2);

        resume1.DisplayResume();
       
    }
}
;
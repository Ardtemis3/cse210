using System;
using System.Threading.Tasks.Dataflow;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job();
        // Console.WriteLine("Hello Learning02 World!");
        job1._jobTitle = "Software Engineer";
        job1._jobCompany = "Microsoft";
        job1._jobStart = "2019";
        job1._jobEnd = "2022";
        job1.Display();

        Job job2 = new Job();
        job2._jobTitle = "Manager";
        job2._jobCompany = "Apple";
        job2._jobStart = "2022";
        job2._jobEnd = "2023";
        job2.Display();

        Resume myResume = new Resume();
        myResume._resumeName = "Kenneth Ard";
        myResume._resumeJobs.Add(job1);
        myResume._resumeJobs.Add(job2);
        myResume.Display();
    }
}
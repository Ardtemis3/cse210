public class Resume{
    public string _resumeName;

    public List<Job> _resumeJobs = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {_resumeName}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _resumeJobs){
            job.Display();
        }
    }
}
// Resume myResume = new Resume();
        // myResume._resumeJobs[0]._jobTitle;
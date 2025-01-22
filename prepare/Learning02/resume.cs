public class Resume{
    public string _resumeFirstName;
    public string _resumeLastName;
    public List<Job> _resumeJobs;

    public void Display(){
        Console.WriteLine($"Name: {}");
    }
}
// Resume myResume = new Resume();
        // myResume._resumeJobs[0]._jobTitle;
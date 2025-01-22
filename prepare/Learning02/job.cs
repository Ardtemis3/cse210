public class Job{
    // Job title (company)
    //startyear-endyear
    public string _jobTitle;
    public string _jobCompany;
    public string _jobStart;
    public string _jobEnd;

    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_jobCompany}), {_jobStart}-{_jobEnd}");
    }

}


    // person's name and list of jobs for resume

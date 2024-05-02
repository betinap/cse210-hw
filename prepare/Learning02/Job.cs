using System;
public class Job
{
    // Create member variables(attributes) for each element.
    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;
    
    //A method that display the variables.
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} {_company} {_startYear}-{_endYear}");
    }

}
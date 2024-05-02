using System;

class Program
{
    static void Main(string[] args)
    {
        //Create a job instance.
        Job job1 = new Job();
        //Set the member variables and method.
        job1._jobTitle = "Food Production Manager";
        job1._company = "(Frigorifico Recreo-Santa Fe)";
        job1._startYear = 2004;
        job1._endYear = 2007;

        //Create a new job instance.
        Job job2 = new Job();
        //Set variables and method.
        job2._jobTitle = "Quality Analist";
        job2._company ="(La Serenisima)";
        job2._startYear = 2000;
        job2._endYear = 2004;
        
        //Create a new instance of the Resume class.
        Resume resume = new Resume();

        resume._name = "Betina Paredes";

        resume._jobs.Add(job1);
        resume._jobs.Add(job2);

        resume.Display();





    }
}
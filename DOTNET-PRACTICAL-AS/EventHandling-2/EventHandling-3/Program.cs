using System;

class Program
{
    static void Main()
    {
        College college = new College();  // Create College (Publisher)
        Caterer caterer = new Caterer();  // Create Caterer (Subscriber)
        Decorator decorator = new Decorator();  // Create Decorator (Subscriber)

        // Subscribe to the College Fest Event
        college.CollegeFestEvent += caterer.OnCollegeFestEvent;
        college.CollegeFestEvent += decorator.OnCollegeFestEvent;

        // Get the number of visitors from the user
        Console.Write("Enter the number of visitors for the fest: ");
        int visitors = int.Parse(Console.ReadLine());

        // Announce the Fest (Trigger the event)
        college.AnnounceFest(visitors);
    }
}

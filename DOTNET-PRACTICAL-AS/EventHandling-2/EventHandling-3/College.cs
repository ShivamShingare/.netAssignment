using System;

public class College
{
    // Declare an event (Publisher)
    public event EventHandler<CollegeFestEventArgs> CollegeFestEvent;

    public void AnnounceFest(int visitors)
    {
        Console.WriteLine($"\n College Fest Announced for {visitors} Visitors \n");

        // Raise the event if there are any subscribers
        CollegeFestEvent?.Invoke(this, new CollegeFestEventArgs(visitors));
    }
}

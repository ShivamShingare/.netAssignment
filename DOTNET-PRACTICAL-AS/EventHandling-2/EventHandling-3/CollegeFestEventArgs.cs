using System;

public class CollegeFestEventArgs : EventArgs
{
    public int Visitors { get; }  // Read-only property to store visitors

    public CollegeFestEventArgs(int visitors)
    {
        Visitors = visitors;
    }
}

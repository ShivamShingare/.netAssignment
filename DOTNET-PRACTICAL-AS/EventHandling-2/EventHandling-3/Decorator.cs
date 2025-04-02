using System;

public class Decorator
{
    private const int BaseCost = 10000; // Basic decoration cost
    private const int CostPerVisitor = 10; // Extra charge per visitor

    public void OnCollegeFestEvent(object sender, CollegeFestEventArgs e)
    {
        int totalCost = BaseCost + (e.Visitors * CostPerVisitor);
        Console.WriteLine($" Decoration Cost: Rs{BaseCost} + ({e.Visitors} x Rs{CostPerVisitor}) = Rs{totalCost}");
    }
}

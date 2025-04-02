using System;

public class Caterer
{
    private const int CostPerPlate = 200; // Catering charges per plate

    public void OnCollegeFestEvent(object sender, CollegeFestEventArgs e)
    {
        int totalCost = e.Visitors * CostPerPlate;
        Console.WriteLine($" Catering Cost: {e.Visitors} x Rs{CostPerPlate} = Rs{totalCost}");
    }
}

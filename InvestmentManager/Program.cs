using Model;
using System.Collections;

Console.WriteLine("Investment Manager 3000");
Console.WriteLine();

// TODO: Instantiate House and Boat objects 
IInvestment boat = new Boat(4, 200, "Very nice", "Yatch", 1850);
IInvestment house = new House("Sofiendalsvej 60", 40, 400000, "Shit", "Plankboat");


// TODO: Add the objects to an ArrayList
ArrayList possessions = new();
possessions.Add(boat);
possessions.Add(house);

// TODO: Iterate through the objects and run either Boat or House methods
// HINT: You can use the "is" operator and Type Casting

foreach (IInvestment item in possessions)
{
    //if(item is Boat)
    //{
    //    ((Boat)item).CalculatePrice();
    //    ((Boat)item).InvestSummaray();
    //}
    //if(item is House)
    //{
    //    ((House)item).PriceCalculate();
    //    ((House)item).InvestSummaray();
    //}

    
    Console.WriteLine(item.InvestSummaray());
    Console.WriteLine(item.PriceCalculate());
}

int price = 0;
string? invSummary = null;


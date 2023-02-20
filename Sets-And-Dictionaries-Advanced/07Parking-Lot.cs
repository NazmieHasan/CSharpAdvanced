using System;
using System.Collections.Generic;

var input = Console.ReadLine();
var parking = new HashSet<string>();
            
while (input != "END")
{
    string[] commandInfo = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);         
    string dirrection = commandInfo[0];
    string carNumber = commandInfo[1];
                
    if (dirrection == "IN")
    { 
        parking.Add(carNumber);
    }         
    else if (dirrection == "OUT")
    {
        parking.Remove(carNumber);
    }
                
    input = Console.ReadLine();
}
            
if (parking.Count > 0) 
{
    foreach (string carNumber in parking)
    {
         Console.WriteLine(carNumber);
    }
}
else
{
    Console.WriteLine("Parking Lot is Empty");
}

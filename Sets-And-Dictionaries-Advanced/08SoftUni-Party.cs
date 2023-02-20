using System;
using System.Collections.Generic;

HashSet<string> set = new();
string number = Console.ReadLine();
           
while (number != "PARTY")
{
    set.Add(number);
    number = Console.ReadLine();
}

string guestNumber = Console.ReadLine();

while (guestNumber != "END")
{
    if (set.Contains(guestNumber))
    {
        set.Remove(guestNumber);
    }
              
    guestNumber = Console.ReadLine();
}

Console.WriteLine(set.Count);

foreach (var item in set)
{
    char[] ch = item.ToCharArray();
              
    if (char.IsDigit(ch[0]))
    {
        Console.WriteLine(item);
    }
}

foreach (var item in set)
{
    char[] ch = item.ToCharArray();
              
    if (char.IsLetter(ch[0]))
    {
        Console.WriteLine(item);
    }
}

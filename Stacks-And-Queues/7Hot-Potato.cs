using System;
using System.Collections.Generic;

string[] names = Console.ReadLine().Split();
Queue<string> queue = new Queue<string>(names);

int n = int.Parse(Console.ReadLine());
int tosses = 1;

while (queue.Count != 1)
{
    string name = queue.Dequeue();
	
    if (tosses < n)
    {
        tosses++;
        queue.Enqueue(name);
    }
    else
    {
        Console.WriteLine($"Removed {name}");
        tosses = 1;
    }
}

Console.WriteLine($"Last is {queue.Dequeue()}");

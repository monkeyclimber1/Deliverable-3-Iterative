//Bryan Miranda
//ISM 4300
//Iterative Deliverable

using System;
using System.Security.Cryptography;
    try
    {
        Console.WriteLine("Please eneter a Integer number between the range of 1 and 100 ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine("Is this an Odd or Even Series? Please Specify as 'odd' or 'even' This is case sensitive: ");
        string Odd_Even = Console.ReadLine();

    Console.WriteLine($"You have selected the {Odd_Even} series. The numbers between 0 and {x} are:");

        if (x >= 1 & x <= 100)
        {
            if (Odd_Even == "odd")
            {
            Console.WriteLine($"You have selected the {Odd_Even} series. The numbers between 0 and {x} are:");
            for (int i = 1; i <= x; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else if (Odd_Even == "even")
            {         
            for (int i = 2; i <= x; i += 2)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("Enter 'Odd' or 'Even'");
            }
        }
        else
        {
            Console.WriteLine("Enter another integer between 1 and 100");
        }

    }
    catch
    {
        Console.WriteLine("Enter only integer values within the range.");
    }



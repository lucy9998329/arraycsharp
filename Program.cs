using System;
using System.Collections.Generic;
namespace arraycsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Start the program with Clear();
            Console.Clear();
            
           
        //var fruits = new string[]{"Apple", "banana", "orange", "mandarin"};

        var fruits = new List<string> {"Apple", "banana", "orange", "mandarin"};
        var answer = true;
        Console.WriteLine("here are a bunch of fruits");
        Console.WriteLine();

        do
        {
            foreach(var x in fruits)
            Console.WriteLine(x);
        }

        Console.WriteLine("please add another fruit:");
        var input = Console.ReadLine();

        fruits.Add(input);
        
        Console.WriteLine("would you like to add another fruit?");
        var inputAnswer = Console.ReadLine();
        if (inputAnswer == "yes" )
        //answer = bool.TryParse(Console.ReadLine(), out answer);
        Console.WriteLine(answer);

            
        }
        while(answer == true);
        foreach(var)

        

           
            
            //End the program with blank line and instructions
            Console.ResetColor();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to quit the program");
            Console.ReadKey();
            
        }
        }
        }
    

/*using System;

namespace homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
           
            if (int.TryParse(Console.ReadLine(), out int number))
            {
                if (number % 5 == 0)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }
            else
            {
                Console.WriteLine("invalid input");
            }
        }
    }
}
*/



/*
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter the value of X: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.Write("enter the value of Y: ");
            if (int.TryParse(Console.ReadLine(), out int y))
            {
                    
                Console.WriteLine($"X + Y: {x + y}");
               
                int difference = (x > y) ? x - y : y - x;
                Console.WriteLine($"X - Y: {difference}");
               
                Console.WriteLine($"X * Y: {x * y}");
              
                if (y != 0)
                {
                    Console.WriteLine($"X / Y: {x / (double)y}");
                }
                else
                {
                    Console.WriteLine("cannot divide by 0");
                }
            }
            else
            {
                Console.WriteLine("invalid input for Y");
            }
        }
        else
        {
            Console.WriteLine("invalid input for X");
        }
    }
}
*/

/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the value of x: ");
        if (int.TryParse(Console.ReadLine(), out int x))
        {
            Console.Write("Enter the value of y: ");
            if (int.TryParse(Console.ReadLine(), out int y))
            {
                Console.WriteLine($"before replace: x = {x}, y = {y}");

                int replace = x;
                x = y;
                y = replace;

                Console.WriteLine($"after replace: x = {x}, y = {y}");
            }
            else
            {
                Console.WriteLine("invalid input for y");
            }
        }
        else
        {
            Console.WriteLine("invalid input for x");
        }
    }
}
*/
/*using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("enter a number: ");
        if (int.TryParse(Console.ReadLine(), out int number))
        {
            
            Console.WriteLine($"gamravlebis tabula {number}-istvis:");

            for (int i = 1; i <= 9; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }
        else
        {
            Console.WriteLine("invalid input");
        }
    }
}
*/

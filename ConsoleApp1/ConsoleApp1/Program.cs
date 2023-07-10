using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbers = new List<int>();
        int input;

        Console.WriteLine("Enter numbers (enter 0 to complete):");

        do
        {
            input = Convert.ToInt32(Console.ReadLine());
            numbers.Add(input);
        } while (input != 0);

        int count = 0;
        int previousNumber = numbers[0];

        Console.WriteLine("Repeating successive numbers:");

        for (int i = 1; i < numbers.Count; i++)
        {
            if (numbers[i] == previousNumber)
            {
                count++;
            }
            else
            {
                if (count > 0)
                {
                    Console.WriteLine($"number {previousNumber}  {count+1} times");
                    count = 0;
                }
                previousNumber = numbers[i];
            }
        }
    }
}
 






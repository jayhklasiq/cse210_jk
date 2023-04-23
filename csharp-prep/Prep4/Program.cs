using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //Ask the user for a series of numbers, and 
        //Stop when they enter 0.
        Console.WriteLine("Enter a list of numbers. Enter '0' when you're done.");
        Console.Write("Enter a number: ");
        string num = Console.ReadLine();
        int number = int.Parse(num);
        //append each one to a list.
        List<int> numberList = new List<int>();
        numberList.Add(number);
        // Compute the sum, or total, of the numbers in the list.
        int sum = 0;
        float total = 0;

        while (number != 0)
        {
            Console.Write("Enter a number: ");
            num = Console.ReadLine();
            total = total + 1;
            number = int.Parse(num);
            if (number != 0)
            {
                numberList.Add(number);
            }
        }
        
        foreach (int no in numberList)
        {
            sum += no;
        }
        int maxValue = numberList.Max();
        Console.WriteLine(sum);
        // Compute the average of the numbers in the list.
        Console.WriteLine($"The average is: {sum / total}");
        //Find the maximum, or largest, number in the list
        Console.WriteLine($"The highest value is: {maxValue}");
        //Sort the numbers in the list and display the new, sorted list (Stretch Challenge 2)
        numberList.Sort();
        foreach  (int no in numberList)
        {
            Console.WriteLine(no);
        }
    }
}
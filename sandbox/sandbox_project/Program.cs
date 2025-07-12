using System;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");

        List<int> list = FindDivisors(80);
        Console.WriteLine("<List>{" + string.Join(", ", list) + "}"); // should print 1,2,4,5,8,10,16,20,40

        List<int> list2 = FindDivisors(79);
        Console.WriteLine("<List>{" + string.Join(", ", list2) + "}"); // should print 1
    }

    private static List<int> FindDivisors(int number)
    {
        List<int> results = new();

        for (int i = 1; i < number; i++) // up to but not including the number
        {
            if (number % i == 0)
            {
                results.Add(i);
            }
        }

        return results;
    }
}

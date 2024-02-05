using System;

public class DisplayEachCharacter
{
    public static void Main()
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        for (int i = 0; i < inputString.Length; i++)
        {
            Console.WriteLine(inputString[i]);
        }
    }
}
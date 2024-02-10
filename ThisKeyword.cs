using System;

class ThisKeyword
{
    private int number;

    public ThisKeyword(int number)
    {
        // Using 'this' to differentiate between the instance variable and constructor parameter
        this.number = number;
    }

    public void PrintNumber()
    {
        // Using 'this' to access the instance variable within the method
        Console.WriteLine("Number: " + this.number);
    }

    public static void Main()
    {
        // Creating an instance of ThisKeyword
        ThisKeyword obj = new ThisKeyword(42);

        // Calling the PrintNumber method
        obj.PrintNumber();
    }
}

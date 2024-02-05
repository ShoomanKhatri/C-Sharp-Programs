using System;

class CheckPrime
{
    public static void Main()
    {
        int c = 0;
        int n;
        string StringNum;
        Console.WriteLine("Enter the value : ");
        StringNum = Console.ReadLine();
        n = int.Parse(StringNum);

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                c++;
            }
        }

        if (c == 2)
        {
            Console.WriteLine("{0} is prime", n);
        }
        else
        {
            Console.WriteLine("Not prime");
        }
    }
}

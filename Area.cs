using System;

class Area{
class AreaCalculator
{
    public static double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    public static double CalculateArea(double length, double width)
    {
        return length * width;
    }
}


    static void Main(string[] args)
    {
        double circleArea = AreaCalculator.CalculateArea(5);
        Console.WriteLine("Area of circle: " + circleArea);

        double rectangleArea = AreaCalculator.CalculateArea(4, 6);
        Console.WriteLine("Area of rectangle: " + rectangleArea);
    }
}

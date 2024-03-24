using System;


class OverloadBinary
{
    class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Overloading the '+' operator for Vector2D
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }

        public override string ToString()
        {
            return $"({X}, {Y})";
        }
    }

    
       public static void Main()
        {
            Vector2D v1 = new Vector2D(1, 2);
            Vector2D v2 = new Vector2D(3, 4);

            Vector2D sum = v1 + v2;

            Console.WriteLine("Sum of vectors: " + sum);
        Console.ReadKey();
    }
    

}

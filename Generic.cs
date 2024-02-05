using System;
using System.Collections.Generic;
    class Generic
    {
        public static void Main()
        {
            List<int> intlist = new List<int>();
            intlist.Add(1);
            intlist.AddRange(new List<int> { 2, 3 });
            intlist.Insert(0, 9);
            foreach (int i in intlist)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }


using System;

namespace Home_work_Loops_6_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // №6
            //  *
            // ***
            //*****

            Console.WriteLine("Enter rows count");

            int a = int.Parse(Console.ReadLine());

            for (int y = 0; y < a; y++)
            {
                for (int x = a; x > y; x = x - 1)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= y; x = x + 1)
                {
                    Console.Write("*");
                }
                for (int x = 0; x < y; x++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            // № 7
            // *
            //***
            // *
            Console.WriteLine("Enter height of rhombus");

            int n = int.Parse(Console.ReadLine());

            for (int y = 0; y < n; y++)
            {
                for (int x = n; x > y; x = x - 1)
                {
                    Console.Write(" ");
                }
                for (int x = 0; x <= y; x = x + 1)
                {
                    Console.Write("*");
                }
                for (int x = 0; x < y; x++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            int b = n;
            int d = n;

            for (int y = 0; y <= b; y++)
            {
                for (int x = 0; x < y; x++)
                {
                    Console.Write(" ");
                }
                for (int x = b; x >= y; x--)
                {
                    Console.Write("*");
                }
                for (int c = 0; c < d; c++)
                {
                    Console.Write("*");
                }
                d--;
                Console.WriteLine();
            }
        }
    }
}

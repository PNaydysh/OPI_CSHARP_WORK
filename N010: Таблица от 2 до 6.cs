using System;


namespace Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int m = 6;

            for (int i = 2; i <= m; i++)
            {
                for (int j = 2; j <= m; j++)
                {
                    Console.Write($"{i * j}\t");
                }
                
            }

        }
    }
}

using System;



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 0;

            for (int i = 1; i <= n; i++)
            {
                res = res + i;
            }

            Console.WriteLine(res);
        }
    }


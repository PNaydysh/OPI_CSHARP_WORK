using System;



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 0, count = 0;

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                {
                    res += i;
                    count++;
                }  
            }

        Console.WriteLine($"{res} {count}");
        }
    }



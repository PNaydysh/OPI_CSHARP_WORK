using System;



    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int res = 1, i = 1;

            do
            {
                res *= i;
                i++;
            }while(i <= n);

        Console.WriteLine(res);
        }
    }


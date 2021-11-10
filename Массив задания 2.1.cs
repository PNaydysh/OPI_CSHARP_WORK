using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            int max = array[0];
            int max_ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max_ind = i;
                }
            }
            Console.WriteLine($"minimum is {min}");
            Console.WriteLine($"индекс максимального числа = {max_ind}");
            Console.ReadLine();
        }
    }
}

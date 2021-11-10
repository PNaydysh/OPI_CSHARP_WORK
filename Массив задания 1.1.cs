using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));

            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }

            }
            
            Console.WriteLine($"maximum is {max}");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write($"{array[i]} ");
            }
            Console.ReadLine();
        }
    }
}

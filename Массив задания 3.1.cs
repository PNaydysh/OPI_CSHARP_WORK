using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => int.Parse(s));
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 != 0 )
                {
                    sum += array[i]; 
                }
            }
            Console.WriteLine(sum);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            
            Console.ReadLine();
        }
    }
}

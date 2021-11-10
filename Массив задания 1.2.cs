using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double sr_ar;
            var array = Array.ConvertAll(Console.ReadLine().Split(' '), s => Double.Parse(s));

           for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sr_ar = sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = sr_ar;
                }
                Console.Write(array[i] + " ");
            }
           Console.ReadLine();
        }
    }
}

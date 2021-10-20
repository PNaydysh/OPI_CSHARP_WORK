using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Введите три числа: ");
        
        double n1, n2, n3, min;
        n1 = double.Parse(Console.ReadLine());
        n2 = double.Parse(Console.ReadLine());
        n3 = double.Parse(Console.ReadLine());
        min = n1;
        
        min = n1 < n2 ? n1 : n2;
        min = min < n3 ? min : n3;
        Console.WriteLine(min);
        
        Console.ReadKey();
    }
}

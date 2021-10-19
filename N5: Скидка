using System;

class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine("Введите стоимость покупки: ");
        
        double cost, costSale;
        cost = double.Parse(Console.ReadLine());
        
        if(cost > 500 && cost <= 1000)
            costSale = cost - (cost * 0.03);
        else if(cost > 1000)
            costSale = cost - (cost * 0.05);
        else costSale = cost;
            Console.WriteLine(costSale);
    }
}

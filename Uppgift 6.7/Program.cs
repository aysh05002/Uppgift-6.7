using System;

class progarm
{
    static void tal(int prim)
    {
        if (prim > 3)
        {
            if (prim % 2 == 0 || prim % 3 == 0)
            {
                Console.WriteLine($"{prim} är inte ett primt tal");
            }
            else
            {
                Console.WriteLine($"{prim} är ett primt tal");
            }
        }
        else
        {
            Console.WriteLine($"{prim} är ett primt tal");
        }
    }
    static void Main(string[] args)
    {
        Console.Write("Undersök om x är ett prim tal \nx = ");
        tal(Convert.ToInt32(Console.ReadLine()));
    }
}
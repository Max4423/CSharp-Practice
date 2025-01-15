using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(sum(123,12));
        Console.WriteLine(sum(123, 12,1));

        int suma;
        summa(12, 15, out suma);
        Console.WriteLine(suma);
    }

static int sum(int x, int y)
    {
        return x + y;
    }

    static int sum(int x, int y, int z)
    {
        return x + y + z;
    }
static void summa(int x, int y, out int sum)
{
        sum = x + y;
    }

}
    


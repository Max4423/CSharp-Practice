namespace NumberOperationDelegate;

class Program
{
    static void Main(string[] args)
    {
        NumberOperations op = Square;
        int square = op(10);
        Console.WriteLine(square);
        op += Double;
        Console.WriteLine(op(10));

        op += delegate(int number)
        {
            if (number == 1 || number == 0)
            {
                return 1;
            }
            return number * op(number - 1);
        };
        Console.WriteLine(op(4));
        
    }

    public static int Square(int number) => number * number;
    public static int Double(int number) => number * 2;
    delegate int NumberOperations(int x);

}    


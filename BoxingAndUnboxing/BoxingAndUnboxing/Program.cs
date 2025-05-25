namespace BoxingAndUnboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;
            object b = a;
            int c = (int)b;

            //decimal d = (decimal)b;
        }
    }
}

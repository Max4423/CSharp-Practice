namespace Multithreading;

class Program
{
    static void Main(string[] args)
    {
        Thread currentThread = Thread.CurrentThread;

        Console.WriteLine(currentThread.Name);
        currentThread.Name = "Метод Main";
        Console.WriteLine(currentThread.Name);

        Console.WriteLine(currentThread.IsAlive);
        Console.WriteLine(currentThread.IsBackground);
        
        Console.WriteLine(currentThread.ManagedThreadId);
        Console.WriteLine(currentThread.Priority);

        Console.WriteLine(currentThread.ThreadState);
        
        Thread.Sleep(1000);

        Thread thread1 = new Thread(Print);
        
        thread1.Start();
        
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Головний потік: {i}");
            Thread.Sleep(400);
        }
        
        
        Thread thread2 = new Thread(msg => Console.WriteLine(msg));
        
        thread2.Start("Kukuku");
       
        Thread thread3 = new Thread(Print2);
        thread3.Start("max");
    }

    public static void Print()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Другий потік: {i}");
            Thread.Sleep(1000);
        }
    }
    
    public static void Print2(object? obj )
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"4 потік: {i} {obj}");
            Thread.Sleep(1000);
        }
    }
    
}
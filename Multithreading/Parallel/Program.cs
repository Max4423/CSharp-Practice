Parallel.Invoke(() => Console.WriteLine($"Hello World, Thread {Thread.CurrentThread.ManagedThreadId}"),
    () => Console.WriteLine($"Goodbye World, Thread {Thread.CurrentThread.ManagedThreadId}"));


Parallel.For(0, 10, i => { Console.WriteLine($"Iteration {i}, Thread {Thread.CurrentThread.ManagedThreadId}"); });

Parallel.For(1, 5, Square);
Console.WriteLine("------------");

Parallel.ForEach(new List<int>(){2,8,136}, Square);

static void Square(int n)
{
    Console.WriteLine("Result " + n * n);

    Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId}");
}
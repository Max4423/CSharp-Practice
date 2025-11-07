Report();
ThreadPool.QueueUserWorkItem(Task1);
Report();
ThreadPool.QueueUserWorkItem(Task2);
Report();

Thread.Sleep(5000);
Report();
static void Task1(object state)
{
    Thread.CurrentThread.Name = "Task1";
    Console.WriteLine("Запущений потік {0}",Thread.CurrentThread.Name);
    Thread.Sleep(2000);
    Console.WriteLine("Потік {0} завершив роботу",Thread.CurrentThread.Name);
}

static void Task2(object state)
{
    Thread.CurrentThread.Name = "Task2";
    Console.WriteLine("Запущений потік {0}",Thread.CurrentThread.Name);
    Thread.Sleep(500);
    Console.WriteLine("Потік {0} завершив роботу",Thread.CurrentThread.Name);
}
static void Report()
{
    Thread.Sleep(200);

    int availableWorkThreads;
    int availableIOThreads;
    int maxWorkThreads;
    int maxIOThreads;
    
    ThreadPool.GetAvailableThreads(out availableWorkThreads, out availableIOThreads);
    ThreadPool.GetMaxThreads(out maxWorkThreads, out maxIOThreads);
    Console.WriteLine($"Available Work Threads: {availableWorkThreads} of {maxWorkThreads}");
    Console.WriteLine($"Available IO Threads: {availableIOThreads} of {maxIOThreads}");
}
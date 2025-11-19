Task[] tasks = new Task[3]
{
    new Task(() => Console.WriteLine("First Task")),
    new Task(() => Console.WriteLine("Second Task")),
    new Task(() => Console.WriteLine("Third Task"))
};

foreach (var task in tasks)
      task.Start();

//Task.WaitAny(tasks);

Task.WaitAll(tasks);

int x = 14;
Task<int> taskk = new Task<int>(() => Square(x));
taskk.Start();
var taskk2 = taskk.ContinueWith(PrintResult);
taskk2.Wait();

static int Square(int x)
{
    Thread.Sleep(1000);
    return x * x;
}

static void PrintResult(Task<int> t)
{
    Console.WriteLine($"Result:{t.Result}\nTask id: {Task.CurrentId} ");
}



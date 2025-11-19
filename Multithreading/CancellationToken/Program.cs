CancellationTokenSource cts = new CancellationTokenSource();
CancellationToken token = cts.Token;

Task task = new Task(() =>
{
    for (int i = 1; i < 10; i++)
    {
        if (token.IsCancellationRequested)  
        {
            /*Console.WriteLine("Operation cancelled.");
            return;   */ 
            token.ThrowIfCancellationRequested();
        }
        Console.WriteLine($"Квадрат числа {i}:  {i * i}");
        Thread.Sleep(200);
    }
}, token);
task.Start();
Console.WriteLine($"Task Status: {task.Status}");
Thread.Sleep(1000);
cts.Cancel();
Thread.Sleep(1000);
Console.WriteLine($"Task Status: {task.Status}");

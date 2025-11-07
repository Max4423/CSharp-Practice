Task task = new Task(Method);
Console.WriteLine(task.Status);
task.Start();
Console.WriteLine(task.Status);
Thread.Sleep(150);
Console.WriteLine(task.Status);
Thread.Sleep(1000);
Console.WriteLine(task.Status);
Console.WriteLine(task.IsCompleted);


void Method()
{
    Thread.Sleep(300);
}
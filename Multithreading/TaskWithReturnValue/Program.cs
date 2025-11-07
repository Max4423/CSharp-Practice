
Task<int> task = Task.Run(() =>
{
    Console.Write(Thread.CurrentThread.ManagedThreadId + " ");
    int sum = 0;
    for (int i = 0; i < 5000; i++)
    {
        sum += i;
    }
    return sum;
});
Console.WriteLine(task.Result);

int sum = 0;
for (int i = 0; i < 5000; i++)
{
    sum += i;
}

Console.WriteLine(Thread.CurrentThread.ManagedThreadId + " " + sum);


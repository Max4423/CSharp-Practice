//Task task = new Task(Print);
//task.Start();

//Task.Run(() => Print());
Task task = Task.Run(Print);

for (int i = 0; i < 70; i++)
{
    Console.Write('*');
    Thread.Sleep(10);
}

static void Print()
{
    for (int i = 0; i < 70; i++)
    {
        Console.Write('+');
        Thread.Sleep(10);
    }
}
Console.WriteLine("Основний потік запущено.");
Task task1 = new Task(MyTask1);
Task task2 = new Task(MyTask2);
task1.Start();
task2.Start();
Console.WriteLine("Id задачi tаsk1: " + task1.Id);
Console.WriteLine("Id задачi task2: " + task2.Id);


// WaitAll - Очікує завершення виконання всіх зазначених об'єктів Task.
Task.WaitAll(task1, task2);
// WaitAny - Очікує завершення виконання будь-якого із зазначених об'єктів Task.
Task.WaitAny(task1, task2);
Console.WriteLine("Основной поток завершен.");

static void MyTask1()
{
    Console.WriteLine("MyTask: CurrentId" + Task.CurrentId + " запущений.");
    Thread.Sleep(2000);
    Console.WriteLine("MyTask: CurrentId" + Task.CurrentId + " завершено.");
}

static void MyTask2()
{
   Console.WriteLine("My Task: CurrentId " + Task. CurrentId + " запущений.");
   Thread.Sleep(3000);
   Console.WriteLine("MyTask: CurrentId" + Task. CurrentId + " завершено. ");
}

Console.WriteLine("==============================");

Console.WriteLine("Main Starts");
// создаем задачу
Task task12 = new Task(() =>
{
    Console.WriteLine("Task Starts");
    Thread.Sleep(1000);
    Console.WriteLine("Task Ends");
});
task12.Start();  // запускаем задачу

task12.Wait();   // ожидаем выполнения задачи

Console.WriteLine("==============================");


var outer =  Task.Factory.StartNew(() => 
{
    Console.WriteLine("Outer task starting...");
    var inner =  Task.Factory.StartNew(() =>  
    {
        Console.WriteLine("Inner task starting...");
        Thread.Sleep(2000);
        Console.WriteLine("Inner task finished.");
    }, TaskCreationOptions.AttachedToParent);
});
outer.Wait(); // ожидаем выполнения внешней задачи
Console.WriteLine("End of Main");
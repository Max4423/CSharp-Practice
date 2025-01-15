Queue <string> patients = new Queue <string> ();

patients.Enqueue("Vasyl");
patients.Enqueue("Petro");
patients.Enqueue("Ivan");
patients.Enqueue("Mykola");

Console.WriteLine("Dequeue: " + patients.Dequeue());
Console.WriteLine("Next go:" + patients.Peek());

foreach (string patient in patients)
{
    Console.WriteLine(patient);
}
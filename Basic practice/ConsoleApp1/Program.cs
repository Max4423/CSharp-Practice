Console.OutputEncoding = System.Text.Encoding.Unicode;
string emoji = "\U0001F600";
System.Console.WriteLine("\U0001F601");
Console.OutputEncoding = System.Text.Encoding.Unicode;
Console.WriteLine("Hello, World!");
Console.Beep(1000, 500);

Console.WriteLine(int.MaxValue);
Console.WriteLine(int.MinValue);
Console.WriteLine(double.Cos(12));
float f = 12.23F;
Console.WriteLine(f);

float result;
int a = 15;
int b = 8;
result = Convert.ToSingle(a) / b;  
Console.WriteLine(result);

int timeInMinutes = 130;
int hours, minutes;

hours = timeInMinutes / 60;
minutes = timeInMinutes % 60;
Console.WriteLine(hours + " годин; " + minutes + " хвилин ");

int incr = 123;
incr++;
Console.WriteLine(incr);
incr += 100;
Console.WriteLine(incr);

Console.WriteLine($"Increment = {incr}");

Console.Write("Введіть значення x: ");
int x;
x = Convert.ToInt32( Console.ReadLine());

Console.WriteLine(x*2);

int A = 0;
//                1  +  2 + 1 + 1   +  "1" + 3 * 2     ===516
Console.WriteLine(++A + 2 + 1 + A++ + "1" + ++A *2);
Console.ReadKey();


Console.WriteLine(0xF3);
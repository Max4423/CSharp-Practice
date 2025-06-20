using IEnumerable_IEnumerator;
using Microsoft.VisualBasic;

IEnumerable<int> sequence = new NumberSequence(10, 120);

foreach (var number in sequence)
{
	Console.WriteLine(number);
}

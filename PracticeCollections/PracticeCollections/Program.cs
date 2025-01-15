using System.Reflection;

List<int> nums = new List<int> ();

nums.Add(1);
nums.Add(12);
nums.Add(1);
nums.Add(12);
nums.Add(111);
nums.Add(1344);
nums.Add(444);
nums.AddRange(new int[] {444, 044, 440});


nums.RemoveAt (0);

Console.WriteLine($"Число 12 на позицiї {nums.IndexOf(12)}");

nums.Insert (5, 987654321);

for (int i = 0; i < nums.Count; i++)
{
    Console.WriteLine(nums[i]);
}


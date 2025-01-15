int[] arr = new int[12];
Random rand = new Random();
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(0, 101);
}
for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}


int[] arr2 = { 2, 1234, 3, 3, 234, 214, 3, 2, 67,  int.MaxValue };
for (int i = 0; i < arr2.Length; i++)
{
    Console.Write(arr2[i] + " ");
}

int[] arr3 = new int[4] { 2, 4, 55, 1 };
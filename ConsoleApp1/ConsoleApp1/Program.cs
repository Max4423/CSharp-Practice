int[] arr = new int[] { 1, 2, 3, 4, 5 };

void reverse(int[] arr)
{
    int n = arr.Length;
    int k = n / 2;
    int temp;

    for (int i = 0; i < k; i++)
    {
        temp = arr[i];
        arr[i] = arr[n - i - 1];
        arr[n - i - 1] = temp;
    }

    foreach (int ark in arr)
    {
        Console.WriteLine(ark);
    }
}

reverse(arr);

int sum = 0, xx = 5, yy = 10;
static void Add(ref int sum, int x, int y)
{

    sum = x + y;
}


Add(ref sum, xx, yy);

Console.WriteLine(sum);


int area;
int perimetr;
int x = 5;
int y = 10;
static void GetRectangleData(int x, int y, out int area, out int perimetr)
{
    area = x * y;
    perimetr = 2 * (x + y);
}

GetRectangleData(x, y, out area, out perimetr);

Console.WriteLine($"S: {area}");
Console.WriteLine($"P: {perimetr}");

/////////////////////////////////////////////////////////

int[] array = new int[5] { 1, 2, 3, 4, 5 };

EditArray(array, 2, 10);
static void EditArray(int[] arr, int index, int value)
{
    arr[index] = value;
}

Console.WriteLine(array[2]);

static int[] NewArray(int[] arr, int index, int value)
{
    arr = new int[20];
    return arr;

}

int[] arr2 = NewArray(array, 2, 10);

for (int i = 0; i < arr2.Length; i++)
{
    Console.WriteLine(arr2[i]);
}


Random rnd = new Random();  
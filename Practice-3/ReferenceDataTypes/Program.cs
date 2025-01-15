int[] arr = new int[2];
int[] dbArr = new int[5];
Console.WriteLine(arr.Length);

arr = dbArr;

arr[4] = 1;
arr[0] = 135;

Console.WriteLine(dbArr[0]);

Console.WriteLine(arr.Length);

Console.WriteLine(dbArr.Length);

int[] petro = new int[5];
int[] ivan = new int[3];
int[] vasyl;
ivan = petro;

vasyl = ivan;

petro[0] = 5;
petro[1] = 3;
vasyl[4] = 444;
Console.WriteLine(ivan[0]);
Console.WriteLine(ivan[1]);

petro = new int[20];
Console.ReadKey();
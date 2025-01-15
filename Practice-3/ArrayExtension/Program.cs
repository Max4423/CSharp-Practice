int[] bag = new int[1];
int[] tempbag = new int[2];

bag[0] = 1;


for (int i = 0; i < bag.Length; i++)
{
    Console.WriteLine(bag[i] + " First");
}


for (int i = 0; i < bag.Length; i++)
{
    tempbag[i] = bag[i];
}

bag = tempbag;

bag[1] = 123;




for (int i = 0; i < bag.Length; i++)
{
    Console.WriteLine(bag[i] + " Second");
}


Stack <int> nums = new Stack<int>();

nums.Push(1);
nums.Push(12);
nums.Push(123);
nums.Push(1234);
nums.Push(12345);
nums.Pop();

Console.WriteLine(nums.Peek());

//while (nums.Count > 0)
//{
//    Console.WriteLine("Number: " + nums.Pop());
//}


foreach (int num in nums)
{
    Console.WriteLine(num);
}
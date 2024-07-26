using System.Collections;

namespace AggregateAndFilterArrays;

class Program
{
    static int[] FindEvenNums(int[] nums, int[] nums2)
    {
        ArrayList list = new ArrayList();
        
        foreach (int num in nums)
        {
            if (num % 2 == 0)
            {
                list.Add(num);
            }
        }
        foreach (int num in nums2)
        {
            if (num % 2 == 0)
            {
                list.Add(num);
            }
        }
        return (int[])list.ToArray(typeof(int));
    }
    static void Main(string[] args)
    {
        int[] ar1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int[] ar2 = {0, -2, -9, -39, 39, 10};

        int[] evenNums = FindEvenNums(ar1, ar2);
        Array.ForEach(evenNums, num => Console.WriteLine(num));
    }
}

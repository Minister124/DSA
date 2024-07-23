namespace Binary_Search;

class Program
{

    static bool BinarySearch(int[] input, int item){
        int min = 0;
        int max = input.Length - 1;
        
        while(min <= max){
            int mid = (min + max) / 2;
            if (item == input[mid]){
                return true;
            } else if (item < input[mid]){
                max = mid - 1;
            } else{
                min = mid + 1;
            }
        }
        return false;
    }

    static void Main(string[] args)
    {
        int[] arr = {1, 10, 30, 40, 80};

        Console.WriteLine(BinarySearch(arr, 10));
        Console.WriteLine(Array.BinarySearch(arr, 40));
    }
}

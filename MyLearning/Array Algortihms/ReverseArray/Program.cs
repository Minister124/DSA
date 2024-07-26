namespace ReverseArray
{
    class Program{
        
        static int[] ReverseArray(int[] arr){
            int[]  reversed = new int[arr.Length];
            for(int i = arr.Length -1; i >=0; i--){
                reversed[arr.Length - 1 - i] = arr[i];
            }
            return reversed;
        }

        static void ReverseInPlace(int[] arr){
            int start = 0;
            int end = arr.Length - 1;
            while(start < end){
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
        }
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] reversed = ReverseArray(ar);
            // Array.ForEach(reversed, num => Console.WriteLine(num));
            // Array.ForEach(reversed, num => Console.WriteLine(num));
            ReverseInPlace(ar);
            ReverseInPlace(ar);
            Array.ForEach(ar, Console.WriteLine);
        }
    }
}

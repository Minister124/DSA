namespace RotateArrayToLeftByOne
{

    class Program
    {
        static void Main(string[] args){
            int[] array = {2, 3, 4, 5, 6, 1};
            int[] rotated = RotateArray(array);
            Array.ForEach(rotated, Console.WriteLine);
        }
    }
    
}
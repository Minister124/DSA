namespace RotateArrayByOneLib;

public class Rotate
{
    public static int[] RotateArray(int[] numbers){
        int n = numbers.Length;
        int firstElement = numbers[0];
        for(int i = 0; i < n-1; i++){
            numbers[i] = numbers[i+1];
        }
        numbers[n-1] = firstElement;
        return numbers;
    }
}

using System;
using System.ComponentModel;
using static System.Console;

namespace LinearSearch;

class Program{

    static bool LinearSearchArray(int[] ary, int n){
        foreach (int item in ary)
        {
            if(item == n) return true;
        }
        return false;
    }
    static void Main(string[] args){
        int[] arry = {1, 2, 5, 9, 7, 8};
        //int a = 2;

        //Console.WriteLine(LinearSearchArray(arry, a));

        int item = Array.Find(arry, item => item == 5); // Find the element 5 in the array
        int sheesh = Array.Find(arry, item => item == 3); // Find the element 3 in the array
        // WriteLine(item);
        // WriteLine(sheesh);

        // int[] items = Array.FindAll(arry, items => items >= 5); // Find all elements greater than or equal to 5
        // Array.ForEach(items, WriteLine);

        // Array.Sort(arry); // Sorts the array in ascending order
        // Array.ForEach(arry, WriteLine);

        //  Array.Reverse(arry); // Reverses the array
        //  Array.ForEach(arry, WriteLine);

        // int indexOf5 = Array.IndexOf(arry, 5);
        // int indexOf2 = Array.IndexOf(arry, 2);
        // WriteLine(indexOf5); // 2
        // WriteLine(indexOf2); // 1

        // int[] copied = new int[arry.Length];
        // Array.Copy(arry, copied, arry.Length); Copies the array to another array with same length
        // Array.ForEach(copied, WriteLine);

        // int lastIndex = Array.LastIndexOf(arry, 1);
        // WriteLine(lastIndex); // 0

        // Array.Fill(arry, 0);
        // Array.ForEach(arry, WriteLine); // Fills value 0 to all elements in the array
    }  
}
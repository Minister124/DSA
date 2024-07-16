using System;
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

        int item = Array.Find(arry, item => item == 5);
        int sheesh = Array.Find(arry, item => item == 3);
        Console.WriteLine(item);
        WriteLine(sheesh);

        int[] items = Array.FindAll(arry, items => items >= 5);
        Array.ForEach(items, WriteLine);
    }  
}
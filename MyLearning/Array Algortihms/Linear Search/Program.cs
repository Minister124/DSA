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
        int a = 2;

        Console.WriteLine(LinearSearchArray(arry, a));
    }
}
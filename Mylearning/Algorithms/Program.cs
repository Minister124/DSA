using System.Diagnostics;

namespace Algorithms;

class Program {
    static int findMaximum(int a, int b, int c) //returns 28ms
    {
        if(a > b){
            if(a > c || a == c){
                return a;
            }
        }

        if(b > c || b == c){
            if(b > a){
                return b;
            } 
        }
        return c;
    }

    static int findMaxEfficiently(int a, int b, int c) //returned 6ms
    {
        int max = a;
        if(b > a){
            max = b;
        }
        if (c > a){
            max = c;
        }
        return max;
    }

    static void Main(string[] args){
        Stopwatch stopwatch = Stopwatch.StartNew();
        WriteLine(findMaxEfficiently(1, 2, 6));
        WriteLine(findMaxEfficiently(8, 45, 32));
        WriteLine(findMaxEfficiently(32, 65, 12));
        WriteLine(findMaxEfficiently(45, 165, 12));
        WriteLine(findMaxEfficiently(16, 10, 6));
        stopwatch.Stop();
        WriteLine($"Runtime: {stopwatch.ElapsedMilliseconds}");
    }
}
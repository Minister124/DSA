using static System.Console;
using System.Diagnostics;

namespace Maximum
{
    class Program{
        static int findMaximum(int a, int b, int c){
            if(a>b)
            {
                if(b>c || b==c){    
                    return a;
                }
            }
            if (b>c)
            {
                if(b>a || b == a)
                {
                    return b;
                }
            }
            return c;
        }

        static void Main(string[] args){
            var stopWatch = Stopwatch.StartNew();
            WriteLine(findMaximum(2,3,4));
            WriteLine(findMaximum(45,58,23));
            WriteLine(findMaximum(46,158,200));
            stopWatch.Stop();
            WriteLine($"Execution Time: {stopWatch.ElapsedMilliseconds}");
        }
    }
    
}

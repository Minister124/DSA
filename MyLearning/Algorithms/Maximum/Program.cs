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

        static int EfficientMaximum(int a, int b, int c){
            int max = a;
            if( b> max)
            {
                max = b;
            }
            if( c> max)
            {
                max = c;
            }
            return max;
        }

        static void Main(string[] args){
            var stopWatch = Stopwatch.StartNew();
            WriteLine(EfficientMaximum(2,3,4));
            WriteLine(EfficientMaximum(45,58,23));
            WriteLine(EfficientMaximum(46,158,200));
            stopWatch.Stop();
            WriteLine($"Execution Time: {stopWatch.ElapsedMilliseconds}");
        }
    }
}

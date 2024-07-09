using System.Diagnostics;

namespace Normalize_Strings;

class Program
{

    static string NormalizeString(string input){
        string lowerInput = input.ToLower();
        return lowerInput;
    }
    static void Main(string[] args)
    {
        Stopwatch sw = Stopwatch.StartNew();
        WriteLine(NormalizeString("Hello"));
        sw.Stop();
        WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}

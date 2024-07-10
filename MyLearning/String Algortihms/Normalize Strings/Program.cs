using System.Diagnostics;

namespace Normalize_Strings;

class Program
{

    static string NormalizeString(string input){
        return input.ToLower().Trim().Replace("@","");
    }
    static void Main(string[] args)
    {
        Stopwatch sw = Stopwatch.StartNew();
        WriteLine(NormalizeString(" Hello @ World "));
        sw.Stop();
        WriteLine($"Execution Time: {sw.ElapsedMilliseconds} ms");
    }
}

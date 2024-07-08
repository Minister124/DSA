using System.Linq;

namespace  Validation_Algorithm
{
    class Program
    {
        static bool IsUppercase(string str)
        {
            return str.All(char.IsUpper);
        }
        static void Main(string[] args)
        {
            WriteLine(IsUppercase("HELLO"));
        }
    }
}
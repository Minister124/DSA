using System.Linq;

namespace  Validation_Algorithm
{
    class Program
    {
        static bool IsAnyUppercase(string str)
        {
            return str.Any(char.IsUpper);
        }

        static bool IsAllUppercase(string str){
            return str.All(char.IsUpper);
        }


        static void Main(string[] args)
        {
            WriteLine(IsAllUppercase("HeLLO"));
            WriteLine(IsAnyUppercase("Hi!!"));
        }
    }
}
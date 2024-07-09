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

        static bool IsAnyLowercase(string str){
            return str.Any(char.IsLower);
        }

        static bool IsAllLowercase(string str){
            return str.All(char.IsLower);
        }

        static bool IsPasswordFormat(string str)
        {
            return str.Any(char.IsUpper) && str.Any(char.IsLower) && str.Any(char.IsDigit);
        }

        static void Main(string[] args)
        {
            WriteLine(IsAllUppercase("HeLLO"));
            WriteLine(IsAnyUppercase("Hi!!"));
            WriteLine(IsAllLowercase("hello"));
            WriteLine(IsAnyLowercase("HELLo"));
            WriteLine(IsPasswordFormat("Hello123"));
        }
    }
}
using System;

namespace Parse_and_Search_Strings
{
    class Program
    {
        static void ParseString(string s){
            Console.WriteLine("Option 1");

            foreach (Char item in s)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Option 2");

            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                Console.WriteLine(c);    
            }    
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!".ToLower().Contains("ll"));
        }
    }
}


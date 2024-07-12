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

        static bool IsAtEvenIndex(string s, char c){
            if(string.IsNullOrEmpty(s)){
                return false;
            }
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i] == c && i % 2 == 0){
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            //ParseString("Mugi Jatha");
            Console.WriteLine(IsAtEvenIndex("Mugi Jatha", 'g'));
            Console.WriteLine(IsAtEvenIndex("muji jatha", 'j'));
        }
    }
}


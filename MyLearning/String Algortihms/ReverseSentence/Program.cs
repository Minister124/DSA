using System;
using System.Text;


namespace ReverseSentence;

class Program{


    static string ReverseWord(string word){
        char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reverse = new string(charArray);
        return reverse;
    }
    static void Main(string[] args){
        WriteLine("Hello ,World!");
    }
}

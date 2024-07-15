using System;
using ReverseStringSentenceLib;

namespace ReverseSentence;

class Program{
    static void Main(string[] args){
        WriteLine(ReverseStringSentence.ReverseStringWord("Hello"));
        WriteLine(ReverseStringSentence.ReverseSentence("World, I am back"));
    }
}

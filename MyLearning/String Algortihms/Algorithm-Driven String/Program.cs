using System.Text;

namespace Algorithm_Driven_String;

class Program
{
    static string ReverseString(string str)
    {
        if(string.IsNullOrEmpty(str))
        {
            return string.Empty;
        }

        StringBuilder sb = new StringBuilder(str.Length);
        for(int i = str.Length-1; i>=0; i--)
        {
            sb.Append(str[i]);
        }
       return sb.ToString();
    }


    static void Main(string[] args)
    {
        Console.WriteLine(ReverseString("Hello, World!"));
        // string sentence = "Hello, world! Welcome to C# programming.";
        // char separator = ' '; // Space character
        // string [] words = sentence.Split(separator); // returned array
        // foreach(string word in words)
        // {
        //     Console.WriteLine(word);
        // }
    }
}

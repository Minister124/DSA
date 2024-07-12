namespace ReverseStringSentenceLib;

public class ReverseStringSentence
{
    public static string ReverseStringWord(string word){
        Char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return reversed;
    }
}

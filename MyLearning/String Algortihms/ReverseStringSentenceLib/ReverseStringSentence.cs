namespace ReverseStringSentenceLib;

public class ReverseStringSentence
{
    public static string ReverseStringWord(string word){
        Char[] charArray = word.ToCharArray();
        Array.Reverse(charArray);
        string reversed = new string(charArray);
        return reversed;
    }

    //return string with each word reversed
    public static string ReverseSentence(string sentence){
        string[] words = sentence.Split(' ');
        string reversedSentence = "";
        foreach (string word in words){
            reversedSentence += ReverseStringWord(word) + " ";
        }
        return reversedSentence.Trim();
    }
}

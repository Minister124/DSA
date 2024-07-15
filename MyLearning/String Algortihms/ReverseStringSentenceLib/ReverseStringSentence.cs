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

    //Another way to reverse a sentence
    /*public static string ReverseSentence1(string sentence){
        string[] words = sentence.Split(' ');
        string[] reversed = words.Select(ReverseStringWord).ToArray();
        string reversedSentence = string.Join(" ", reversed);
        return reversedSentence;
    }*/
}

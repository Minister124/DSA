using ReverseStringSentenceLib;

namespace ReverseSentenceUnitTest;

public class Test
{
    [Fact]
    static void ReversingStringwordHello(){
        //Arrange: setting up the input and unit for test
        string word = "Hello";
        string expected = "olleH";
        
        //Act: Executing the unit under test
        string result = ReverseStringSentence.ReverseStringWord(word);

        //Assert: Making assertions to compare expected to actual result;
        Assert.Equal(expected, result);
    }

    [Fact]
    static void ReversingStringwordWorld(){
        //Arrange: setting up the input and unit for test
        string word = "World";
        string expected = "dlroW";
        
        //Act: Executing the unit under test
        string result = ReverseStringSentence.ReverseStringWord(word);

        //Assert: Making assertions to compare expected to actual result;
        Assert.Equal(expected, result);
    }

    [Fact]
    static void ReverseSentenceTest(){
        //Arrange: setting up the input and unit for test
        string sentence = "World, I am back";
        string expected = ",dlroW I ma kcab";
        
        //Act: Executing the unit under test
        string result = ReverseStringSentence.ReverseSentence(sentence);

        //Assert: Making assertions to compare expected to actual result;
        Assert.Equal(expected, result);
    }

    [Fact]
    static void ReverseSentenceTest1(){
        //Arrange: Setting up the input and unit for test
        string sentence = "sally is the great worker";
        string expected = "yllas si eht taerg rekrow";

        //Act: Executing the unit under test
        string result = ReverseStringSentence.ReverseSentence(sentence);

        //Assert: Making assertions to compare expected to actual result;
        Assert.Equal(expected, result);
    }
}

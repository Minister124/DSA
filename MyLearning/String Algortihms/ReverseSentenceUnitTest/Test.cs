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
}

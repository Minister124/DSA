using RotateArrayByOneLib;

namespace RotateArrayTest;

public class RotateTest
{
    [Fact]
    static void RotateArraySerial(){
        //Arrange: Setting up the input and unit for test
        int[] number = {1,2,3,4,5,6};
        int[] expected = {2, 3,4,5,6,1};

        //Act: Executing the unit under test
        int[] result = Rotate.RotateArray(number);

        //Assert: Making Assertion to compare expected to actual result
        Assert.Equal(expected, result);
    }
    [Fact]
    static void RotateArrayOne(){
        //Arrange: Setting up the input and unit for test
        int[] number = {1};
        int[] expected = {1};

        //Act: Executing the unit under test
        int[] result = Rotate.RotateArray(number);

        //Assert: Making Assertion to compare expected to actual result
        Assert.Equal(expected, result);
    }

    [Fact]
    static void RotateArrayRandom(){
        //Arrange: Setting up the input and unit for test
        int[] number = {2, 3,4,5,6,1};
        int[] expected = {3,4,5,6,1,2};

        //Act: Executing the unit under test
        int[] result = Rotate.RotateArray(number);

        //Assert: Making Assertion to compare expected to actual result
        Assert.Equal(expected, result);
    }
}

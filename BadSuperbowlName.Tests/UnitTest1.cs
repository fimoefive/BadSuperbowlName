using System;
using Xunit;

namespace BadSuperbowlName.Tests
{
  // Test classes must be public
  public class NumberToRomanNumeralTests
  {
    // Need to have a [Fact] attribute, and needs to be public
    [Fact]
    public void the_number_1_is_translated_into_the_letter_I()
    {
      // Arrange -> context that the test is run inside of
      var numberToTranslate = 1;
      var expectedResult = "I";
      var translator = new NumberTranslator();

      // Act -> the actual thing we're testing, do the thing
      var actualResult = translator.Translate(numberToTranslate);

      // Assert -> lay out the expectations in such a way that, if not met,
      // exceptions are thrown.


      Assert.True(actualResult == expectedResult);
      // Same result different Assert command with more detail
      // Assert.Equal(expectedResult, actualResult);



      // Tests pass if no exceptions are thrown while the test is running
      // Tests fail if any exceptions are thrown while the test is running
      // throw new Exception("Throwing an exception makes tests fail");

    }
    [Fact]
    public void the_number_3_should_be_translated_toII()
    {
      // Arrange
      var numberToTranslate = 3;
      var expectedResult = "III";
      var translator = new NumberTranslator();

      // Act
      var actualResult = translator.Translate(numberToTranslate);

      // Assert
      Assert.Equal(expectedResult, actualResult);

    }

    [Fact]
    public void the_number_4_should_be_translated_toIV()
    {
      // Arrange
      var numberToTranslate = 4;
      var expectedResult = "IV";
      var translator = new NumberTranslator();

      // Act
      var actualResult = translator.Translate(numberToTranslate);

      // Assert
      Assert.Equal(expectedResult, actualResult);

    }
  }
}

using NUnit.Framework;

namespace RomanNumeralsKata_2025.Tests;

[TestFixture]
public class Test_2
{
    private RomanNumeralsConverter _subject;

    [OneTimeSetUp]
    public void SetUp()
    {
        _subject = new RomanNumeralsConverter();
    }

    [TestCase(2, "II")]
    public void ThenTheCorrectRomanNumeralIsReturned(int decimalNumber, string expectedValue)
    {
        var result = _subject.Convert(decimalNumber);
        Assert.That(result, Is.EqualTo(expectedValue));
    }
}
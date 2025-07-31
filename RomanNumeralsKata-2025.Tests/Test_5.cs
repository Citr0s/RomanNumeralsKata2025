using NUnit.Framework;

namespace RomanNumeralsKata_2025.Tests;

[TestFixture]
public class Test_5
{
    private RomanNumeralsConverter _subject;

    [OneTimeSetUp]
    public void SetUp()
    {
        _subject = new RomanNumeralsConverter();
    }

    [TestCase(5, "V")]
    public void ThenTheCorrectRomanNumeralIsReturned(int decimalNumber, string expectedValue)
    {
        var result = _subject.Convert(decimalNumber);
        Assert.That(result, Is.EqualTo(expectedValue));
    }
}
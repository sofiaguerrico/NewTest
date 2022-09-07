namespace Library.Tests;
using NUnit.Framework;
using TestDateFormat;
public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CorrectDateFormat()
    {
        string testDate = "10/11/1997";
        string date=DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(date, "1997-11-10");
    }
    [Test]
    public void IncorrectDateFormat()
    {
        string testDate = "1997/11/19";
        string date=DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(date, "Error");
    }

    [Test]
    public void NullDateFormat()
    {
        string testDate = "";
        string date=DateFormatter.ChangeFormat(testDate);
        Assert.AreEqual(date, "Error");
    }
}
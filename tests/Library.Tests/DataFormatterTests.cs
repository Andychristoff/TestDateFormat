using  TestDateFormat;
namespace Library.Tests;

public class DateFormatterTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        string input = DateFormatter.ChangeFormat("19/05/2003");
        string formatocorrecto = "2003-05-19";
        Assert.That(input, Is.EqualTo(formatocorrecto));
    }

    [Test]

    public void Testformatoincorrecto()
    {
        string input = DateFormatter.ChangeFormat("2003/05/19");
        string formatocorrecto = "";
        Assert.That(input, Is.EqualTo(formatocorrecto));

    }

    [Test]
    public void TestVacio()
    {
        string input = DateFormatter.ChangeFormat("");
        string formatocorrecto = "";
        Assert.That(input, Is.EqualTo(formatocorrecto));

    }
}

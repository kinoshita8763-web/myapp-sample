using MyApp2;
using NUnit.Framework;

namespace MyApp2.Test;

public class CalculatorTests
{
    [Test]
    public void Add_ReturnsCorrectSum()
    {
        var calc = new Calculator();
        Assert.That(calc.Add(2, 3), Is.EqualTo(5));
    }

    [Test]
    public void Subtract_ReturnsCorrectDifference()
    {
        var calc = new Calculator();
        Assert.That(calc.Subtract(3, 2), Is.EqualTo(1));
    }
}
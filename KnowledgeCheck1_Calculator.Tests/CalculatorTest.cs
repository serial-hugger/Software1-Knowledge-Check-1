using JetBrains.Annotations;
using KnowledgeCheck1_Calculator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace KnowledgeCheck1_Calculator.Tests;

[TestClass]
[TestSubject(typeof(Calculator))]
public class CalculatorTest
{

    [TestMethod]
    public void AdditionTest()
    {
        var calculator = new Calculator();
        Assert.AreEqual(5,calculator.Add(1,4));
        Assert.AreEqual(10,calculator.Add(3,7));
        Assert.AreEqual(23,calculator.Add(9,14));
        Assert.AreEqual(15,calculator.Add(14,1));
        Assert.AreEqual(190,calculator.Add(34,156));
    }

    [TestMethod]
    public void SubtractionTest()
    {
        var calculator = new Calculator();
        Assert.AreEqual(-3,calculator.Subtract(1,4));
        Assert.AreEqual(-4,calculator.Subtract(3,7));
        Assert.AreEqual(5,calculator.Subtract(14,9));
        Assert.AreEqual(20,calculator.Subtract(32,12));
        Assert.AreEqual(-122,calculator.Subtract(34,156));
    }
    [TestMethod]
    public void MultiplicationTest()
    {
        var calculator = new Calculator();
        Assert.AreEqual(4,calculator.Multiply(1,4));
        Assert.AreEqual(21,calculator.Multiply(3,7));
        Assert.AreEqual(126,calculator.Multiply(14,9));
        Assert.AreEqual(384,calculator.Multiply(32,12));
        Assert.AreEqual(5304,calculator.Multiply(34,156));
    }
    [TestMethod]
    public void DivisionTest()
    {
        var calculator = new Calculator();
        Assert.AreEqual(0.5,calculator.Divide(1,2));
        Assert.AreEqual(2,calculator.Divide(2,1));
        Assert.AreEqual(8,calculator.Divide(256,32));
        Assert.AreEqual(2,calculator.Divide(10,5));
        Assert.AreEqual(-0.01,calculator.Divide(-10,1000));
    }
}
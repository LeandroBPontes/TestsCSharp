using NUnit.Framework;
using Spark;

namespace SparkyNUnitTest;

[TestFixture]
public class CalculatorNUnitTests
{
    [Test]
    public void AddNumbers_InputTwoInt_GetCorrectAddition()
    {
        
        // Arrange -> initialization
        Calculator calc = new();
        
        //Act -> ação de determinado objeto
        int result = calc.AddNumbers(10, 20);
        
        //Assert -> resultado esperado
        Assert.AreEqual(30, result);
        
    }

    [Test]
    public void IsOddChecker_InputEvenNumber_ReturnFalse()
    {
        Calculator calc = new();
        bool isOdd = calc.IsOddNumber(10);
        Assert.That(isOdd, Is.EqualTo(false));
        Assert.IsFalse(isOdd);
    }
    
    [Test]
    [TestCase(11)]
    [TestCase(13)]
    [TestCase(15)]
    public void IsOddChecker_InputEvenNumber_ReturnTrue(int a)
    {
        Calculator calc = new();
        bool isOdd = calc.IsOddNumber(a);
        Assert.That(isOdd, Is.EqualTo(true));
        Assert.IsTrue(isOdd);
    }
    
    [Test]
    [TestCase(10, ExpectedResult = false)]
    [TestCase(11, ExpectedResult = true)]
    public bool IsOddChecker_InputEvenNumber_ReturnTrueIfOdd(int a)
    {
        Calculator calc = new();
        return calc.IsOddNumber(a);
    }
}
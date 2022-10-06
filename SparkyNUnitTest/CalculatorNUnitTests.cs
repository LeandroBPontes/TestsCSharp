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
    
    [Test]
    [TestCase(5.4, 10.5)]
    [TestCase(5.43, 10.53)]
    public void AddNumbers_InputTwoDouble_GetCorrectAddition(double a, double b)
    {
        
        // Arrange -> initialization
        Calculator calc = new();
        
        //Act -> ação de determinado objeto
        double result = calc.AddNumbersDouble(a, b);
        
        //Assert -> resultado esperado
        Assert.AreEqual(15.9, result, 1);
        
    }
    
    [Test]
    public void OddRanger_InputMinAndMaxRange_ReturnsValidOddNumberRange()
    {
        
        // Arrange -> initialization
        Calculator calc = new();
        List<int> expectedOddRange = new() { 5, 7, 9 };
        
        //Act -> ação de determinado objeto
        List<int> result = calc.GetOddRange(5, 10);
        
        //Assert -> resultado esperado
        Assert.That(result, Is.EquivalentTo(expectedOddRange));
        Assert.AreEqual(expectedOddRange, result);
        Assert.That(result, Does.Contain(7));
        Assert.That(result, Is.Not.Empty);
        Assert.That(result.Count, Is.EqualTo(3));
        Assert.That(result, Has.No.Member(6));
        //Assert.That(result, Is.Ordered.Descending);
        Assert.That(result, Is.Ordered);
        Assert.That(result, Is.Unique);
        
    }

   
}
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
}
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Spark;

namespace SparkyMSTest;

[TestClass]
public class CalculatorMSTests
{
    [TestMethod]
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
using NUnit.Framework;
using Spark;

namespace SparkyNUnitTest;

[TestFixture]
public class CustomerNUnitTests
{
    private Customer customer;

    [SetUp]
    public void Setup()
    {
        customer = new Customer();
    }
    
    [Test]
    public void CombineName_InputFirstAndLastName_ReturnFullName()
    {
        //Arrange
        var customer = new Customer();
        
        //Act
        string fullName = customer.GreetAndCombineNames("Ben", "Spark");
        
        //Assert
        Assert.AreEqual(fullName,"Hello, Ben Spark");
        Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
        //Assert.That(fullName, Does.Contain("ben Spark")); //case sensitive, por isso falha
        Assert.That(fullName, Does.Contain("ben Spark").IgnoreCase); //case insensitive
        Assert.That(fullName, Does.StartWith("Hello,"));
        Assert.That(fullName, Does.EndWith("Spark"));
        Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
       
    }
    [Test]
    public void GreetMessage_NotGreeted_ReturnsNull()
    {
        //Arrange
        var customer = new Customer();
        
        //Act
       // string fullName = customer.GreetAndCombineNames("Ben", "Spark");
        
        //Assert
        Assert.IsNull(customer.Name);
        
    }
    
    [Test]
    public void DiscountCheck_DefaultCustomer_ReturnsDiscountInRange()
    {
        int result = customer.Discount;
        Assert.That(result, Is.InRange(10, 25));
    }
}
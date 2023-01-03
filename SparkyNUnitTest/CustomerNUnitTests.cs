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
        
        Assert.Multiple(() =>
        {
            Assert.AreEqual(fullName,"Hello, Ben Spark");
            Assert.That(fullName, Is.EqualTo("Hello, Ben Spark"));
            //Assert.That(fullName, Does.Contain("ben Spark")); //case sensitive, por isso falha
            Assert.That(fullName, Does.Contain("ben Spark").IgnoreCase); //case insensitive
            Assert.That(fullName, Does.StartWith("Hello,"));
            Assert.That(fullName, Does.EndWith("Spark"));
            Assert.That(fullName, Does.Match("Hello, [A-Z]{1}[a-z]+ [A-Z]{1}[a-z]"));
        });
       
       
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
    
    [Test]
    public void GreetMessage_GreetedWithoutlastName_ReturnsNotNull()
    {
        customer.GreetAndCombineNames("ben", "");
        
        Assert.That(customer.Name, Is.Not.Null);
    }
    
    [Test]
    public void GreetChecker_EmptyFirstName_ThrowsException()
    {
        var exceptionDetails = Assert.Throws<ArgumentException>(() => customer.GreetAndCombineNames("", "Spark"));
        
        //Assert.AreEqual("Empty First Name", exceptionDetails.Message);
        Assert.That(exceptionDetails?.Message, Is.EqualTo("Empty First Name"));
        
        Assert.That(() => customer.GreetAndCombineNames("", "Spark"),
            Throws.ArgumentException.With.Message.EqualTo("Empty First Name"));
    }
    
     
    [Test]
    public void CustomerType_CreateCustomerWithLessThan100Order_ReturnBasicCustomer()
    {
        customer.OrderTotal = 10;
        var result = customer.GetCustomerDetails();
        Assert.That(result, Is.TypeOf<BasicCustomer>());
    }
    
    [Test]
    public void CustomerType_CreateCustomerWithMoreThan100Order_ReturnBasicCustomer()
    {
        customer.OrderTotal = 110;
        var result = customer.GetCustomerDetails();
        Assert.That(result, Is.TypeOf<PlatinumCustumer>());
    }
}
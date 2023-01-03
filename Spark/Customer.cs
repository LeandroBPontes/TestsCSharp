namespace Spark;

public class Customer
{
    public string Name { get; set; }
    public int Discount = 15;
    public int OrderTotal {  get; set; }

    public string GreetAndCombineNames(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName))
        {
            throw new ArgumentException("Empty First Name");
        }

        Name = $"Hello, {firstName} {lastName}";
        Discount = 20;
        return Name;
    }

    public CustomerType GetCustomerDetails()
    {
        if (OrderTotal < 100)
        {
            return new BasicCustomer();
        }

        return new PlatinumCustumer();
    }
}

public class CustomerType
{
}

public class BasicCustomer : CustomerType
{
}

public class PlatinumCustumer : CustomerType
{
}
namespace Spark;

public class Customer
{
    public string Name { get; set; }
    public int Discount = 15;
    public string GreetAndCombineNames(string firstName, string lastName)
    {
        Name = $"Hello, {firstName} {lastName}";
        Discount = 20;
        return Name;
    }
}
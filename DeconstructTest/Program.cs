namespace DeconstructTest;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person p1 = new("a", "p");
        (string a, string b) = p1;
        Console.WriteLine($"1) {a} 2) {b}");
    }
}

public class Person
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; set; }= string.Empty;
    public string LastName { get; set; }=string.Empty;

    public void Deconstruct(out string f, out string l) 
    {
        f=FirstName.ToUpper(); 
        l=LastName.ToUpper();
    }
}
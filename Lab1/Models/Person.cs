namespace Lab1.Models;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone { get; set; }

    public Person(string firstName, string lastName, string phone)
    {
        FirstName = firstName;
        LastName = lastName;
        Phone = phone;
    }

    public virtual string GetInfo()
        => $"{FirstName} {LastName}, тел.: {Phone}";

    public override string ToString() => GetInfo();
}
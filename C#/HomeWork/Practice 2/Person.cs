using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._9_10;

public abstract class Person : IPerson
{
    public string FirstName { get; }
    public string LastName { get; }
    public ContactInfo Contact { get; set; }

    protected Person(string firstName, string lastName, ContactInfo contact)
    {
        ValidationHelper.ValidateNotNullOrWhiteSpace(firstName, nameof(firstName));
        ValidationHelper.ValidateNotNullOrWhiteSpace(lastName, nameof(lastName));

        FirstName = firstName;
        LastName = lastName;
        Contact = contact;
    }

    public abstract void DisplayInfo();
    public abstract Role GetRole();
    protected void DisplayGeneralInfo()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
        Console.WriteLine($"Contact: {Contact}");
    }
}
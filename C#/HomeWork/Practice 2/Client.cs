using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._9_10;

public class Client : Person
{
    public string ClientId { get; }
    public MembershipType Membership { get; set; }
    public Client(string firstName, string lastName, ContactInfo contact, string clientId, MembershipType membership) : base(firstName, lastName, contact)
    {
        ValidationHelper.ValidateNotNullOrWhiteSpace(clientId, nameof(clientId));
        ClientId = clientId;
        Membership = membership;
    }

    public override void DisplayInfo()
    {
        DisplayGeneralInfo();
        Console.WriteLine($"Role: {GetRole()}");
        Console.WriteLine($"Client ID: {ClientId}");
        Console.WriteLine($"Membership: {Membership}");
        Console.WriteLine("-----------------------");
    }

    public override Role GetRole()
    {
        return Role.Client;
    }
}

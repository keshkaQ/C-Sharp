using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._9_10;

public class Trainer : Person
{
    public string TrainerId { get; }
    public List<string> _specializations { get; set; }

    public Trainer(string firstName, string lastName, ContactInfo contact, string trainerId) : base(firstName, lastName, contact)
    {
        ValidationHelper.ValidateNotNullOrWhiteSpace(trainerId, nameof(trainerId));
        TrainerId = trainerId;
        _specializations = new List<string>();
    }

    public void AddSpecializations(string specialization)
    {
        ValidationHelper.ValidateNotNullOrWhiteSpace(specialization, nameof(specialization));
        _specializations.Add(specialization);
    }

    public override void DisplayInfo()
    {
        DisplayGeneralInfo();
        Console.WriteLine($"Role: {GetRole()}");
        Console.WriteLine($"Trainer ID: {TrainerId}");
        Console.WriteLine("Specializations:");
        foreach (var spec in _specializations)
        {
            Console.WriteLine($"- {spec}");
        }
        Console.WriteLine("-----------------------");
    }

    public override Role GetRole()
    {
        return Role.Trainer;
    }
}

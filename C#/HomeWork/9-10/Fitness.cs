//using System;
//using System.Collections.Generic;
//class Program
//{
//    static void Main()
//    {
//        var fitnessCenter = new FitnessCenter();
//        var client1 = new Client
//            ("Ivan", "Ivanov",
//            new ContactInfo { Email = "ivanIvanov@mail.com", PhoneNumber = "8-999-777-33-22" },
//            "Cl001", MembershipType.Monthly);
//        var client2 = new Client
//            ("Petr", "Petrov",
//            new ContactInfo { Email = "petrPetrov@mail.com", PhoneNumber = "8-995-666-88-99" },
//            "Cl002", MembershipType.Yearly);
//        var client3 = new Client
//         ("Dmitry", "Dmitriev",
//         new ContactInfo { Email = "dmitryDmitriev@mail.com", PhoneNumber = "8-922-111-33-44" },
//         "C002", MembershipType.DropIn);

//        fitnessCenter.AddClient(client1);
//        fitnessCenter.AddClient(client2);
//        fitnessCenter.AddClient(client3);

//        var trainer1 = new Trainer("Alexey", "Alexeev", new ContactInfo { Email = "alexeyTrainer@mail.com", PhoneNumber = "8-944-555-66-77" }, "Tr001");
//        trainer1.AddSpecializations("CrossFit");
//        trainer1.AddSpecializations("MMA");
//        fitnessCenter.AddTrainer(trainer1);

//        var trainer2 = new Trainer("Fedor", "Fedorov", new ContactInfo { Email = "fedorTrainer@mail.com", PhoneNumber = "8-955-667-43-22" }, "Tr002");
//        trainer2.AddSpecializations("Yoga");
//        trainer2.AddSpecializations("Tennis");
//        fitnessCenter.AddTrainer(trainer2);

//        fitnessCenter.DisplayAll();
//    }
//}
//public enum MembershipType
//{
//    Monthly,
//    Yearly,
//    DropIn
//}

//public enum Role
//{
//    Client,
//    Trainer
//}

//public interface IPerson
//{
//    void DisplayInfo();
//    Role GetRole();
//}

//public struct ContactInfo
//{
//    public string Email { get; set; }
//    public string PhoneNumber { get; set; }
//    public override string ToString()
//    {
//        return $"Email: {Email}, Phone: {PhoneNumber}";
//    }
//}

//public abstract class Person : IPerson
//{
//    public string FirstName { get; }
//    public string LastName { get; }
//    public ContactInfo Contact { get; set; }

//    protected Person(string firstName, string lastName, ContactInfo contact)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Contact = contact;
//    }

//    public abstract void DisplayInfo();
//    public abstract Role GetRole();
//    protected void DisplayGeneralInfo()
//    {
//        Console.WriteLine($"Name: {FirstName} {LastName}");
//        Console.WriteLine($"Contact: {Contact}");
//    }
//}

//public class Client : Person
//{
//    public string ClientId { get; }
//    public MembershipType Membership { get; }
//    public Client(string firstName, string lastName, ContactInfo contact, string clientId, MembershipType membership) : base(firstName, lastName, contact)
//    {
//        ClientId = clientId;
//        Membership = membership;
//    }

//    public override void DisplayInfo()
//    {
//        DisplayGeneralInfo();
//        Console.WriteLine($"Role: {GetRole()}");
//        Console.WriteLine($"Client ID: {ClientId}");
//        Console.WriteLine($"Membership: {Membership}");
//        Console.WriteLine("-----------------------");
//    }

//    public override Role GetRole()
//    {
//        return Role.Client;
//    }
//}

//public class Trainer : Person
//{
//    public string TrainerId { get; }
//    public List<string> _specializations { get; set; }

//    public Trainer(string firstName, string lastName, ContactInfo contact, string trainerId) : base(firstName, lastName, contact)
//    {
//        TrainerId = trainerId;
//        _specializations = new List<string>();
//    }

//    public void AddSpecializations(string specializations)
//    {
//        _specializations.Add(specializations);
//    }

//    public override void DisplayInfo()
//    {
//        DisplayGeneralInfo();
//        Console.WriteLine($"Role: {GetRole()}");
//        Console.WriteLine($"Trainer ID: {TrainerId}");
//        Console.WriteLine("Specializations:");
//        foreach (var spec in _specializations)
//        {
//            Console.WriteLine($"- {spec}");
//        }
//        Console.WriteLine("-----------------------");
//    }

//    public override Role GetRole()
//    {
//        return Role.Trainer;
//    }
//}

//public class FitnessCenter
//{
//    private List<Client> _clients;
//    private List<Trainer> _trainers;
//    public FitnessCenter()
//    {
//        _clients = new List<Client>();
//        _trainers = new List<Trainer>();
//    }

//    public void AddClient(Client client)
//    {
//        _clients.Add(client);
//    }
//    public void AddTrainer(Trainer trainer)
//    {
//        _trainers.Add(trainer);
//    }

//    public void DisplayAll()
//    {
//        Console.WriteLine("------ FITNESS CENTER -----");
//        Console.WriteLine($"\nTRAINERS ({_trainers.Count})");
//        foreach (var trainer in _trainers)
//        {
//            trainer.DisplayInfo();
//        }

//        Console.WriteLine($"\nCLIENTS ({_clients.Count})");
//        foreach (var client in _clients)
//        {
//            client.DisplayInfo();
//        }
//    }
//}


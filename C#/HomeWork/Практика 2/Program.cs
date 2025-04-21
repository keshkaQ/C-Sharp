//using C_.HomeWork._9_10;
//using System;
//using System.Collections.Generic;
//partial class Program
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

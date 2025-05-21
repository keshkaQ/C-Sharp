using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_.HomeWork._9_10;

public class FitnessCenter
{
    private List<Client> _clients;
    private List<Trainer> _trainers;
    public FitnessCenter()
    {
        _clients = new List<Client>();
        _trainers = new List<Trainer>();
    }

    public void AddClient(Client client)
    {
        _clients.Add(client);
    }
    public void AddTrainer(Trainer trainer)
    {
        _trainers.Add(trainer);
    }

    public void DisplayAll()
    {
        Console.WriteLine("------ FITNESS CENTER -----");
        Console.WriteLine($"\nTRAINERS ({_trainers.Count})");
        foreach (var trainer in _trainers)
        {
            trainer.DisplayInfo();
        }

        Console.WriteLine($"\nCLIENTS ({_clients.Count})");
        foreach (var client in _clients)
        {
            client.DisplayInfo();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;
namespace Server.Data
{
    public interface IClientRepo
    {
        IEnumerable<Client> GetClients();
        Client GetClientbyId(int ID);
        void CreateClient(Client client);
        void UpdateClient(Client client);
        void DeleteClient(Client client);
    }
}

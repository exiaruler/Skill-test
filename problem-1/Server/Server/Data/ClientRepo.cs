using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;
namespace Server.Data
{
    public class ClientRepo: IClientRepo
    {
        public void CreateClient(Client client)
        {
            throw new NotImplementedException();
        }

        public void DeleteClient(Client client)
        {
            throw new NotImplementedException();
        }

        public Client GetClientbyId(int ID)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Client>GetClients()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Server.Models;
namespace Server.Data
{
    public class SqlClientRepo : IClientRepo
    {
        private readonly ClientContext _context;
       
        public SqlClientRepo(ClientContext context)
        {
            _context = context;
        }

        // crud
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

        public IEnumerable<Client> GetClients()
        {
            return _context.Clients.ToList();
        }

        public void UpdateClient(Client client)
        {
            throw new NotImplementedException();
        }
    }
}

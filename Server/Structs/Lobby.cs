using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrawServer.Structs
{
    class Lobby
    {


        private List<Client> _clients;
        private Client _hostClient;
        public Lobby(int lobbyID, List<Client> clients, Client hostClient)
        {
            
        }

        public int Players()
        {
            if (_clients != null)
            {
                return _clients.Count;
            }
            return 0;
        }

        public Client Host()
        {
            return null;
        }
    }
}

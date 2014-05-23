using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrawServer.Structs
{
    class Lobby
    {
        private bool disposed = false;

        private List<Client> _clients;
        private Client _hostClient;
        public Lobby(int lobbyID, Client hostClient)
        {
            _clients = new List<Client>();
            _clients.Add(hostClient);
            _hostClient = hostClient;
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

        private bool ShouldDispose()
        {
            bool shouldDispose = true;
            foreach (var client in _clients)
            {
                if (client.isConnected())
                {
                    shouldDispose = false;
                    break;
                }
            }

            return shouldDispose;

        }
    }
}

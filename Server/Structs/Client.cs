using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperWebSocket;

namespace QuickDrawServer.Structs
{
    class Client
    {
        private DateTime _lastping;
        public WebSocketSession WebSocketSession;
        public Client(WebSocketSession webSocketSession)
        {
            WebSocketSession = webSocketSession;
            
        }

        public void PingReply()
        {
            _lastping = new DateTime();
        }

        public bool IsConnected()
        {
            if (DateTime.Now - _lastping < new TimeSpan(0, 0, 15))
            {
                return true;
            }
                return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickDrawServer.Structs;

namespace QuickDrawServer.Commands
{
    class Ping
    {
        public static void ReceivePong(string msg)
        {
            Console.WriteLine("Pong");
        }
        public static void SendPing(Client client)
        {
            Websocket.SendMessage();
        }
    }
}

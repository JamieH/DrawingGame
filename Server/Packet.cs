using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuickDrawServer.Structs;

namespace QuickDrawServer
{
    public enum Type
    {
        PingPong
    }

    internal static class Packet
    {
        private static Dictionary<Type, Action<string>> _actions = new Dictionary<Type, Action<string>>(); 

        public static void RegisterCallback(Type packetType, Action<string> action)
        {
            _actions.Add(packetType, action);
        }

        public static void PacketHandler(Type header, Client sender, string msg)
        {
            _actions[header].Invoke(msg);
        }
    }
}

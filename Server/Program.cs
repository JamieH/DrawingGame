using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace QuickDrawServer
{
    class Program
    {
        static void Main(string[] args)
        {
            Websocket.Start(9000);

            while (true)
            {
                Thread.Sleep(1000);
            }
        }
    }
}

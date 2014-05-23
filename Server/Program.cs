using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrawServer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Websocket.Start(9000);

            }
        }
    }
}

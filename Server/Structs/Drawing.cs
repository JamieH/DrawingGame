using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickDrawServer.Structs
{
    
    
    class Drawing
    {
        private Client _drawer;
        private Stream _image;
        public Drawing(Stream imageStream, Client drawer)
        {
            _drawer = drawer;
            _image = imageStream;
        }
    }
}

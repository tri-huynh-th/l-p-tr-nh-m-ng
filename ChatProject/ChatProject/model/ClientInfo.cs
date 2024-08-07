using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;

namespace ChatProject.model
{
    internal class ClientInfo
    {

        public string name { get; set; }
        public TcpClient tpc { get; set; }

    }
}

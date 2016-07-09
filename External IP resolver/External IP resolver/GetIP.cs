using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace External_IP_resolver
{
    public class GetIP
    {
        //string extIP = new WebClient().DownloadString("http://icanhazip.com");
        public string IP()
        {
            string IP = new WebClient().DownloadString("http://icanhazip.com");
            return IP;
        }
    }
}

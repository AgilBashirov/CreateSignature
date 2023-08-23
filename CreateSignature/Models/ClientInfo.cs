using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSignature.Models
{
    public class ClientInfo
    {
        public int ClientId { get; set; }
        public string ClientName { get; set; }
        public string IconURI { get; set; }
        public string Callback { get; set; }
        public string[]? HostName { get; set; }
        public string? RedirectURI { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace CreateSignature.Models
{
    public class Contract
    {
        public Contract()
        {
            SignableContainer = new SignableContainer();
            Header = new Header();
        }
        public SignableContainer SignableContainer { get; set; }
        public Header Header { get; set; }
    }
}

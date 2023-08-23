using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSignature.Models
{
    public class SignableContainer
    {
        public SignableContainer()
        {
            ProtoInfo = new ProtoInfo();
            OperationInfo = new OperationInfo();
            ClientInfo = new ClientInfo();
            DataInfo = new DataInfo();
        }
        public ProtoInfo ProtoInfo { get; set; }
        public OperationInfo OperationInfo { get; set; }
        public ClientInfo ClientInfo { get; set; }
        public DataInfo DataInfo { get; set; }
    }
}

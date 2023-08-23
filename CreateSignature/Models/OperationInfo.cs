using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateSignature.Models
{
    public class OperationInfo
    {
        public OperationInfo()
        {
            Assignee = new List<string>();
        }

        public string Type { get; set; }
        public string OperationId { get; set; }
        public long NbfUTC { get; set; }
        public long ExpUTC { get; set; }
        public List<string> Assignee { get; set; }
    }
}

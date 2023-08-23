using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace CreateSignature.Models
{
    public class Header
    {
        [JsonPropertyName("AlgName")]
        public string AlgorithmName { get; set; }

        [JsonPropertyName("Signature")]
        public byte[] Signature { get; set; }
    }
}

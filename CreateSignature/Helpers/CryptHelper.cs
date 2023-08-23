using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CreateSignature.Helpers
{
    public static class CryptHelper
    {
        public static byte[] ComputeSha256HashAsByte(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
                return sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
        }
        public static byte[] GetHMAC(byte[] computedSha256AsByte, String key)
        {
            using (HMACSHA256 hmac = new HMACSHA256(Encoding.UTF8.GetBytes(key)))
            {
                return hmac.ComputeHash(computedSha256AsByte);
            }
        }
    }
}

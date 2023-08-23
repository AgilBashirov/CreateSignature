using CreateSignature.Enum;
using CreateSignature.Models;
using System.Text;
using System.Text.Json;

namespace CreateSignature.Helpers
{
    public static class SignatureHelper
    {

        public static Models.Contract CreateContract(string operationId, OperationTypeEnum operationType)
        {
            Models.Contract contract = new()
            {
                SignableContainer = new SignableContainer
                {
                    ProtoInfo = new ProtoInfo
                    {
                        Name = "web2app",
                        Version = "1.3"
                    },
                    OperationInfo = new OperationInfo
                    {
                        OperationId = operationId,
                        Type = operationType is OperationTypeEnum.Auth ? "Auth" : "Sign",
                        NbfUTC = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds(),
                        ExpUTC = new DateTimeOffset(DateTime.UtcNow.AddMinutes(200))
                            .ToUnixTimeSeconds(),
                        Assignee = new List<string>()
                    },
                    ClientInfo = new ClientInfo
                    {
                        ClientId = 1,
                        ClientName = "ScanMe APP",
                        IconURI = "Icon Pulic URL",
                        Callback = "callbackURL",
                        HostName = null
                    },
                },
                Header = new Header
                {
                    AlgorithmName = "HMACSHA256"
                }
            };

            return contract;
        }
        public static byte[] CreateSignature<T>(T model) where T : SignableContainer
        {
            var json = JsonSerializer.Serialize(model).Trim();

            var computedHashAsByte = CryptHelper.ComputeSha256HashAsByte(json);
            var hMac = CryptHelper.GetHMAC(computedHashAsByte, "MasterKey");
            return hMac;
        }

        public static string EncodeContract(Contract model)
        {
            var json = JsonSerializer.Serialize(model);

            string base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(json));
            byte[] byteArray = Convert.FromBase64String(base64);
            string fileFormBase64 = Convert.ToBase64String(byteArray);
            return fileFormBase64;
        }
    }
}

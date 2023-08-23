// See https://aka.ms/new-console-template for more information
using CreateSignature.Enum;
using CreateSignature.Helpers;
using CreateSignature.Models;
using System.Reflection;
using System.Text.Json;

string operationId = "operationId";
OperationTypeEnum operationType = OperationTypeEnum.Auth;

Contract contract = SignatureHelper.CreateContract(operationId, operationType);
var json = JsonSerializer.Serialize(contract).Trim();
string jsonString = json.ToString();
var signature = SignatureHelper.CreateSignature(contract.SignableContainer);
contract.Header.Signature = signature;
var encodedContract = SignatureHelper.EncodeContract(contract);
Console.WriteLine(encodedContract);


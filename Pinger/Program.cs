using Pinger;
using System.Net.NetworkInformation;
using System.Text;

//Pinging Google DNS Server 

PingService pingService = new PingService();
var response = pingService.SendPing();
Console.WriteLine(response);
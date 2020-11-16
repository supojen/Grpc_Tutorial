using Grpc.Net.Client;
using System;
using System.Threading.Tasks;
using Server.Protos;
using Grpc.Core;

namespace Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var md = new Metadata
            {
                { "username" , "po" },
                { "role", "administrator" }
            };



            using (var channel = GrpcChannel.ForAddress("https://localhost:5001"))
            {
                var client = new EmployeeService.EmployeeServiceClient(channel);

                var response = await client.GetByNoAsync(new GetByNoRequest
                {
                    No = 1994
                },md);


                Console.WriteLine($"Response message = {response}");
            }
        }
    }
}

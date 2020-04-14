using Grpc.Net.Client;
using GrpcServer;
using System;
using System.Threading.Tasks;

namespace GrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Please type your name: ");
            var input = new HelloRequest { Name = Console.ReadLine() };

            var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new Greeter.GreeterClient(channel);

             await client.SayHelloAsync(input);

          //  Console.WriteLine(reply.Message);

             Console.ReadLine();
        }
    }
}

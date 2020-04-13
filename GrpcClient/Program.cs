﻿using Grpc.Net.Client;
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

            var reply = await client.SayHelloAsync(input);

            Console.WriteLine(reply.Message);

            //var channel = GrpcChannel.ForAddress("https://localhost:5001");
            //var customerClient = new Customer.CustomerClient(channel);

            //var clientRequested = new CustomerLookUpModel { UserId = 3 } ;

            //var customer = await customerClient.GetCustomerInfoAsync(clientRequested);

            //Console.WriteLine($"{customer.FirstName}{customer.LastName}");

            Console.ReadLine();
        }
    }
}

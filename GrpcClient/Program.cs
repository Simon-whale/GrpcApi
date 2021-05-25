using System;
using Grpc.Core;

namespace GrpcClient
{
    //TODO: Look at async calls
    class Program
    {
        const string target = "localhost:5002";

        static void Main(string[] args)
        {
            Channel channel = new Channel(target, ChannelCredentials.Insecure);
            channel.ConnectAsync().ContinueWith((task) =>
            {
                if (task.Status == System.Threading.Tasks.TaskStatus.RanToCompletion)
                    Console.WriteLine("The client connected successfully");
            });

            ShowHelloWorld(channel);
            ShowCalculator(channel);

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }

        private static void ShowHelloWorld(Channel channel)
        {
            var client = new Helloworld.helloWorldService.helloWorldServiceClient(channel);
            var hello = new Helloworld.person()
            {
                Title = "Mr",
                Firstname = "Simon",
                Surname = "Whale"
            };

            var request = new Helloworld.sayHelloRequest() { To = hello };
            var response = client.person(request);

            Console.WriteLine(response.Result);
        }

        private static void ShowCalculator(Channel channel)
        {
            var client = new Sums.SumsService.SumsServiceClient(channel);
            var calc = new Sums.Sums()
            {
                First = 5,
                Second = 8
            };

            var request = new Sums.SumsRequest() { NumbersToAdd = calc };
            var response = client.Sums(request);

            Console.WriteLine(response.Result);
        }
    }
}

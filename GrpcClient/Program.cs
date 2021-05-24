using System;
using Grpc.Core;

namespace GrpcClient
{
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

            var client = new Sums.SumsService.SumsServiceClient(channel);
            var calc = new Sums.Sums()
            {
                First = 5,
                Second = 8
            };

            var request = new Sums.SumsRequest() { NumbersToAdd = calc };
            var response = client.Sums(request);

            Console.WriteLine(response.Result);

            channel.ShutdownAsync().Wait();
            Console.ReadKey();
        }
    }
}

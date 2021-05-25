using System;
using System.Threading.Tasks;
using Grpc.Core;
using Helloworld;
using static Helloworld.helloWorldService;

namespace GrpcApi.Services
{
    public class HelloWorldServiceImpl : helloWorldServiceBase
    {
        public override Task<sayHelloResponse> person(sayHelloRequest request, ServerCallContext context)
        {
            var result = $"Hello {request.To.Firstname} {request.To.Surname} how are you?";
            return Task.FromResult(new sayHelloResponse() { Result = result });
        }
    }
}

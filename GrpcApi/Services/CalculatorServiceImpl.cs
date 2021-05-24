using System.Threading.Tasks;
using Grpc.Core;
using Sums;
using static Sums.SumsService;

namespace GrpcApi.Services
{
    public class CalculatorServiceImpl : SumsServiceBase
    {
        public override Task<SumsResponse> Sums(SumsRequest request, ServerCallContext context)
        {
            var result = request.NumbersToAdd.First + request.NumbersToAdd.Second;
            return Task.FromResult(new SumsResponse() { Result = result });
        }
    }
}

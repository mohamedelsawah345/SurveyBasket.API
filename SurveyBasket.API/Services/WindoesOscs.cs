using System.Reflection.Metadata.Ecma335;

namespace SurveyBasket.API.Services
{
    public class WindoesOscs : IOperationTransiente, IOperationScoped, IOperationSingelton
    {
        public WindoesOscs()
        {
            OperationId = Guid.NewGuid().ToString()[^4..];
        }

        public string OperationId { get; }


        public string RunApp() => "From Windows";
    }
}

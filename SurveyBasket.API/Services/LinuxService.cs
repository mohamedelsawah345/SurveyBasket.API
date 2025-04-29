namespace SurveyBasket.API.Services
{
    public class LinuxService : IOperationTransiente,IOperationScoped,IOperationSingelton
    {
        public LinuxService()
        {
            OperationId = Guid.NewGuid().ToString()[^4..];
        }
        public string OperationId { get; }

        public string RunApp() => "From Linux";
    }
}

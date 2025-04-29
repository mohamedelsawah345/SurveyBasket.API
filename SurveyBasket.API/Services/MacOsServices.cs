namespace SurveyBasket.API.Services
{
    public class MacOsServices: IOperationTransiente, IOperationScoped, IOperationSingelton
    {
        public MacOsServices()
        {
            OperationId = Guid.NewGuid().ToString();
        }

        public string OperationId { get; }


        public string RunApp() => "From MacOs";
    }
}

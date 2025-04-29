namespace SurveyBasket.API
{
    public interface IOs
    {
        public string RunApp();

        public string OperationId { get; }
    }
    public interface IOperationTransiente :IOs
    {
    }
    public interface IOperationScoped : IOs
    {

    }
    public interface IOperationSingelton : IOs
    {
    }
}

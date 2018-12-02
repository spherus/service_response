namespace Spherus
{
    public class ServiceResponse: IServiceResponse
    {
        public ServiceResponse()
        {
            Status = new ServiceStatus();
        }

        public ServiceStatus Status { get; set; }
    }
}
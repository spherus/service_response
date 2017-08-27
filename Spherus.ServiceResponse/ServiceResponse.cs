namespace Spherus
{
    public class ServiceResponse
    {
        public ServiceResponse()
        {
            Status = new ServiceStatus();
        }

        public ServiceStatus Status { get; set; }
    }
}
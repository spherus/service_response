namespace Spherus
{
    public class ServiceResponse<T>
    {
        public ServiceResponse()
        {
            Status = new ServiceStatus();
        }

        public T ObjectResult { get; set; }

        public ServiceStatus Status { get; set; }
    }
}
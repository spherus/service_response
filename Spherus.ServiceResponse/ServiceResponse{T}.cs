using Spherus;

namespace Spherus
{
    public class ServiceResponse<T>: IServiceResponse
    {
        public ServiceResponse()
        {
            Status = new ServiceStatus();
        }

        public T ObjectResult { get; set; }

        public ServiceStatus Status { get; set; }
    }
}
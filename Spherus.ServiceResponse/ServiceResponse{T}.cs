namespace Spherus
{
    public class ServiceResponse<T>: IServiceResponse
    {
        public ServiceResponse()
        {
            Status = new ServiceStatus();
        }

        public ServiceStatus Status { get; set; }

        public T Result { get; set; }
    }
}
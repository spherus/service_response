namespace Spherus
{
    public class ServiceStatus
    {
        public ServiceStatus()
        {
            Code = 1;
            Message = "ServiceError";
        }


        public int Code { get; set; }

        public string Message { get; set; }
    }
}
namespace EcommerceBlazorWebApp.Services
{

    public class ServiceResponse<T>
    {
        public ServiceResponse() { }

        public ServiceResponse(T data, bool success, string message)
        {

            this.Data = data;
            this.Success = success;
            this.Message = message;

        }

        public T? Data { get; set; }

        public bool Success { get; set; } = true;

        public string Message { get; set; } = string.Empty;
    }
}

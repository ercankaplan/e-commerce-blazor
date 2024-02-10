namespace EcommerceBlazorAPI.Model
{
    public class ApiResponse<T>
    {
        public ApiResponse() { }

        public ApiResponse(T data, bool success, string message)
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

namespace VedettAllatok.Models
{
    public class ApiResponse<T>(T data)
    {
        public T Data { get; set; } = data;
    }
    
    public static class CreateApiResponse
    {
        public static ApiResponse<T> Create<T>(T data) => new ApiResponse<T>(data);
    }
}

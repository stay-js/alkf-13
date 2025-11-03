namespace VedettAllatokLib
{
    public class ApiResponse<T>(T data)
    {
        public T Data { get; init; } = data;
    }

    public static class CreateApiResponse
    {
        public static ApiResponse<T> Create<T>(T data) => new(data);
    }
}

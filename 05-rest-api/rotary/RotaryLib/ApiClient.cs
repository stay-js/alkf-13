using System.Text.Json;

namespace RotaryLib
{
    public class ApiClient
    {
        public static readonly HttpClient HttpClient = new();

        private readonly JsonSerializerOptions _JsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public async Task<T> GetAsync<T>(string endpoint)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, "http://localhost:5252/api" + endpoint);

            var response = await HttpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse, _JsonOptions)!;
        }
    }
}

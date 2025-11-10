using System.Text;
using System.Text.Json;

namespace RotaryLib
{
    public class ApiClient
    {
        public static readonly HttpClient HttpClient = new();
        public const string API_URL = "http://localhost:5252/api";

        private readonly JsonSerializerOptions _JsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public async Task<T> GetAsync<T>(string endpoint)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, API_URL + endpoint);

            var response = await HttpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();
            return JsonSerializer.Deserialize<T>(jsonResponse, _JsonOptions)!;
        }

        public async Task<T?> PostAsync<T>(string endpoint, object payload)
        {
            using var request = new HttpRequestMessage(HttpMethod.Post, API_URL + endpoint);

            string json = JsonSerializer.Serialize(payload, _JsonOptions);
            request.Content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await HttpClient.SendAsync(request);

            string jsonResponse = await response.Content.ReadAsStringAsync();

            if (string.IsNullOrWhiteSpace(jsonResponse)) return default;

            return JsonSerializer.Deserialize<T>(jsonResponse, _JsonOptions)!;
        }
    }
}

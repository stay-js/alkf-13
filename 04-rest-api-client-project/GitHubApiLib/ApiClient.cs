using System.Text.Json;

namespace GitHubApiLib
{
    public class ApiClient
    {
        public static readonly HttpClient HttpClient = new();

        private readonly JsonSerializerOptions _JsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };

        public static async Task<string> GetStringAsync(string endpoint)
        {
            using var request = new HttpRequestMessage(HttpMethod.Get, "https://api.github.com" + endpoint);

            request.Headers.UserAgent.ParseAdd("GitHubAPIProject");

            var response = await HttpClient.SendAsync(request);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }

        public async Task<T> GetAsync<T>(string endpoint)
        {
            string jsonResponse = await GetStringAsync(endpoint);
            return JsonSerializer.Deserialize<T>(jsonResponse, _JsonOptions)!;
        }
    }
}

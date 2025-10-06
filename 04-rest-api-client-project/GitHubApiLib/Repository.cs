using System.Text.Json.Serialization;

namespace GitHubApiLib
{
    public class Repository
    {
        public required int Id { get; init; }
        public required string Name { get; init; }
        public required string Description { get; init; }
        public string? Language { get; init; }

        [JsonPropertyName("html_url")]
        public required string HTMLUrl { get; init; }
    }
}

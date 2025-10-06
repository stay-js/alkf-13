using System.Text.Json.Serialization;

namespace GitHubApiLib
{
    public class User
    {
        public required string Login { get; init; }
        public required string Url { get; init; }
        public required string Name { get; init; }
        public required string Bio { get; init; }

        [JsonPropertyName("avatar_url")]
        public required string AvatarUrl { get; init; }

        public string FormattedName => string.IsNullOrWhiteSpace(Name)
            ? Login
            : Name;

        public string FormattedBio => string.IsNullOrWhiteSpace(Bio)
            ? "No user bio."
            : Bio;
    }
}

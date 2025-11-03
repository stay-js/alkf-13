using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetByCategory : EndpointWithoutRequest<ApiResponse<IEnumerable<Animal>>>
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsGetByCategory(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Get("animalsByCategory/{category}");
            AllowAnonymous();
            Description(b => b
                .Produces(200)
                .Produces(400));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            string? category = Route<string>("category");
            if (string.IsNullOrEmpty(category))
            {
                await Send.StatusCodeAsync(400, ct);
                return;
            }
            
            var response = _animalStore.GetByCategory(category);
            
            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

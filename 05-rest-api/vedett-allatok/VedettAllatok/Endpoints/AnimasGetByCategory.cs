using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetByCategory(AnimalStore animalStore)
        : EndpointWithoutRequest<IEnumerable<Animal>>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Get("animalsByCategory/{category}");
            AllowAnonymous();
            Description(b => b
                .Produces<IEnumerable<Animal>>(200)
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

            await Send.OkAsync(response, ct);
        }
    }
}

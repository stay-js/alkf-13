using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetAll(AnimalStore animalStore)
        : EndpointWithoutRequest<ApiResponse<IEnumerable<Animal>>>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Get("animals");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _animalStore.GetAll();

            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetByYear(AnimalStore animalStore)
        : EndpointWithoutRequest<ApiResponse<IEnumerable<Animal>>>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Get("animalsByYear/{year}");
            AllowAnonymous();
            Description(b => b
                .Produces(200)
                .Produces(400));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int year = Route<int>("year");

            var response = _animalStore.GetByYear(year);

            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

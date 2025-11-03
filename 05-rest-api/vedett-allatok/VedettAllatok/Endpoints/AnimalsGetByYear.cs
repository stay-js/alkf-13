using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetByYear : EndpointWithoutRequest<ApiResponse<IEnumerable<Animal>>>
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsGetByYear(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Get("animalsByYear/{year}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int year = Route<int>("year");
            
            var response = _animalStore.GetByYear(year);
            
            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

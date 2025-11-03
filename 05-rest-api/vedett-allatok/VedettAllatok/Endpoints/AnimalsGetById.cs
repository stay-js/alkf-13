using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetById : EndpointWithoutRequest<ApiResponse<Animal?>>
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsGetById(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Get("/api/animalsById/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int id = Route<int>("id");
            var response = _animalStore.GetById(id);
            
            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetById : EndpointWithoutRequest<ApiResponse<Animal>>
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsGetById(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Get("animalsById/{id}");
            AllowAnonymous();
            Description(b => b
                .Produces(200)
                .Produces(400)
                .Produces(404));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int id = Route<int>("id");
            var response = _animalStore.GetById(id);
            
            if (response is null)
            {
                await Send.NotFoundAsync(ct);
                return;
            }
            
            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

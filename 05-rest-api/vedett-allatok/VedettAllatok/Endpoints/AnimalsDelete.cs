using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsDelete : EndpointWithoutRequest
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsDelete(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Delete("/api/animals/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int id = Route<int>("id");
            
            if (_animalStore.GetById(id) is null) await Send.NotFoundAsync(ct);

            _animalStore.Delete(id);
            
            await Send.StatusCodeAsync(204, ct);
        }
    }
}

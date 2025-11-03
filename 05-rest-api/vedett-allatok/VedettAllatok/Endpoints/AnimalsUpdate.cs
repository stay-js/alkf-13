using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsUpdate : Endpoint<AnimalData>
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsUpdate(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Put("animals/{id}");
            AllowAnonymous();
        }

        public override async Task HandleAsync(AnimalData req, CancellationToken ct)
        {
            int id = Route<int>("id");
            
            if (_animalStore.GetById(id) is null) await Send.NotFoundAsync(ct);

            bool isUpdated = _animalStore.Update(id, req);
            if (!isUpdated) await Send.StatusCodeAsync(500, ct);
            
           await Send.StatusCodeAsync(200, ct);
        }
    }
}

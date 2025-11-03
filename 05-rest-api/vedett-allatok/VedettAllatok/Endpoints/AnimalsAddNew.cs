using FastEndpoints;
using VedettAllatok.Models;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsAddNew : Endpoint<AnimalData>
    {
        private readonly AnimalStore _animalStore;
        
        public AnimalsAddNew(AnimalStore animalStore) => _animalStore = animalStore;

        public override void Configure()
        {
            Post("animals");
            AllowAnonymous();
        }

        public override async Task HandleAsync(AnimalData req, CancellationToken ct)
        {
            _animalStore.AddNew(req);
            await Send.StatusCodeAsync(201, ct);
        }
    }
}

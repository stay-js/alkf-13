using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsAddNew(AnimalStore animalStore) : Endpoint<AnimalData>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Post("animals");
            AllowAnonymous();
            Description(b => b.Produces(201));
        }

        public override async Task HandleAsync(AnimalData req, CancellationToken ct)
        {
            _animalStore.AddNew(req);
            await Send.StatusCodeAsync(201, ct);
        }
    }
}

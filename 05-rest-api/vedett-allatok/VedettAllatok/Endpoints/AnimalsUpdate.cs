using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsUpdate(AnimalStore animalStore) : Endpoint<AnimalData>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Put("animals/{id}");
            AllowAnonymous();
            Description(b => b
                .Produces(200)
                .Produces(400)
                .Produces(404));
        }

        public override async Task HandleAsync(AnimalData req, CancellationToken ct)
        {
            int id = Route<int>("id");

            bool isUpdated = _animalStore.Update(id, req);
            if (!isUpdated) await Send.NotFoundAsync(ct);

            await Send.StatusCodeAsync(200, ct);
        }
    }
}

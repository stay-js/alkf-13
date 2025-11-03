using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsDelete(AnimalStore animalStore) : EndpointWithoutRequest
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Delete("animals/{id}");
            AllowAnonymous();
            Description(b => b
                .Produces(204)
                .Produces(400)
                .Produces(404));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int id = Route<int>("id");

            bool isDeleted = _animalStore.Delete(id);
            if (!isDeleted) await Send.NotFoundAsync(ct);

            await Send.StatusCodeAsync(204, ct);
        }
    }
}

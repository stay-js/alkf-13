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

            if (_animalStore.GetById(id) is null)
            {
                await Send.NotFoundAsync(ct);
                return;
            }

            _animalStore.Delete(id);

            await Send.StatusCodeAsync(204, ct);
        }
    }
}

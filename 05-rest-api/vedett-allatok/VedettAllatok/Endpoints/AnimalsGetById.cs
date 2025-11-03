using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetById(AnimalStore animalStore)
        : EndpointWithoutRequest<Animal>
    {
        private readonly AnimalStore _animalStore = animalStore;

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

            await Send.OkAsync(response, ct);
        }
    }
}

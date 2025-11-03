using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class AnimalsGetAll(AnimalStore animalStore)
        : EndpointWithoutRequest<IEnumerable<Animal>>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Get("animals");
            AllowAnonymous();
            Description(b => b.Produces<IEnumerable<Animal>>(200));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _animalStore.GetAll();

            await Send.OkAsync(response, ct);
        }
    }
}

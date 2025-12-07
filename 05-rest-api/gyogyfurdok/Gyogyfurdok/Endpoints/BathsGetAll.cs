using FastEndpoints;
using GyogyfurdokLib;

namespace Gyogyfurdok.Endpoints
{
    public class BathsGetAll(BathsStore bathsStore)
        : EndpointWithoutRequest<IEnumerable<Bath>>
    {
        private readonly BathsStore _bathsStore = bathsStore;

        public override void Configure()
        {
            Get("baths");
            AllowAnonymous();
            Description(b => b.Produces<IEnumerable<Bath>>(200));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _bathsStore.GetAll();

            await Send.OkAsync(response, ct);
        }
    }
}

using FastEndpoints;
using GyogyfurdokLib;

namespace Gyogyfurdok.Endpoints
{
    public class CountiesGetAll(BathsStore bathsStore)
        : EndpointWithoutRequest<IEnumerable<string>>
    {
        private readonly BathsStore _bathsStore = bathsStore;

        public override void Configure()
        {
            Get("megye");
            AllowAnonymous();
            Description(b => b.Produces<IEnumerable<string>>(200));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _bathsStore
                .GetAll()
                .Select(x => x.County)
                .Distinct()
                .Order();

            await Send.OkAsync(response, ct);
        }
    }
}

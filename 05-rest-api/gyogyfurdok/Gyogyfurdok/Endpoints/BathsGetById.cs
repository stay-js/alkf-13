using FastEndpoints;
using GyogyfurdokLib;

namespace Gyogyfurdok.Endpoints
{
    public class BathsGetById(BathsStore bathsStore)
        : EndpointWithoutRequest<Bath>
    {
        private readonly BathsStore _bathsStore = bathsStore;

        public override void Configure()
        {
            Get("furdo/{id}");
            AllowAnonymous();
            Description(b => b
                .Produces<Bath>(200)
                .Produces(400)
                .Produces(404));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int id = Route<int>("id");
            var response = _bathsStore.GetById(id);

            if (response is null)
            {
                await Send.NotFoundAsync(ct);
                return;
            }

            await Send.OkAsync(response, ct);
        }
    }
}

using FastEndpoints;
using GyogyfurdokLib;

namespace Gyogyfurdok.Endpoints
{
    public class BathsAddNew(BathsStore bathsStore) : Endpoint<Bath>
    {
        private readonly BathsStore _bathsStore = bathsStore;

        public override void Configure()
        {
            Post("furdo");
            AllowAnonymous();
            Description(b => b
             .Produces(201)
             .Produces<List<string>>(400));
        }

        public override async Task HandleAsync(Bath req, CancellationToken ct)
        {
            if (!_bathsStore.AddNew(req, out var errors))
            {
                await Send.ResponseAsync(errors, 400, ct);
                return;
            }

            await Send.StatusCodeAsync(201, ct);
        }
    }
}

using FastEndpoints;
using RotaryLib;

namespace Rotary.Endpoints
{
    public class ResultsAddNew(ResultsStore resultsStore) : Endpoint<Result>
    {
        private readonly ResultsStore _resultsStore = resultsStore;

        public override void Configure()
        {
            Post("results");
            AllowAnonymous();
            Description(b => b
                .Produces(201)
                .Produces<List<string>>(400));
        }

        public override async Task HandleAsync(Result req, CancellationToken ct)
        {
            if (!_resultsStore.AddNew(req, out var errors))
            {
                await Send.ResponseAsync(errors, 400, ct);
                return;
            }

            await Send.StatusCodeAsync(201, ct);
        }
    }
}

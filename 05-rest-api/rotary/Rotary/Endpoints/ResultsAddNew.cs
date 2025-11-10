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
                .Produces(400));
        }

        public override async Task HandleAsync(Result req, CancellationToken ct)
        {
            bool result = _resultsStore.AddNew(req);
            await Send.StatusCodeAsync(result ? 201 : 400, ct);
        }
    }
}

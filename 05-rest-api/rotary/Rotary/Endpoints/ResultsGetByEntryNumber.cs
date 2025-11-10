using FastEndpoints;
using RotaryLib;

namespace Rotary.Endpoints
{
    public class ResultsGetByEntryNumber(ResultsStore resultsStore)
        : EndpointWithoutRequest<Result>
    {
        private readonly ResultsStore _resultsStore = resultsStore;

        public override void Configure()
        {
            Get("results/{entryNumber}");
            AllowAnonymous();
            Description(b => b
                 .Produces<Result>(200)
                 .Produces(400)
                 .Produces(404));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            int entryNumber = Route<int>("entryNumber");
            var response = _resultsStore.GetByEntryNumber(entryNumber);

            if (response is null)
            {
                await Send.NotFoundAsync(ct);
                return;
            }

            await Send.OkAsync(response, ct);
        }
    }
}

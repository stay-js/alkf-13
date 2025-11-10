using FastEndpoints;
using RotaryLib;

namespace Rotary.Endpoints
{
    public class ResultsGetAll(ResultsStore resultsStore)
        : EndpointWithoutRequest<IEnumerable<Result>>
    {
        private readonly ResultsStore _resultsStore = resultsStore;

        public override void Configure()
        {
            Get("results");
            AllowAnonymous();
            Description(b => b.Produces<IEnumerable<Result>>(200));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _resultsStore.GetAll();

            await Send.OkAsync(response, ct);
        }
    }
}

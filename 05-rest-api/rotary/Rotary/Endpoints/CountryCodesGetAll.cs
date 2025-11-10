using FastEndpoints;
using RotaryLib;

namespace Rotary.Endpoints
{
    public class CountryCodesGetAll(ResultsStore resultsStore)
        : EndpointWithoutRequest<IEnumerable<string>>
    {
        private readonly ResultsStore _resultsStore = resultsStore;

        public override void Configure()
        {
            Get("country-codes");
            AllowAnonymous();
            Description(b => b.Produces<IEnumerable<string>>(200));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _resultsStore.GetCountryCodes();

            await Send.OkAsync(response, ct);
        }
    }
}

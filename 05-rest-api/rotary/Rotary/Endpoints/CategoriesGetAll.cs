using FastEndpoints;
using RotaryLib;

namespace Rotary.Endpoints
{
    public class CategoriesGetAll(ResultsStore resultsStore)
        : EndpointWithoutRequest<IEnumerable<int>>
    {
        private readonly ResultsStore _resultsStore = resultsStore;

        public override void Configure()
        {
            Get("categories");
            AllowAnonymous();
            Description(b => b.Produces<IEnumerable<string>>(200));
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _resultsStore.GetCategories();

            await Send.OkAsync(response, ct);
        }
    }
}

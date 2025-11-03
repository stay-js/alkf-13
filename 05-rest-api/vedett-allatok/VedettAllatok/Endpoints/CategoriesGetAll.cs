using FastEndpoints;
using VedettAllatokLib;

namespace VedettAllatok.Endpoints
{
    public class CategoriesGetAll(AnimalStore animalStore)
        : EndpointWithoutRequest<ApiResponse<IEnumerable<string>>>
    {
        private readonly AnimalStore _animalStore = animalStore;

        public override void Configure()
        {
            Get("categories");
            AllowAnonymous();
        }

        public override async Task HandleAsync(CancellationToken ct)
        {
            var response = _animalStore.GetCategories();

            await Send.OkAsync(CreateApiResponse.Create(response), ct);
        }
    }
}

using System.Net.Http.Json;

namespace bjorkvalle.client.Features.Todos
{
    public record GetTodosQuery() : IRequest<List<TodoModel>>;

    public class GetTodosHandler : IRequestHandler<GetTodosQuery, List<TodoModel>>
    {
        private readonly HttpClient _http;

        public GetTodosHandler(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<TodoModel>> Handle(
            GetTodosQuery query,
            CancellationToken cancellationToken
        )
        {
            var data = await _http.GetFromJsonAsync<List<TodoModel>>(
                "data/todos.json",
                options: new JsonSerializerOptions { PropertyNameCaseInsensitive = true },
                cancellationToken: cancellationToken
            );

            return data;
        }
    }
}

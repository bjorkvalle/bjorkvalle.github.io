using System.Net.Http.Json;

namespace bjorkvalle.client.Features.Todos
{
    public record DeleteTodoCommand(int Id) : IRequest<Unit>;

    public class DeleteTodoHandler : IRequestHandler<DeleteTodoCommand, Unit>
    {
        private readonly HttpClient _http;
        private string _url = "";

        public DeleteTodoHandler(HttpClient http)
        {
            _http = http;
        }

        public async Task<Unit> Handle(
            DeleteTodoCommand command,
            CancellationToken cancellationToken
        )
        {
            var id = command.Id;
            var data = await _http.GetFromJsonAsync<List<TodoModel>>(
                "data/todos.json",
                options: new JsonSerializerOptions { PropertyNameCaseInsensitive = true },
                cancellationToken: cancellationToken
            );

            var updated = data.Where(x => x.Id != id).ToList();
            await _http.PostAsJsonAsync(
                "data/todos.json",
                updated,
                cancellationToken: cancellationToken
            );

            return Unit.Value;
        }
    }
}

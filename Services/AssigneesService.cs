using BugTrackerCP.Models;
using System.Net.Http.Json;

namespace BugTrackerCP.Services
{
    public interface IAssigneesService
    {
        Task<IEnumerable<Assignee>> Get();
        Task Create(Assignee assignee);
        Task Delete(Guid id);
    }

    public class AssigneesService : IAssigneesService
    {
        private readonly HttpClient _httpClient;

        public AssigneesService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task Create(Assignee assignee)
        {
            //await _httpClient.PostAsJsonAsync("", assignee);
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            //await _httpClient.DeleteAsync("");
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Assignee>> Get()
        {
            //var result = await _httpClient.GetFromJsonAsync<IEnumerable<Assignee>>("");

            return Task.FromResult(StubAssigneesResult);
        }

        private IEnumerable<Assignee> StubAssigneesResult = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete"), new Assignee("Jane") };
    }
}

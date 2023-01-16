using BugTrackerCP.Models;
using System.Net.Http.Json;

namespace BugTrackerCP.Services
{
    public interface IBugsService
    {
        Task<IEnumerable<Bug>> Get();
        Task Create(Bug bug);
        Task Delete(Guid id);
    }

    public class BugsService : IBugsService
    {
        private readonly HttpClient _httpClient;

        public BugsService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task Create(Bug bug)
        {
            //await _httpClient.PostAsJsonAsync("", bug);
            return Task.CompletedTask;
        }

        public Task Delete(Guid id)
        {
            //await _httpClient.DeleteAsync("");
            return Task.CompletedTask;
        }

        public Task<IEnumerable<Bug>> Get()
        {
            //var result = await _httpClient.GetFromJsonAsync<IEnumerable<Bug>>("");

            return Task.FromResult(StubResults);
        }

        private IEnumerable<Bug> StubResults = new[] {
            new Bug() {
                Name = "Fix issue with something",
                Description = "We need to fix this thing because it is causing things",
                Assignees = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete") }
            },
            new Bug() {
                Name = "2Fix issue with something",
                Description = "We need to fix this thing because it is causing things",
                Assignees = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete") }
            },
            new Bug() {
                Name = "3Fix issue with something",
                Description = "We need to fix this thing because it is causing things",
                Assignees = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete") }
            },
            new Bug() {
                Name = "4Fix issue with something",
                Description = "We need to fix this thing because it is causing things",
                Assignees = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete") }
            },
            new Bug() {
                Name = "5Fix issue with something",
                Description = "We need to fix this thing because it is causing things",
                Assignees = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete") }
            },
            new Bug() {
                Name = "6Fix issue with something",
                Description = "We need to fix this thing because it is causing things",
                Assignees = new[] { new Assignee("Jeff"), new Assignee("John"), new Assignee("Chris"), new Assignee("Pete") }
            }
        };
    }
}
using System.Net.Http.Json;
using MVCCore.Shared.Models;

namespace MVCCore.Api.Services;

public class BulldogService
{
    private readonly HttpClient _http;
    public BulldogService(HttpClient http) => _http = http;

    public Task<List<Bulldog>?> GetAllAsync()
        => _http.GetFromJsonAsync<List<Bulldog>>("api/bulldogs");

    public Task<Bulldog?> GetByIdAsync(int id)
        => _http.GetFromJsonAsync<Bulldog>($"api/bulldogs/{id}");

    public async Task AddAsync(Bulldog newDog)
    {
        var r = await _http.PostAsJsonAsync("api/bulldogs", newDog);
        r.EnsureSuccessStatusCode();
    }

    public Task UpdateAsync(int id, Bulldog dog)
        => _http.PutAsJsonAsync($"api/bulldogs/{id}", dog);

    public Task DeleteAsync(int id)
        => _http.DeleteAsync($"api/bulldogs/{id}");
}

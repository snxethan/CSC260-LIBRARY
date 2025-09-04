using APis.Components.Models;
using System.Net.Http;
using System.Net.Http.Json;

namespace APis.Components.Services
{
    public class PostService
    {
        private readonly HttpClient _http;

        public PostService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Post>> GetPostsAsync()
        {
            var posts = await _http.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");
            return posts ?? new List<Post>();
        }
    }
}
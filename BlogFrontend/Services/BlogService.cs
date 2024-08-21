using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BlogFrontend.Models;

namespace BlogFrontend.Services
{
    public class BlogService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public BlogService(HttpClient httpClient, ILocalStorageService localStorageService)
        {
            _httpClient = httpClient;
            _localStorageService = localStorageService;
        }

        private async Task SetAuthorizationHeader()
        {
            var token = await _localStorageService.GetItemAsync<string>("jwt");

            if (!string.IsNullOrEmpty(token))
            {
                token = token.Trim('"');
                _httpClient.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", token);
            }
        }

        public async Task<List<Blog>> GetBlogsByTopicAsync(int topicId)
        {
            await SetAuthorizationHeader();
            return await _httpClient.GetFromJsonAsync<List<Blog>>($"http://135.236.156.195/api/Blog/GetBlogsByTopic/{topicId}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Blazored.LocalStorage;
using BlogFrontend.Models;

namespace BlogFrontend.Services
{
    public class TopicService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorageService;

        public TopicService(HttpClient httpClient, ILocalStorageService localStorageService)
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

        public async Task<IEnumerable<Topic>> GetTopicsAsync()
        {
            await SetAuthorizationHeader();
            return await _httpClient.GetFromJsonAsync<IEnumerable<Topic>>("http://20.93.118.201/api/Topic/GetAllTopics");
        }

        public async Task<bool> CreatePreferencesAsync(Guid userId, List<int> selectedTopics)
        {
            await SetAuthorizationHeader();
            Console.WriteLine(userId);
            var response = await _httpClient.PostAsJsonAsync($"http://20.93.118.201/api/Topic/AssignTopicsToUser/{userId}", selectedTopics);
            return response.IsSuccessStatusCode;
        }
    }
}

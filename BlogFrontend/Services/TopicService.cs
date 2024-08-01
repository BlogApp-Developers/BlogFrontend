using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlogFrontend.Models;

namespace BlogFrontend.Services;

public class TopicService
    {
        private readonly HttpClient _httpClient;

        public TopicService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IEnumerable<Topic>> GetTopicsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Topic>>("api/topics");
        }

        public async Task<bool> CreatePreferencesAsync(string userId, List<int> selectedTopics)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/topics/CreatePreferences/{userId}", selectedTopics);
            return response.IsSuccessStatusCode;
        }
    }
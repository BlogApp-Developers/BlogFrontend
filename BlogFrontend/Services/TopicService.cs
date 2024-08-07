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
            return await _httpClient.GetFromJsonAsync<IEnumerable<Topic>>("http://localhost:5149/api/Topic/GetAllTopics");
        }

        public async Task<bool> CreatePreferencesAsync(Guid userId, List<int> selectedTopics)
        {
            Console.WriteLine(userId);
            var response = await _httpClient.PostAsJsonAsync($"http://localhost:5149/api/Topic/AssignTopicsToUser/{userId}", selectedTopics);
            return response.IsSuccessStatusCode;
        }
    }
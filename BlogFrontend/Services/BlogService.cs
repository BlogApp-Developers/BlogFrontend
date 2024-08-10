using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlogFrontend.Models;

namespace BlogFrontend.Services;

public class BlogService
{
    private readonly HttpClient _httpClient;

    public BlogService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Blog>> GetBlogsByTopicAsync(int topicId)
    {
        return await _httpClient.GetFromJsonAsync<List<Blog>>($"http://localhost:5149/api/Blog/GetBlogsByTopic/{topicId}");
    }
}
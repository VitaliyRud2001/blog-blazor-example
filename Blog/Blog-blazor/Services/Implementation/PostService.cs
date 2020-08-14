using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Application.Dtos;
using Blog_blazor.Services.Interface;
using System.Text.Json;
using Blog_blazor.Data;
using Infrastructure.Models;

namespace Blog_blazor.Services.Implementation
{
    public class PostService : IPostService
    {
        private readonly HttpClient _httpClient;
        public PostService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<PostGetDto> CreatePostAsync(PostCreateDto post)
        {
            var dict = new Dictionary<string,string>();
            dict.Add("title",post.Title);
            dict.Add("body",post.Body);
            dict.Add("bodyMarkDown",post.BodyMarkDown); 
            dict.Add("userId",post.UserId.ToString());
            var httpResponse = await _httpClient.PostAsync("/api/Post", new FormUrlEncodedContent(dict));
            PostGetDto postCreated = JsonSerializer.Deserialize<PostGetDto>(await httpResponse.Content.ReadAsStringAsync());
            return postCreated;
        }

        public async Task<PostGetDto> GetPostByIdAsync(int id)
        {
            var httpResponse = await _httpClient.GetStringAsync($"/api/Post/{id}");
            var post = JsonSerializer.Deserialize<PostGetDto>(httpResponse);
            return post;
        }

        public async Task<PaginationDto<PostGetDto>> GetPostsAsync(Pagination paging)
        {

            var httpResponse = await _httpClient.GetAsync($"/api/Post?Page={paging.Page}&PageSize={paging.PageSize}&FirstRequest=true");
            var httpContent = await httpResponse.Content.ReadAsStringAsync();
            var posts = JsonSerializer.Deserialize<PaginationDto<PostGetDto>>(httpContent);
            return posts;
        }
    }
}

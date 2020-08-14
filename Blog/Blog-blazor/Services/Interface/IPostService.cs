using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Dtos;
using Blog_blazor.Data;

namespace Blog_blazor.Services.Interface
{
    public interface IPostService
    {
        Task<PaginationDto<PostGetDto>> GetPostsAsync(Pagination paging);
        Task<PostGetDto> GetPostByIdAsync(int id);
        Task<PostGetDto> CreatePostAsync(PostCreateDto post);
    }
}

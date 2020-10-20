using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SkipitChat.Domain;

namespace SkipitChat.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();
        Task<Post> GetPostByIdAsync(Guid postId);
        Task<bool> UpdatePostAsync(Post postToUpdate);
        Task<bool> DeletePostAsync(Guid postId);
        public Task<bool> CreatePostAsync(Post post);
    }
}

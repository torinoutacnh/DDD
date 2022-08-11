using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.PostAggregate
{
    public interface IPostService
    {
        Task<ICollection<Post>> GetPosts(bool includeDeleted = false);
        Task<ICollection<Post>> GetPostsByUser(string user ,CancellationToken token = default);
        Task<ICollection<Post>> GetAllPostsByTags(params string[] tags);
        Task<ICollection<Post>> SearchPost(string search ,CancellationToken token = default);

        Task<string> CreatePost(Post post);

        Task UpdatePost(string title,string content);
        Task Like(string user, string id);
        Task Unlike(string user, string id);
        Task UpdateTags(params string[] tags);

        Task DeletePost(string id, bool isPhysical = false);
    }
}

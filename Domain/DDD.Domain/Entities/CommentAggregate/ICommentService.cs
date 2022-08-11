using DDD.Domain.Entities.PostAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CommentAggregate
{
    public interface ICommentService
    {
        Task<string> CreateComment(Comment comment);

        Task<ICollection<Comment>> GetComments(bool includeDeleted = false);
        Task<ICollection<Post>> GetCommentsByUserAndPost(string user, string post, CancellationToken token = default);
        Task<ICollection<Post>> GetCommentsByUser(string user, CancellationToken token = default);
        Task<ICollection<Post>> GetCommentsByPost(string post, CancellationToken token = default);

        Task UpdateComment(string content, CancellationToken token = default);
        Task Like(string user, string id);
        Task Unlike(string user, string id);
        Task UpdateTags(params string[] tags);

        Task DeleteComment(string id, bool isPhysical = false);
    }
}

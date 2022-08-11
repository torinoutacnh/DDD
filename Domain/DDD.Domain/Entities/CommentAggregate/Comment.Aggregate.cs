using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.CommentAggregate
{
    public partial class Comment
    {
        public Comment(string content, Guid postId, Guid commentId)
        {
            Content = content;
            Tags = new List<string>();
            Like = new List<string>();
            PostId = postId;
            CommentId = commentId;
            Tags = new List<string>();
            Like = new List<string>();
        }

        public void UpdateComment(string content)
        {
            this.Content = String.IsNullOrEmpty(content) ? throw new ArgumentException(content, nameof(content)) : content;
        }

        public void AddLike(string userId)
        {
            this.Like.Add(userId);
        }

        public void Unlike(string userId)
        {
            this.Like.Remove(userId);
        }

        public void UpdateTags(List<string> tags)
        {
            this.Tags = tags ?? throw new ArgumentNullException(nameof(tags));
        }
    }
}

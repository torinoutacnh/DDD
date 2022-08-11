using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.PostAggregate
{
    public partial class Post
    {
        public Post(string title, string content, string userId)
        {
            Title = string.IsNullOrEmpty(title) ? throw new ArgumentException(nameof(title)) : title;
            Content = string.IsNullOrEmpty(content) ? throw new ArgumentException(nameof(content)) : content;
            UserId = string.IsNullOrEmpty(userId) ? throw new ArgumentException(nameof(userId)) : Guid.Parse(userId);
            Groups = new List<string>();
            Tags = new List<string>();
            Like = new List<string>();
        }

        public void UpdatePost(string? title = null, string? content = null)
        {
            if (String.IsNullOrEmpty(title) && String.IsNullOrEmpty(content)) throw new ArgumentException("Invalid input");
            this.Title = String.IsNullOrEmpty(title) ? this.Title : title;
            this.Content = String.IsNullOrEmpty(content) ? this.Content : content;
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

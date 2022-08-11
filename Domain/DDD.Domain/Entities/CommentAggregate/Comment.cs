using DDD.Domain.Base;
using DDD.Domain.Entities.PostAggregate;

namespace DDD.Domain.Entities.CommentAggregate
{
    public partial class Comment : BaseEntity
    {
        public string Content { get; private set; }
        public List<string> Tags { get; private set; }
        public List<string> Like { get; private set; }

        public Guid PostId { get; }
        public virtual Post Post { get; }

        public Guid CommentId { get; }
        public virtual Comment _Comment { get; }
    }
}

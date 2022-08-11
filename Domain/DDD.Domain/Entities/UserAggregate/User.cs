using DDD.Domain.Base;
using DDD.Domain.Entities.CommentAggregate;
using DDD.Domain.Entities.PostAggregate;

namespace DDD.Domain.Entities.UserAggregate
{
    public partial class User:BaseEntity
    {
        public Account Account { get; private set; }
        public UserInfo Info { get; private set; }

        public virtual ICollection<Post> Posts { get; }
        public virtual ICollection<Comment> Comments { get; }
    }
}

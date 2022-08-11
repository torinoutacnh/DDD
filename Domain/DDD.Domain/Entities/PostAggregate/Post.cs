using DDD.Domain.Base;
using DDD.Domain.Entities.CommentAggregate;
using DDD.Domain.Entities.UserAggregate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.PostAggregate
{
    public partial class Post : BaseEntity
    {
        public string Title { get;private set; }
        public string Content { get; private set; }
        public List<string> Groups { get; private set; }
        public List<string> Tags { get; private set; }
        public List<string> Like { get; private set; }

        public Guid UserId { get; }
        public virtual User User { get; }
        public virtual ICollection<Comment> Comments { get; }        
    }
}

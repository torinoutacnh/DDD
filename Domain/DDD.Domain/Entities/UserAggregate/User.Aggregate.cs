using DDD.Domain.Entities.CommentAggregate;
using DDD.Domain.Entities.PostAggregate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.UserAggregate
{
    public partial class User
    {
        public User(Account account, UserInfo info)
        {
            Account = account ?? throw new ArgumentNullException(nameof(account));
            Info = info ?? throw new ArgumentNullException(nameof(info));

            Posts = new HashSet<Post>();
            Comments = new HashSet<Comment>();
        }

    }
}

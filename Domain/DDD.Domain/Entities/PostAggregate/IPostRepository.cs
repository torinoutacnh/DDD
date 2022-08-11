using DDD.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.PostAggregate
{
    public interface IPostRepository:IRepository<Post>
    {
    }
}

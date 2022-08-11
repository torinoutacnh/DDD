using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Base
{
    public class BaseEntity
    {
        public Guid Id { get; }

        public DateTimeOffset DateCreate { get; }
        public DateTimeOffset DateUpdate { get; private set; }
        public Guid? CreateBy { get; private set; }
        public Guid? UpdateBy { get; private set; }

        public bool IsDeleted { get; private set; }

        protected BaseEntity()
        {
            this.Id = Guid.NewGuid();
            this.DateCreate = DateTimeOffset.Now;
            this.DateUpdate = DateTimeOffset.Now;

            this.IsDeleted = false;
        }

        protected void CreateByUser(Guid user)
        {
            this.CreateBy = user;
        }

        protected void UpdateByUser(Guid user)
        {
            this.UpdateBy = user;
            this.DateUpdate = DateTimeOffset.Now;
        }

        protected void Delete()
        {
            this.IsDeleted = true;
        }
    }
}

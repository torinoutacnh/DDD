using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.UserAggregate
{
    public interface IUserService
    {
        Task<string> Register(User user);
        Task<User> Login(Account account);

        Task<ICollection<User>> GetUsers(bool includeDeleted = false);

        Task<bool> ChangePassword(string oldPassword, string newPassword);
        Task<bool> ChangePasswordByEmail(string email, string newPassword);
        Task<bool> ChangePasswordByPhone(string phone, string newPassword);

        Task<bool> UpdateEmail(string oldEmail, string newEmail);
        Task<bool> UpdateInfo(UserInfo info);

        Task<bool> DeleteUser(string id, bool isPhysical = false);
    }
}

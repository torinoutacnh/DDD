using DDD.Domain.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DDD.Domain.Entities.UserAggregate
{
    public class Account : BaseValueObject
    {
        public string Email { get; private set; }
        public string Password { get; private set; }

        public Account(string email, string password)
        {
            if (string.IsNullOrEmpty(email)) throw new ArgumentNullException("email");
            if (Regex.IsMatch(email, BaseRegex.EmaiRegex)) throw new ArgumentException("Invalid email!");
            if (string.IsNullOrEmpty(password)) throw new ArgumentNullException("password");
            if (Regex.IsMatch(password, BaseRegex.PasswordRegex)) throw new ArgumentException("Invalid password!");

            Email = email;
            Password = password;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Email;
            yield return Password;
        }

        public void UpdatePassword(string password)
        {
            this.Password = password;
        }

        public void UpdateEmail(string email)
        {
            this.Email = email;
        }
    }

    public class UserInfo : BaseValueObject
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string? Address { get; private set; }
        public string? Phone { get; private set; }
        public int? Age { get; private set; }
        public DateTime? Birth { get; private set; }
        public List<string> Hobbies { get; private set; }

        public UserInfo(string firstName, string lastName, string? address = null, string? phone = null, DateTime? birth = null, List<string>? hobbies = null)
        {
            FirstName = string.IsNullOrEmpty(firstName) ? throw new ArgumentException(nameof(firstName)) : firstName;
            LastName = string.IsNullOrEmpty(lastName) ? throw new ArgumentException(nameof(lastName)) : lastName;
            Address = string.IsNullOrEmpty(address) ? throw new ArgumentException(nameof(address)) : address;
            Phone = string.IsNullOrEmpty(phone) ? throw new ArgumentException(nameof(phone)) : phone;
            Birth = birth;
            Age = birth == null ? default : DateTime.Now.Year - birth.Value.Year;
            Hobbies = hobbies ?? new List<string>();
        }

        public void UpdateUserInfo(string? firstName = null, string? lastName = null, string? address = null, string? phone = null, DateTime? birth = null, List<string>? hobbies = null)
        {
            this.FirstName = string.IsNullOrEmpty(firstName) ? this.FirstName : firstName;
            this.LastName = string.IsNullOrEmpty(lastName) ? this.LastName : lastName;
            this.Address = string.IsNullOrEmpty(address) ? this.Address : address;
            this.Phone = string.IsNullOrEmpty(phone) ? this.Phone : phone;
            this.Birth = birth ?? this.Birth;
            this.Age = birth == null ? this.Age : DateTime.Now.Year - birth.Value.Year;
            this.Hobbies = hobbies ?? this.Hobbies;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return FirstName;
            yield return LastName;
            yield return Address;
            yield return Phone;
            yield return Birth;
            yield return Age;
            yield return Hobbies;
        }
    }
}

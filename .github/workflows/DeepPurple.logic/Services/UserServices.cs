using DeepPurple.ApplicationLogic.Abstractions;
using DeepPurple.ApplicationLogic.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeepPurple.ApplicationLogic.Services
{
    public class UserServices
    {
        private IUserRepository _userRepository;

        public UserServices (IUserRepository userRepository)
        {
            this._userRepository = userRepository;
        }

        public IEnumerable<Users> GetAll()
        {
            return _userRepository.GetAll();
        }

        public void AddUser(string UserName, string Password, string Email, bool Member)
        {
            _userRepository.Add(new Users
            {
                userID = Guid.NewGuid(),
                Username = UserName,
                Password = Password,
                Email = Email,
                Member = Member
            });
        }
    }
}

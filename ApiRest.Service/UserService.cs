using System;
using System.Threading.Tasks;
using Takever.Domain;
using Takever.DTO;
using Takever.Infra.Data.Interfaces.Repositories;
using Takever.Service.Interfaces;

namespace Takever.Service
{
    public class UserService : IUserService
    {
        readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User> InsertUserAsync(UserDTO userDTO)
        {
            User user = new User();
            user.Name = userDTO.Name;
            user.Email = userDTO.Email;
            user.Password = userDTO.Password;

            await _userRepository.Insert(user);
            return user;
        }
    }
}

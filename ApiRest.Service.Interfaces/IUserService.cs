using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takever.Domain;
using Takever.DTO;

namespace Takever.Service.Interfaces
{
    public interface IUserService
    {
        Task<User> InsertUserAsync(UserDTO userDTO);
    }
}

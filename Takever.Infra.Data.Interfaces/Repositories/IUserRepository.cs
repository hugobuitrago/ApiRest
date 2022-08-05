using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Takever.Domain;

namespace Takever.Infra.Data.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<int> Insert(User user);
    }
}

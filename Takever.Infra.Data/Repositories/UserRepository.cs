using System.Threading.Tasks;
using Takever.Domain;
using Takever.Infra.Data.Context;
using Takever.Infra.Data.Interfaces.Repositories;

namespace Takever.Infra.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        readonly Takever_Context _context;

        public UserRepository(Takever_Context context)
        {
            _context = context;
        }

        public async Task<int> Insert(User user)
        {
            _context.User.Add(user);
            return await _context.SaveChangesAsync();
        }
    }

}

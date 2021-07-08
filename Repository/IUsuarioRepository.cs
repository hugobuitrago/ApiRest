using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Repository
{
    public interface IUsuarioRepository
    {
        Usuario Create(Usuario usuario);
        Usuario Update(Usuario usuario);
        Usuario Acessar(string user, string senha);
        Usuario GetById(long id);
        List<Usuario> GetAll();
        void Delete(long id);
        bool Exists(long id);
    }
}

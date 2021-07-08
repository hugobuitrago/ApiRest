using Perfius.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Business
{
    public interface IUsuarioBusiness
    {
        UsuarioVO Create(UsuarioVO usuario);
        UsuarioVO Update(UsuarioVO usuario);
        UsuarioVO Acessar(string user, string senha);
        UsuarioVO GetById(long id);
        List<UsuarioVO> GetAll();
        void Delete(long id);
    }
}

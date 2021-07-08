using Perfius.Data.Converter.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Data.Converter.Implementations
{
    public class UsuarioConverter : IParser<UsuarioVO, Usuario>, IParser<Usuario, UsuarioVO>
    {
        public Usuario Parse(UsuarioVO origin)
        {
            if(origin == null)
            {
                return null;
            }
            return new Usuario
            {
                Id = origin.Id,
                User = origin.User,
                Senha = origin.Senha
            };
        }

        public List<Usuario> Parse(List<UsuarioVO> origin)
        {
           if(origin == null)
            {
                return null;
            }
            return origin.Select(item => Parse(item)).ToList();
        }

        public UsuarioVO Parse(Usuario origin)
        {
            if (origin == null)
            {
                return null;
            }
            return new UsuarioVO
            {
                Id = origin.Id,
                User = origin.User,
                Senha = origin.Senha
            };
        }

        public List<UsuarioVO> Parse(List<Usuario> origin)
        {
            if (origin == null)
            {
                return null;
            }
            return origin.Select(item => Parse(item)).ToList();
        }
    }
}

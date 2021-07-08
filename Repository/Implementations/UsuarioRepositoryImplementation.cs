using Perfius.Model.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Repository.Implementations
{
    public class UsuarioRepositoryImplementation : IUsuarioRepository
    {
        private MySqlContext _context;
        public UsuarioRepositoryImplementation(MySqlContext context)
        {
            _context = context;
        }
        public Usuario Acessar(string user, string senha)
        {
            throw new NotImplementedException();
        }

        public Usuario Create(Usuario usuario)
        {
            try
            {
                _context.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }

        public void Delete(long id)
        {
            var result = _context.Usuarios.SingleOrDefault(p => p.Id.Equals(id));
            if (result != null)
            {
                try
                {
                    _context.Usuarios.Remove(result);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public List<Usuario> GetAll()
        {
            return _context.Usuarios.ToList();
        }

        public Usuario GetById(long id)
        {
            return _context.Usuarios.SingleOrDefault(p => p.Id.Equals(id));
        }

        public Usuario Update(Usuario usuario)
        {
            if(!Exists(usuario.Id))
            {
                return new Usuario();
            }
            var result = _context.Usuarios.SingleOrDefault(p => p.Id.Equals(usuario.Id));

            if(result != null)
            {
                try
                {
                    _context.Entry(result).CurrentValues.SetValues(usuario);
                    _context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            
            return usuario;
        }

        public bool Exists(long id)
        {
            return _context.Usuarios.Any(p => p.Id.Equals(id));
        }
    }
}

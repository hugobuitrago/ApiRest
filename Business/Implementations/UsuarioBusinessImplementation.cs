using Perfius.Data;
using Perfius.Data.Converter.Implementations;
using Perfius.Repository;
using System;
using System.Collections.Generic;


namespace Perfius.Business.Implementations
{
    public class UsuarioBusinessImplementation : IUsuarioBusiness
    {
        private readonly IRepository<Usuario> _repository;
        private readonly UsuarioConverter _converter;
        public UsuarioBusinessImplementation(IRepository<Usuario> repository)
        {
            _repository = repository;
            _converter = new UsuarioConverter();
        }
        public UsuarioVO Acessar(string user, string senha)
        {
            throw new NotImplementedException();
        }

        public UsuarioVO Create(UsuarioVO usuario)
        {
            var personEntity = _converter.Parse(usuario);
            personEntity = _repository.Create(personEntity);
            return _converter.Parse(personEntity);
        }

        public void Delete(long id)
        {
           _repository.Delete(id);
        }

        public List<UsuarioVO> GetAll()
        {
            return _converter.Parse(_repository.GetAll());
        }

        public UsuarioVO GetById(long id)
        {
            return _converter.Parse(_repository.GetById(id));
        }

        public UsuarioVO Update(UsuarioVO usuario)
        {
            var personEntity = _converter.Parse(usuario);
            personEntity = _repository.Update(personEntity);
            return _converter.Parse(personEntity); ;
        }
    }
}

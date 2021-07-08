using Perfius.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Perfius.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T Create(T item);
        T Update(T item);
        T GetById(long id);
        List<T> GetAll();
        void Delete(long id);
        bool Exists(long id);
    }
}

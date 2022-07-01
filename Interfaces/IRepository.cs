using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto_DIO_Series.Interfaces
{
    public interface IRepository<T>
    {
        List<T> List();
        T ReturnById(int id);
        void Create(T entity);
        void Delete(int id);
        void Update(int id, T entity);
        int NextId();
    }
}
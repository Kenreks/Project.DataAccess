using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.DataAccess
{
    public interface IEntityRepository<T>
    {
        List<T> GetAll();
        int GetById(int id);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

    }
}

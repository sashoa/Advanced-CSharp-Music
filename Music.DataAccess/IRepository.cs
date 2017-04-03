using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.DataAccess
{
    public interface IRepository<T>
    {
        T Save(T entity, int? id);
        T Delete(int id);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}

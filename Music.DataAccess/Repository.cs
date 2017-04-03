using Music.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music.DataAccess
{
    public class Repository<T> : IRepository<T> where T : IEntity
    {
        private int Id;
        private List<T> entities;

        public Repository()
        {
            Id = 1;
            entities = new List<T>();
        }
        public T Save(T entity, int? id)
        {
            if (id == null)
                entity.Id = Id++;
            else
                entity.Id = (int)id;
            entities.Add(entity);
            return entity;
        }
        public T Delete(int id)
        {
            var entity = entities.SingleOrDefault(e => e.Id == id);
            if (entity != null)
                entities.Remove(entity);
            return entity;
        }
        public T Get(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }
        public IEnumerable<T> GetAll()
        {
            return entities;
        }
    }
}

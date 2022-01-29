using System.Collections;
using System.Collections.Generic;

namespace DAL.Repositories
{
    public interface IRepository<T>
    {
        public IEnumerable<T> GetAll();
        public T GetById(int id);
        public void Create(T item);
        public void Update(T item);
        public void Delete(int id);
    }
}
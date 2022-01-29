using System.Collections.Generic;

namespace BLL.Services
{
    public interface IService<T>
    {
        public IEnumerable<T> GetAll();
    }
}
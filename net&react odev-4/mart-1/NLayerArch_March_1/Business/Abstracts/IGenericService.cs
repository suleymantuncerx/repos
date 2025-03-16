using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IGenericService<T> where T : class
    {
        void Add(T entity);
        void Delete(int id);
        void Update(T entity);
        List<T> GetAll();
        T GetById(int id);
    }
}

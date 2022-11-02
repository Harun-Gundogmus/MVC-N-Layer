using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IRepository<T> where T : class, new()
    {
        int Add(T entity);
        int Update(T entity);
        int Delete(T entity);
        List<T> ListAll();

    }
}

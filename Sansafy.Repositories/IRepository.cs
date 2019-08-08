using Sansafy.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sansafy.Repositories
{
    public interface IRepository<T> where T:BaseClass
    {
        List<T> GetAll();
        T GetById(Guid id);
        T Create(T t);
        T Update(T t);
        T Delete(T t);
    }
}

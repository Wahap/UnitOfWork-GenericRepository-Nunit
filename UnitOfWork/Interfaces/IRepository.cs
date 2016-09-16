using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UnitOfWork.Interfaces
{
  public interface IRepository<T> : IDisposable
  {
    T FindById(int id);
    IQueryable<T> GetAll();
    void Delete(T entity);
    void Add(T entity);
    void Update(T entity);
    int Commit();
  }
}
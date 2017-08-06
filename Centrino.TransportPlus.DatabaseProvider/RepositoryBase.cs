using System;
using System.Collections.Generic;
using System.Text;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Centrino.TransportPlus.DatabaseProvider
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class 
    {
        protected DataBaseContext Db = new DataBaseContext();
        public void Add(T t)
        {
            Db.Set<T>().Add(t);
            Db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Db.Set<T>();
        }

        public T GetById(int i)
        {
            return Db.Set<T>().Find(i);
        }

        public void Remove(T t)
        {
            Db.Set<T>().Remove(t);
        }

        public void Update(T t)
        {
            Db.Entry(t).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            Db.SaveChanges();
        }

    }
}

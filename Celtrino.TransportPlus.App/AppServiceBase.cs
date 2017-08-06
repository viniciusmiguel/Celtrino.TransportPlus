using System.Collections.Generic;
using Celtrino.TransportPlus.App.Interfaces;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.App
{
    public class AppServiceBase<T> : IAppServiceBase<T> where T : class
    {
        private readonly IServiceBase<T> _servicebase;

        public AppServiceBase(IServiceBase<T> servicebase)
        {
            _servicebase = servicebase;
        }
        public void Add(T t)
        {
            _servicebase.Add(t);
        }

        public IEnumerable<T> GetAll()
        {
            return _servicebase.GetAll();
        }

        public T GetById(int i)
        {
            return _servicebase.GetById(i);
        }

        public void Remove(T t)
        {
            _servicebase.Remove(t);
        }

        public void Update(T t)
        {
            _servicebase.Update(t);
        }

    }
}

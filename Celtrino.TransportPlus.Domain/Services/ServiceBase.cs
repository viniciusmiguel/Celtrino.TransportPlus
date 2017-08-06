using System.Collections.Generic;
using Celtrino.TransportPlus.Domain.Interfaces;

namespace Celtrino.TransportPlus.Domain.Services
{
    public class ServiceBase<T> : IServiceBase<T> where T : class
    {
        private readonly IRepositoryBase<T> _repository;

        public ServiceBase(IRepositoryBase<T> repository)
        {
            _repository = repository;
        }
        public void Add(T t)
        {
            _repository.Add(t);
        }

        public IEnumerable<T> GetAll()
        {
            return _repository.GetAll();
        }

        public T GetById(int i)
        {
            return _repository.GetById(i);
        }

        public void Remove(T t)
        {
            _repository.Remove(t);
        }

        public void Update(T t)
        {
            _repository.Update(t);
        }

    }
}

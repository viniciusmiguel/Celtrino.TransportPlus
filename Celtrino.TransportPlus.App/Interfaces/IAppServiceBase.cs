
using System.Collections.Generic;

namespace Celtrino.TransportPlus.App.Interfaces
{
    public interface IAppServiceBase<T> where T : class
    {
        /// <summary>
        /// Add a T Object
        /// </summary>
        /// <param name="t">The object that will be added</param>
        void Add(T t);
        /// <summary>
        /// Get the T object by index
        /// </summary>
        /// <param name="i">The number of the index</param>
        /// <returns>The object requested</returns>
        T GetById(int i);
        /// <summary>
        /// Return an Enumerable with all Objects
        /// </summary>
        /// <returns>Objects of the list</returns>
        IEnumerable<T> GetAll();
        /// <summary>
        /// Update the object provided
        /// </summary>
        /// <param name="t">The object that needs to be updated</param>
        void Update(T t);
        /// <summary>
        /// Remove the object
        /// </summary>
        /// <param name="t">The Object to be removed</param>
        void Remove(T t);

    }
}

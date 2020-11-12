using Newtonsoft.Json.Bson;
using System.Collections.Generic;

namespace WebServerAppFinalProject.Models
{
    interface IRepository<T> where T : class
    {
        IEnumerable<T> List(QueryOptions<T> options);

        T Get(int id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Save(); 
    }
}

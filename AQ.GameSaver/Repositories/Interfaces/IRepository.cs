using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AQ.GameSaver.Repository.Interfaces
{
    public interface IRepository<T>
    {
        void Add(T type);
        void Delete(Guid id);
        IEnumerable<T> GetAll();
        void Save();
    }
}

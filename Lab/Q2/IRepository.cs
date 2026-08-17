using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q2
{
    public interface IRepository<T>
    {
        void Add(T item);
        bool Remove(T item);
        T? Find(T item);
        T? Find(Predicate<T> match);
        List<T> GetAll();
        void Clear();
        void PrintData(T value);
    }
}

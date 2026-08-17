using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q2
{
    class Repository<T> : IRepository<T>
    {
        List<T> data;
        public Repository()
        {
            data = new List<T>();
        }

        public void Add(T item)
        {
            data.Add(item);
        }

        public void Clear()
        {
            data.Clear();
        }

        public T? Find(T item)
        {
            return data.Contains(item)? item : default(T);

            //foreach (T element in data)
            //{
            //    if (element!.Equals(item))
            //    {
            //        return element;
            //    }
            //}
            //return default(T);
        }

        public T? Find(Predicate<T> match)
        {
            return data.Find(match);
        }

        public List<T> GetAll()
        {
            return data;
        }

        public bool Remove(T item)
        {
            return data.Remove(item);
        }

        public void PrintData(T value)
        {
            Console.WriteLine(value);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.Q2
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }

        public Book() { }
        public Book(int Id, string Title, string Author, double Price)
        {
            this.Id = Id;
            this.Title = Title;
            this.Author = Author;
            this.Price = Price;
        }

        public override string ToString()
        {
            return $"Id = {Id}, Author = {Author}, Title = {Title}, Price = {Price}";
        }
    }
}

using Lab.Q1;
using Lab.Q2;

namespace Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1. Interfaces
            List<IShape> shapes = new List<IShape>()
            {
                new Circle(10.0),
                new Rectangle(10.0, 7.0),
                new Triangle(8.0, 12.0),
                new Circle(5),
                new Rectangle(6.0, 7.0),
                new Triangle(5.0, 8.0),
            };

            foreach(IShape shape in shapes)
            {
                Console.WriteLine(shape);
            }
            #endregion

            #region Q2. Generics
            //IRepository<Student> StudentsRepo = new Repository<Student>();
            //StudentsRepo.Add(new Student
            //{
            //    Id = 1,
            //    Name = "Men3m",
            //    Email = "men3m@gmail.com",
            //    Age = 25,
            //    Grade = 99.99
            //});

            //StudentsRepo.Add(new Student
            //{
            //    Id = 2,
            //    Name = "Mona",
            //    Email = "mona@gmail.com",
            //    Age = 23,
            //    Grade = 90.90
            //});

            //StudentsRepo.Add(new Student
            //{
            //    Id = 3,
            //    Name = "Ahmed",
            //    Email = "ahmed@outlook.com",
            //    Age = 24,
            //    Grade = 95.95
            //});

            //Console.WriteLine("Enter Student Name to find and delete");
            //string studentName = Console.ReadLine() ?? string.Empty;

            //Student? student = StudentsRepo.Find(st => st.Name == studentName);
            //if (student is null)
            //{
            //    Console.WriteLine("student wasn't found :(");
            //}
            //else
            //{
            //    Console.WriteLine(student);
            //    StudentsRepo.Remove(student); // delete it
            //}

            //List<Student> myStudents = StudentsRepo.GetAll();
            //foreach(Student st in myStudents)
            //{
            //    Console.WriteLine(st);
            //}

            //StudentsRepo.PrintData(StudentsRepo.GetAll());

            //StudentsRepo.Clear(); // clear all students

            //IRepository<Book> BooksRepo = new Repository<Book>();
            //BooksRepo.Add(new Book
            //{
            //    Id = 1,
            //    Title = "C# Basics",
            //    Author = "Ahmed",
            //    Price = 99.99
            //});

            //BooksRepo.Add(new Book
            //{
            //    Id = 2,
            //    Title = "Advanced C#",
            //    Author = "Mona",
            //    Price = 90.90
            //});

            //Console.WriteLine("Enter Book Title to find and delete");
            //string bookTitle = Console.ReadLine() ?? string.Empty;

            //Book? book = BooksRepo.Find(bk => bk.Title == bookTitle);
            //if (book is null)
            //{
            //    Console.WriteLine("Book wasn't found :("); 
            //}
            //else
            //{
            //    Console.WriteLine(book);
            //    BooksRepo.Remove(book);
            //}

            //List<Book> myBooks = BooksRepo.GetAll();
            //foreach (Book bk in myBooks)
            //{
            //    Console.WriteLine(bk);
            //}

            //BooksRepo.PrintData(BooksRepo.GetAll());

            //BooksRepo.Clear();
            #endregion
        }
    }
}

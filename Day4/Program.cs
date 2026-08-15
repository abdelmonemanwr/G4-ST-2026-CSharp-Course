using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace Day4
{
    #region Struct
    struct Point 
    {
        public int X { get; set; }
        public int y { get; set; }

        public override bool Equals([NotNullWhen(true)] object? obj)
        {
            return obj is Point pp && pp.X == X;
        }

        public override int GetHashCode()
        {
            return X.GetHashCode();
        }
    }

    struct Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public Complex(int Real, int Imag)
        {
            this.Real = Real;
            this.Imag = Imag;
        }

        public Complex(int Real): this(Real, 1)
        {
            Imag = 1;
            this.Real = Real;
        }

        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Sum(int value1, int value2, int value3)
        {
            //return value1 + value2 + value3;
            return Sum(value1, value2) + value3;
        }

        public double Sum(double value1, int value2, int value3)
        {
            //return value1 + value2 + value3;
            return Sum(value3, value2) + value1;
        }

        public double Sum(int value1, double value2, int value3)
        {
            //return value1 + value2 + value3;
            return Sum(value3, value1) + value2;
        }

        public int Sum(int value1, int value2, int value3, int value4)
        {
            return value1 + value2 + value3 + value4;
        }


        public string GetString()
        {
            return $"{Real}+{Imag}i";
        }
    }
    #endregion

    #region Class
    class ComplexNumber
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public ComplexNumber()
        {
            Real = 1; 
            Imag = 1;
        }

        public ComplexNumber(int Real, int Imag)
        {
            this.Real = Real;
            this.Imag = Imag;
        }

        public ComplexNumber(int Real) : this(Real, 1)
        {
            Imag = 1;
            this.Real = Real;
        }

        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }

        public int Sum(int value1, int value2, int value3)
        {
            //return value1 + value2 + value3;
            return Sum(value1, value2) + value3;
        }

        public double Sum(double value1, int value2, int value3)
        {
            //return value1 + value2 + value3;
            return Sum(value3, value2) + value1;
        }

        public double Sum(int value1, double value2, int value3)
        {
            //return value1 + value2 + value3;
            return Sum(value3, value1) + value2;
        }

        public int Sum(int value1, int value2, int value3, int value4)
        {
            return value1 + value2 + value3 + value4;
        }


        public string GetString()
        {
            return $"{Real}+{Imag}i";
        }
    }

    // System.Object


    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public Gender Gender { get; set; }
        public Priviledges Priviledges { get; set; }

        public Employee()
        {
            
        }

        public Employee(int Id, string Name, string Email, decimal Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Salary = Salary;
        }

        public Employee(int Id, string Name, string Email, decimal Salary, Gender Gender, Priviledges Priviledges)
        {
            this.Id = Id;
            this.Name = Name;
            this.Email = Email;
            this.Salary = Salary;
            this.Gender = Gender;
            this.Priviledges = Priviledges;
        }

        public override string ToString()
        {
            return $"{Id}-{Name}-{Gender}-{Email}-{Priviledges}";
        }


        // Type_Of , IS_A, Inheritance
        // student s2 = new student();
        // s1.Equals(s2);
        public override bool Equals(object? obj)
        {
            return obj is Employee emp && Id == emp.Id && Name == emp.Name && Email == emp.Email;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Email);
        }

        ~Employee()
        {

        }
    }
    #endregion

    #region Enums

    enum Gender
    {
        Male,
        Female
    }

    enum Priviledges : byte
    {
        Read = 0,
        Write = 1,
        Execute = 2,
        Delete = 3
    }

    #endregion

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Struct
            //Complex c = new Complex();
            //Console.WriteLine($"sum = {c.Sum(5, 7)}");

            //Complex c = new Complex(7);
            //Console.WriteLine(c.GetString());

            Point p1 = new Point();
            p1.X = 5;
            p1.y = -2;

            Point p2 = new Point();
            p2.X = 5;
            p2.y = 2;

            if (p1.Equals(p2))
            {
                Console.WriteLine("matched");
            }
            else
            {
                Console.WriteLine("Not matched");
            }



            #endregion

            #region class
            //ComplexNumber c = new ComplexNumber();
            //c.Real = 5;
            //Console.WriteLine(c.GetString());

            //int x;
            //int y = x;

            //int x = 5;
            //x.ToString();
            //emp.ToString();


            //Employee emp1 = new Employee(1,"Men3m", "men3m.anwar@iti.gov.eg", 1_000_000);
            //Console.WriteLine(emp1.ToString());

            //Employee emp2 = new Employee(1,"Men3m", "men3m.anwar@iti.gov.eg", 1_000_000);

            ////emp2 = emp1;

            //if (emp1.Equals(emp2))
            //{
            //    Console.WriteLine("Duplicate data occurred");
            //} 
            //else
            //{
            //    Console.WriteLine("No duplicate data occurred");
            //}

            //object o = new object();
            ////o = 1;
            ////o = "ali";
            ////o = new Employee();
            ////o = true;

            //o = 1;
            //int x = (int)o; // unboxing
            //x++;
            //o = x; // boxing
            //Console.WriteLine(o);


            //List<int>  List<string>



            //Employee emp1 = new Employee(1, "Men3m", "men3m.anwar@iti.gov.eg", 1_000_000);
            //int emp1HashedCode = emp1.GetHashCode();
            //Console.WriteLine(emp1HashedCode);


            //Employee emp2 = new Employee(1, "Men3m", "men3m.anwar@iti.gov.eg", 1_000_000);
            //int emp2HashedCode = emp2.GetHashCode();
            //Console.WriteLine(emp2HashedCode);



            Employee emp1 = new Employee(1, "Men3m", "men3m.anwar@iti.gov.eg", 1_000_000);

            //if (emp1.Equals(p1))
            //{

            //}

            Console.WriteLine(emp1.GetType().Name);
            Console.WriteLine(emp1.GetType().FullName);
            Console.WriteLine(emp1.GetType().Namespace);

            #endregion

            Employee e = new Employee(11, "Salah", "salah@gmail.com", 10000, Gender.Male, Priviledges.Read);
            Console.WriteLine(e.ToString());
        }
    }
}

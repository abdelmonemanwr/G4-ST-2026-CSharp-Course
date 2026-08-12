using System;
using System.Xml;

namespace Day3
{
    struct Complex  // 2+3i
    {
        int real;
        //int imag;

        //public void Set_Real(int _real)
        //{
        //    if (_real >= 0)
        //    {
        //        real = _real;
        //    }
        //    else
        //    {
        //        throw new Exception();
        //    }
        //}

        //public int Get_Real()
        //{
        //    if (real >= 0)
        //    {
        //        return real;
        //    }
        //    else
        //    {
        //        throw new Exception();
        //    }
        //}
       
        //public void Set_Imag(int _imag)
        //{
        //    imag = _imag;
        //}

        //public int Get_Imag()
        //{
        //    return imag;
            
        //}


        // c.Real = 5;
        // c.Real++;
        public int Real
        {
            set
            {
                if (value >= 0)
                {
                    real = value;
                }
                else
                {
                    throw new Exception();
                }
            }

            get
            {
                if (real >= 0)
                {
                    return real;
                }
                else
                {
                    throw new Exception();
                }
            }
        }


        public int Imag { get; set; }

        #region Constructors

        // Paramterless constructor
        public Complex() 
        {
            real = 1;
            Imag = 1;
        }

        // Parameterized Constructor
        public Complex(int _real, int _imag)
        {
            real = _real;
            Imag = _imag;
        }
        
        public Complex(int _real)
        {
            real = _real;
            Imag = 1;
        }
        #endregion


        public string Print()
        {
            char op = Imag < 0 ? '-' : '+';
            return $"{real}{op}{Math.Abs(Imag)}i";
        }
    }

    //struct Student
    //{
    //    public uint age;
    //}


    internal class Program
    {
        static void Main(string[] args)
        {
            #region Multi-Dim Array

            // 1D
            //string[] studentNames1 = new string[3];
            //string[] studentNames2 = new string[3] { "men3m", "ahmed", "ola" };
            //string[] studentNames3 = new string[] { "men3m", "ahmed", "ola" };
            //string[] studentNames4 = { "islam", "ahmed", "ola" };

            // 2D
            //string[,] subjects1 = new string[3, 4];

            //string[,] subjects2 = new string[3, 4]
            //{
            //    { "DB", "OOP", "LINQ", "EF" },
            //    { "C#", "OOP", "SOLID", "DP" },
            //    { "ADO.NET", "DB", "MVC", "WebAPIs"}
            //};

            //string[,] subjects3 = new string[,]
            //{
            //    { "DB", "OOP", "LINQ", "EF" },
            //    { "C#", "OOP", "SOLID", "DP" },
            //    { "ADO.NET", "DB", "MVC", "WebAPIs"}
            //};

            //string[,] subjects4 = 
            //{
            //    { "DB", "OOP", "LINQ", "EF" },
            //    { "C#", "OOP", "SOLID", "DP" },
            //    { "ADO.NET", "DB", "MVC", "WebAPIs"}
            //};

            /////////////////////////////////////////////////////////

            // fixed array
            //Console.WriteLine("Enter number of groups");
            //int groupsCount = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter number of students per group");
            //int studentsCount = int.Parse(Console.ReadLine());

            //string[,] names = new string[groupsCount, studentsCount]; // n:m
            //for(int i=0; i<groupsCount; i++)
            //{
            //    Console.WriteLine($"Enter students of track No.{i+1}");
            //    for(int j=0; j<studentsCount; j++)
            //    {
            //        Console.WriteLine($"Enter student No.{j+1}");
            //        names[i, j] = Console.ReadLine();
            //    }
            //}

            //for(int i=0; i<names.GetLength(0); i++)
            //{
            //    Console.WriteLine($"Students of group no.{i+1}");
            //    for(int j=0; j<names.GetLength(1); j++)
            //    {
            //        Console.WriteLine($"student name no.{j+1} is {names[i,j]}");
            //    }
            //}


            /*
                arr.Length => 2D [3,4] = 12
                arr.GetLength(0)=3
                arr.GetLength(1)=4
            */

            // Jagged Array: Array of array
            // [3][]
            // [0][30]
            // [1][25]
            // [2][50]

            //int[][] ages = new int[3][];

            //// g1
            //ages[0] = new int[5];
            //ages[1] = new int[3];
            //ages[2] = new int[4];

            //Console.WriteLine("Enter number of groups");
            //int groupsCount = int.Parse(Console.ReadLine());
            //string[][] names = new string[groupsCount][];

            //for(int i=0; i<names.Length; i++)
            //{
            //    Console.WriteLine($"Enter number of students per group no.{i+1}");
            //    int studentsCount = int.Parse(Console.ReadLine());

            //    names[i] = new string[studentsCount];

            //    //for(int j=0; j < studentsCount; j++){...}
            //    for(int j=0; j < names[i].Length; j++)
            //    {
            //        Console.WriteLine($"Enter Student #{j+1}");
            //        names[i][j] = Console.ReadLine();
            //    }
            //}


            //for(int i=0; i<groupsCount; i++)
            //{
            //    Console.WriteLine($"Students of group no.{i + 1}");
            //    for (int j=0; j < names[i].Length; j++)
            //    {
            //        Console.WriteLine($"student name no.{j + 1} is {names[i][j]}");
            //    }
            //}

            #endregion

            #region Struct

            //Student student;
            //student.age = 1000000;

            //Complex c;
            //c.real = 22;

            //int x = int.Parse(null); // exception
            //c.Set_Real(-1233); // exception


            //int x;
            //Console.WriteLine(x); // error: use of unassigned local variable

            //int x = new int();
            //Console.WriteLine(x);


            //Complex c = new Complex();
            //c.Set_Real(-123); // ex

            //c.Set_Real(5);
            //Console.WriteLine(c.Get_Real());

            //c.Set_Imag(2);
            //Console.WriteLine(c.Get_Imag());


            //Complex c1 = new Complex();
            //Console.WriteLine(c1.Print());

            //Complex c2 = new Complex(5, -7);
            //Console.WriteLine(c2.Print());

            //Complex c3 = new Complex(6);
            //Console.WriteLine(c3.Print());

            //int x = 5;
            //int y = x;


            //int x = 5;
            //x++;
            //Console.WriteLine(x);

            //Complex c4 = new Complex();
            //int r = c4.Get_Real();
            //c4.Set_Real(r + 1);

            //c4.Set_Real(c4.Get_Real() + 1);

            //c4.Real++; // error


            //Complex c5 = new Complex(5,-9);
            //c5.Real++;
            //Console.WriteLine(c5.Print());
            //c5.Real = 14;
            //Console.WriteLine(c5.Print());

            Complex c6 = new Complex(5,-9);
            c6.Imag = 2;
            Console.WriteLine(c6.Print());
            #endregion
        }
    }

}
//using System;
//using Flights;
//using Library;

using System.Text;

namespace DotNet
{
    internal class G4
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, G4 Students :)");


            #region Variables
            /*
                data type
                    byte,    1 byte  [-128:127]       2^8
                    short,   2 byte  [-32,768:32,767]  2^16
                    int,     4 byte  [-2,147,483,648:2,147,483,647] 2^32
                    long,    8 byte  [-9,223,372,036,854,775,808:9,223,372,036,854,775,807]  2^64
                    float,   4 byte     12.12345678  (7)
                    double   8 byte     12.35   (15)
                    decimal, 16 byte                 (28)


            operations

         
             */


            int a = 5;
            int b = 7;
            int c = a + b; // 12  (plus)

            string fname = "men3m";
            string lname = "anwar";
            string fullname = fname + lname; // men3m anwar  (concatination)


            /*
                            1. Value Data Types                   2. Reference Data Types
                                small memory                            large memory
                             int, double, float, char, bool        string, array, class, object
             
             */

            //SByte mySByte = 100;
            //uint myUInt = 100; 
            //ulong myULong = 100;

            int x = 5;

            int y = x;


            //string str = 23;


            //CTS
            //Integer
            //int
            //System.Int32


            Console.WriteLine(int.MaxValue); 
            Console.WriteLine(int.MinValue);
            #endregion

            #region casting

            long id = 100;  // implicit casting


            short age = 28;

            //float pi = 2.14; xxx
            float pi1 = (float)2.14;
            float pi2 = 2.14f;
            float pi3 = 2.14F;

            double pi4 = 2.14;
            double pi5 = 2.14D;
            double pi6 = 2.14d;

            //decimal pi7 = 2.14; xxx
            decimal pi8 = 2.14m;
            decimal pi9 = 2.14M;



            int _myAge;
            int ag_e;


            bool flage = false;
            char ch = 'A';

            decimal salary = 1000.50m;
            //salary = null;

            decimal? sal = null;
            Nullable<decimal> sal2 = null;


            double gpa = 3.7;
            int gpa1 = (int)gpa; // 3



            int m = 23243465;
            char ch1 = (char)m;
            Console.WriteLine(ch1);

            int val = 10;
            //string s = (string)val;
            string s = val.ToString();

            #endregion

            #region Parsing
            string input = Console.ReadLine();

            //int _age = int.Parse(input);
            //Console.WriteLine(_age);

            //bool isValid = int.TryParse(input, out int mySalary);
            int _mySal;
            if( int.TryParse(input, out _mySal))
            {
                Console.WriteLine(_mySal);
            }

            int abbc = Convert.ToInt32(input);
            Console.WriteLine(abbc);
            #endregion

        }



        #region namespaces
        //public class Book
        //{
        //    public string Author { get; set; }
        //    public string Title { get; set; }
        //}

        //public class Book
        //{
        //    public string BookNumber { get; set; }
        //    public string Destination { get; set; }
        //}

        //Flights.Book book = new Flights.Book();
        //Library.Book book1 = new Library.Book();
        #endregion





    }
}

/**/

/*

// Book book tickets
// Book books

namespace Flights
{
    public class Book
    {
        public string BookNumber { get; set; }
        public string Destination { get; set; }
    }
}


namespace Library
{
    public class Book
    {
        public string Author { get; set; }
        public string Title { get; set; }
    }
}

*/
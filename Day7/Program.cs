namespace Day7
{
    // public int sum(int a, int b);

    // public delegate int delName(int a, int b);

    public delegate int MyDelegate(int a, int b);
    public delegate void MyDelegate1(int a, string b);
    public delegate string MyDelegate2(string a, string b);

    public delegate T MyGenericDelegate<T>(T a, T b);
    public delegate void MyGenericDelegate1<T1, T2>(T1 a, T2 b);

    class Calculations
    {
        public static void DoSomething(int x, string y)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
        }
        
        public static void Abc(int x, string y)
        {
            //y = x.ToString();
            Console.WriteLine(x);
            Console.WriteLine(y);
        }


        public static int Sum(int x, int y)
        {
            Console.WriteLine($"sum={x + y}");
            return x + y;
        }
        public static string Sum(string x, string y)
        {
            return $"{x} {y}";
        }
        public static int Sub(int x, int y)
        {
            Console.WriteLine($"sub={x-y}");
            return x - y;
        }
        public long Mul(int x, long y, int z)
        {
            return x * y * z;
        }

        public int Mul(int x, int y)
        {
            Console.WriteLine($"mul={x*y}");
            return x * y;
        }

        // 2,3,d
        public void Operation(int n1, int n2, MyDelegate d)
        {
            //char op = '+';
            //switch (op)
            //{
            //    case '+':
            //        Sum(n1, n2);
            //        break;
            //}

            Console.WriteLine(d.Invoke(n1, n2));
        }

        // 2,3,d
        public void Operation(int n1, int n2, Func<int, int, int> d)
        {
            //char op = '+';
            //switch (op)
            //{
            //    case '+':
            //        Sum(n1, n2);
            //        break;
            //}

            Console.WriteLine(d.Invoke(n1, n2));
        }

        public static bool IsGreaterThan20(int number)
        {
            return number > 20;
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic Delegate
            //Console.WriteLine(Calculations.Sum(2, 3));
            // Student s = new Student();
            // Student s =  new();
            // int[] arr = {1,2,3,4};
            // int[] arr = new int[4] {1,2,3,4};
            //MyDelegate d = new MyDelegate(Calculations.Sum);
            //MyDelegate d1 = new MyDelegate(Calculations.Sub);

            //Calculations c = new Calculations();
            //MyDelegate d2 = new MyDelegate(c.Mul);

            //MyDelegate d = Calculations.Sum;



            //MyDelegate d = new MyDelegate(Calculations.Sum);
            //int result = d.Invoke(2, 3);
            //Console.WriteLine(result);

            //d = Calculations.Sub;
            //Console.WriteLine(d.Invoke(2, 3));

            //Calculations c = new ();
            ////MyDelegate d1 = c.Mul;
            ////c.Operation(5, 7, d1);

            //c.Operation(3, 10, Calculations.Sum);


            //Calculations c = new();
            //MyDelegate d2 = c.Mul;
            //d2 += Calculations.Sub;
            //d2 += Calculations.Sum;
            //c.Operation(3, 10, d2);


            //Calculations c = new ();
            //MyDelegate d3 = c.Mul;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sum;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //d3 += Calculations.Sub;
            //c.Operation(3, 10, d3);


            //Calculations c = new ();
            //MyDelegate d4 = c.Mul;
            //d4 += Calculations.Sub;
            //d4 = Calculations.Sum;
            //c.Operation(3, 10, d4);

            //Calculations c = new();
            //MyDelegate d5 = c.Mul;
            //d5 += Calculations.Sub;
            //d5 += Calculations.Sum;
            //d5 -= Calculations.Sub;
            //c.Operation(3, 10, d5!);

            //d5 +  sum, sub, mul
            //d5 -  sum, sub, mul 


            //Calculations c = new();
            //MyDelegate d1 = Calculations.Sum;
            //d1 += c.Mul;

            //MyDelegate d2 = Calculations.Sub;
            //d2 += c.Mul;

            //MyDelegate d3 = d2 + d1;  //  sub, mul, sum, mul
            //c.Operation(3, 10, d3);


            //Calculations c1 = new();
            //MyDelegate d1 = c1.Mul;
            //d1 += Calculations.Sum;

            //MyDelegate d2 = Calculations.Sub;
            //d2 += Calculations.Sum;
            //d2 += c1.Mul;

            //MyDelegate d3 = d2 - d1;
            //c1.Operation(3, 10, d3);              // sub -7

            //Console.WriteLine("---------------------");

            //Calculations c2 = new();
            //MyDelegate d4 = c2.Mul;
            //d4 += Calculations.Sum;

            //MyDelegate d5 = Calculations.Sub;
            //d5 += c2.Mul;                         // sub mul d5

            //MyDelegate d6 = d5 - d4;    
            //c2.Operation(3, 10, d6);     


            //Calculations c1 = new();
            //MyDelegate d1 = c1.Mul;
            //d1 += Calculations.Sum;

            //MyDelegate d2 = Calculations.Sum;
            //d2 += c1.Mul;

            //MyDelegate d3 = d1 - d2;
            //c1.Operation(3, 10, d3);
            #endregion

            #region Generic Delegate
            //MyDelegate d1 = Calculations.Sum;
            //MyGenericDelegate d2 = new MyGenericDelegate(Calculations.Sum);  // error
            //List values : error => List<int> values  : ok


            //MyGenericDelegate<int> d2 = new MyGenericDelegate<int>(Calculations.Sum);
            //d2.Invoke(23, 2);

            // sugar syntax
            //MyGenericDelegate<int> d2 = Calculations.Sum; 
            //d2(23, 12);

            //MyGenericDelegate<string> d3 = Calculations.Sum; 
            //d3("mohamed", "ibrahim");

            //MyGenericDelegate1<int, string> d4 = Calculations.DoSomething;
            //d4(25, "iti");

            //MyDelegate1 d5 = Calculations.DoSomething;
            //d5(125, "MNF");
            #endregion

            #region Builtin Delegate
            // Func, Action, Predicate

            // int
            // Func<out>: Func<int> : returns: int value , accepts: 0 parameters
            // Func<in, out>: Func<int, int> : returns: int value , accepts: 1 parameters
            // Func<in, in, in, out>: Func<int, int, int, int> : returns: int value , accepts: 3 parameters


            //Func<int, int, float> d = Calculations.Sum;  // xxxx
            //Func<int, int, int> d = Calculations.Sum;  
            //Console.WriteLine(d(12, 34));

            //Func<string, string, string> d1 = Calculations.Sum;
            //Console.WriteLine(d1("salah", "mahmoud"));

            //Calculations c = new Calculations();
            //Func<int, long, int, long> d2 = c.Mul;
            //Console.WriteLine(d2.Invoke(10, 100, 10));

            //Action<int, string> d3 = Calculations.DoSomething;
            //d3.Invoke(34, "men3m");

            //Calculations c = new Calculations();

            //Action<int, int, Func<int, int, int>> lena = new Action<int, int, Func<int, int, int>>(c.Operation);
            //lena.Invoke(2, 8, c.Mul);

            // equivilant

            //Action<int, int, Func<int, int, int>> lena = c.Operation;
            //lena(2, 8, c.Mul);


            // Predicate

            //List<int> numbers = [ 10, 28, 15, 20, 25 , 30];
            //int result = numbers.Find(Calculations.IsGreaterThan20);
            //Console.WriteLine(result);


            //Predicate<int> predicate = Calculations.IsGreaterThan20;
            //int output = numbers.Find(predicate);
            //Console.WriteLine(output);
            #endregion

            #region Anonymous Function

            // first option: using keyword delegate
            //Func<int, int, int> d1 = Calculations.Sum;
            //Func<int, int, int> d1 = delegate (int n1, int n2) 
            //{ 
            //    return n1 + n2;
            //};

            //Func<int, int, string> d2 = delegate (int n1, int n2) 
            //{ 
            //    int sum = n1 + n2; 
            //    return sum.ToString(); 
            //};

            // second option: Lamda Expression
            //Func<int, int, int> d3 = (n1, n2) => n1 + n2;

            //Func<int, int, string> d4 = (n1, n2) =>
            //{
            //    int sum = n1 + n2;
            //    return sum.ToString();
            //};


            //MyDelegate d = delegate (int a, int b)
            //{
            //    return a + b;
            //};


            //MyDelegate d = (a, b) => a + b;
            //MyDelegate2 d2 = (x, y) => x + ' ' + y;


            //List<int> numbers = [ 10, 28, 15, 20, 25, 30];

            //Predicate<int> predicate = Calculations.IsGreaterThan20;
            //int output = numbers.Find(predicate);
            //Console.WriteLine(output);


            // (p1, p2) => p1+p2
            // (p1) => p1>20;
            // p1 => p1>20

            //int result = numbers.Find(a => a > 20);
            //Console.WriteLine(result);

            #endregion

            #region Implicit Type Local Variable


            //int x = 5;
            //??? y = expression;
            //??? z = query;

            //var x = 5*1.2;
            //x = "ali"; // xxxx

            //var mohamed_ibraheem;

            Dictionary<int, Func<int, int, int>> dic = new();
            //foreach(KeyValuePair<int, Func<int, int, int>> kvp in dic)
            //{
            //    Console.WriteLine( kvp.Key);
            //    Console.WriteLine( kvp.Value);
            //}

            //foreach(var kvp in dic)
            //{
            //    Console.WriteLine(kvp.Key);
            //    Console.WriteLine(kvp.Value);
            //}

            //var ac = null; xxxxx
            //var abc = (int?)null;
            //int? ab = null;


            #endregion

        }
    }
}
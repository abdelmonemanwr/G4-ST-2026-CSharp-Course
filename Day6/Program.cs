using System.Data.Common;
using System.Threading.Channels;

namespace Day6
{
    record Users(int Id, string Name, int Age);


    #region interface
    //interface ITypeA
    //{
    //    public void show();
    //    public void Login(string username, string password);
    //}

    //class test : ITypeA
    //{
    //    public void Login(string username, string password)
    //    {
    //        if(username == "men3m" && password == "123")
    //        {
    //            Console.WriteLine($"welcome back, {username}");
    //        }
    //    }

    //    public void show()
    //    {
    //        Console.WriteLine("hello users");
    //    }
    //}

    //abstract class _Players
    //{
    //    public abstract void PPlay();
    //}

    //abstract class _Singers
    //{
    //    public abstract void SSing();
    //}

    //class Player : _Players, IPlayer, ISinger // multiple inheritance disallowed.
    //{
    //    int scored_goals;
    //    public Player()
    //    {
    //        scored_goals = 0;
    //    }
    //    public void Play()
    //    {

    //    }

    //    public override void PPlay()
    //    {
    //    }

    //    public int Score()
    //    {
    //        return ++scored_goals;
    //    }

    //    public void Sing()
    //    {
    //        Console.WriteLine("sdsdsd");
    //    }

    //    public void Win()
    //    {
    //        Console.WriteLine();
    //    }
    //}
    #endregion

    #region Generic & Non Generic Methods
    class Operations
    {

        public void Show<dt1, dt2>(ref dt1 a, ref dt2 b)
        {
            dt1 x = a;
            dt2 y = b;
            Console.WriteLine($"{a}={x}, {b}={y}");
        }
        
        public static void Show2<dt1>(ref dt1 a, ref string b)
        {
            Console.WriteLine($"{a}, {b}");
        }

        public static void Swap<dt>(ref dt a, ref dt b)
        {
            dt temp = a;
            a = b;
            b = temp;
        }

        public static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public static void Swap(ref double a, ref double b)
        {
            double temp = a;
            a = b;
            b = temp;
        }
    }
    #endregion

    #region Generic & Non Generic Classes
    //class MyStack
    //{
    //    int[] items;
    //    int top;

    //    public MyStack()
    //    {
    //        items = new int[5];
    //        top = 0;
    //    }

    //    public MyStack(int size)
    //    {
    //        items = new int[size];
    //        top = 0;
    //    }

    //    public void Push(int item)
    //    {
    //        if (top >= items.Length)
    //        {
    //            throw new Exception("no more space to push new items");
    //        }

    //        //items[top] = item;
    //        //top++;

    //        items[top++] = item;
    //    }

    //    public int Pop()
    //    {
    //        if (top <= 0)
    //        {
    //            throw new Exception("no more items to pop");
    //        }
    //        return items[--top];
    //    }
    //}

    //class MyStringStack
    //{
    //    string[] items; // 
    //    int top;

    //    public MyStringStack()
    //    {
    //        items = new string[5];//
    //        top = 0;
    //    }

    //    public MyStringStack(int size)
    //    {
    //        items = new string[size];//
    //        top = 0;
    //    }

    //    public void Push(string item)//
    //    {
    //        if (top >= items.Length)
    //        {
    //            throw new Exception("no more space to push new items");
    //        }

    //        //items[top] = item;
    //        //top++;

    //        items[top++] = item;
    //    }

    //    public string Pop()//
    //    {
    //        if (top <= 0)
    //        {
    //            throw new Exception("no more items to pop");
    //        }
    //        return items[--top];
    //    }
    //}

    class MyGenericStack<T>
    {
        T[] items;
        int top;

        public MyGenericStack()
        {
            items = new T[5];
            top = 0;
        }

        public MyGenericStack(int size)
        {
            items = new T[size];
            top = 0;
        }

        public void Push(T item)
        {
            if (top >= items.Length)
            {
                throw new Exception("no more space to push new items");
            }

            //items[top] = item;
            //top++;

            items[top++] = item;
        }

        public T Pop()
        {
            if (top <= 0)
            {
                throw new Exception("no more items to pop");
            }
            return items[--top];
        }
    }
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            //Users user1 = new Users(Id: 1, Age: 22, Name: "men3m");
            ////Users user2 = new Users(1, 22, "men3m"); xxx
            //Users user2 = new Users(10, "men3M", 55);

            //Console.WriteLine((user1 == user2) ? "equal" : "not equal");

            //Users user3 = user2 with { Name = "hossien" };
            //Console.WriteLine(user3);
            #endregion

            #region interfaces 
            // multiple inheritance vs multilevel inheritance


            //int[] arr = { 1, 24, 13, 42, 53, 34, 19, 7, 68 };
            //Array.Sort(arr);
            //for(int i=0; i<arr.Length; i++)
            //{
            //    Console.Write($"{arr[i]} ");
            //}

            //Student[] students =
            //{
            //    new Student(2, "men3m", 30),
            //    new Student(1, "Akram", 22),
            //    new Student(3, "Ola", 20)
            //};

            //Array.Sort(students);
            //foreach(Student s in students)
            //{
            //    Console.WriteLine(s);
            //}


            //using (Student s = new Student(11,"Hossin", 21))
            //{
            //    Console.WriteLine(s);
            //}



            //Console.WriteLine("last operation");
            #endregion

            #region generic methods
            //int x = 2;
            //int y = 3;
            //Operations.Swap(ref x, ref y);
            //Console.WriteLine($"x={x}, y={y}");

            //string s = "men3m";
            //string t = "ali";
            //Operations.Swap(ref s, ref t);
            //Console.WriteLine($"s={s}, t={t}");


            //int x = 2;
            //int y = 3;
            //Operations.Swap<int>(ref x, ref y);
            //Console.WriteLine($"x={x}, y={y}");

            //string m = "mido";
            //string n = "aref";
            //Operations.Swap<string>(ref m, ref n);
            //Console.WriteLine($"m={m}, n={n}");

            //int a = 6;
            //char b = 'B';
            //Operations op = new Operations();
            //op.Show<int, char>(ref a, ref b);


            //Operations.Show2<int>(ref a, ref m);

            #endregion

            #region non-generic class

            //MyStack st = new MyStack(3);
            //st.Push(12);
            //st.Push(14);
            //st.Push(13);

            //Console.WriteLine(st.Pop());

            //st.Push(15);
            //Console.WriteLine(st.Pop());
            //Console.WriteLine(st.Pop());





            #endregion

            #region generic class

            //MyGenericStack<string> mgs = new MyGenericStack<string>();
            //mgs.Push("Men3m");
            //mgs.Push("ITI");
            //mgs.Push("Ola");
            //Console.WriteLine(mgs.Pop());

            #endregion

            #region collections

            #region List <T>
            //List<string> courses = new List<string>();
            //List<int> grades = new List<int>();
            //grades.Add(90); // 0
            //                // 1
            //grades.Add(87); // 2


            //grades.Insert(1, 99); // 1
            //grades.Add(99);  // 3

            //// 90 99 87 99

            ////grades.Remove(99);

            //grades.RemoveAt(2);


            ////if (grades.Contains(100))
            ////{
            ////    Console.WriteLine("Perfect");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("not perfect");
            ////}

            //if (grades.Contains(90))
            //{
            //    Console.WriteLine("Perfect");
            //}
            //else
            //{
            //    Console.WriteLine("not perfect");
            //}


            //    //for(int i=0; i<grades.Count; i++)
            //    //{
            //    //    Console.Write($"{grades[i]} ");
            //    //}
            //    //Console.WriteLine();
            //    // foreach(dt x in collection)
            //    foreach (int grade in grades)
            //    {
            //        Console.Write($"{grade} ");
            //    }

            #endregion

            #region Dictionary  Key, Value

            //Dictionary<int, string> students = new Dictionary<int, string>();
            //students.Add(10, "ITI");
            //students.Add(5, "Route");

            // name, mobile username

            //Dictionary<string, string> mobiles = new Dictionary<string, string>(); // k:mobile - v:name

            //Dictionary<string, string> usernames = new Dictionary<string, string>(); // k:username - v:mobile


            //Console.WriteLine("Enter number of users to save");
            //int n = int.Parse(Console.ReadLine()!);

            //for(int i=0; i<n; i++)
            //{

            //    string[] input;
            //    bool isValid = false;

            //    do
            //    {
            //        Console.WriteLine($"Enter name, mobile, username of user number {i+1}");
            //        input = Console.ReadLine()!.Split(' ', options: StringSplitOptions.RemoveEmptyEntries);

            //        if (usernames.ContainsKey(input[2]))
            //        {
            //            Console.WriteLine("username already exists please try again");
            //        }
            //        else if (mobiles.ContainsKey(input[1]))
            //        {
            //            Console.WriteLine("mobile number already exists please try again");
            //        }
            //        else
            //        {
            //            isValid = true;
            //            mobiles.Add(input[1], input[0]);
            //            usernames.Add(input[2], input[1]);
            //        }
            //    }
            //    while (!isValid);
            //}

            //Console.WriteLine("Enter username to delete");
            //string username = Console.ReadLine()!;
            //usernames.Remove(username);
            //Console.WriteLine("username deleted");
            //foreach(KeyValuePair<string, string> pair in usernames)
            //{
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}

            ////Console.WriteLine(usernames[username]); // ex

            //Console.WriteLine("Enter username to find");
            //string username2 = Console.ReadLine()!;

            ////bool isValid = usernames.TryGetValue(username2, out string mobileNumber);

            ////string mobileNumber;
            ////bool isValid = usernames.TryGetValue(username2, out mobileNumber);

            //if(usernames.TryGetValue(username2, out string mobileNumber))
            //{
            //    Console.WriteLine(mobileNumber);
            //} 
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            //foreach (KeyValuePair<string, string> pair in usernames)
            //{
            //    Console.WriteLine($"{pair.Key} - {pair.Value}");
            //}
            #endregion


            #endregion

        }
    }
}

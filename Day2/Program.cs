namespace Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //checked
            //{
            //    int x = int.MaxValue;
            //    x += 10;
            //    Console.WriteLine(x);
            //}

            #region Formatting Output

            //int id = 123;
            //decimal salary = 14999.99M;
            //string fname = "Men3m";
            //string lname = "Anwar";

            // id: 123, Fullname: Men3m Anwar, Salary: 14999.99

            // 1. String Concatenation
            //Console.WriteLine("id = " + id + ", Fullname = " + fname + " " + lname + ", Salary = " + salary);

            // 2. String Holders
            //Console.WriteLine("id = {0}, Fullname = {1}, Salary = {3}", id, fname + ' ' + lname, salary); // okay
            //Console.WriteLine("id = {0}, Fullname = {1}, Salary = {4}", id, fname + ' ' + lname, salary); // excption

            // 3. String Interpolation
            //Console.WriteLine($"id = {id}, Fullname = {fname} {lname}, Salary = {salary}");


            // Escape Sequences
            // \t, \n
            //Console.WriteLine($"id = {id}\t Fullname = {fname} {lname}  \t  Salary = {salary}");
            //Console.WriteLine($" id = {id}\n Fullname = {fname} {lname}\n Salary = {salary}");

            // double backslash
            //Console.WriteLine("C:\\Users\\Men3m");

            // Verbatim String Literal
            //Console.WriteLine(@"C:\Users\Men3m");


            // int? id = null;
            //Nullable<int> id = null;

            #endregion

            #region Reading Input

            // Read, ReadLine, ReadKey
            //int ch = Console.Read();
            //Console.WriteLine(ch);

            //ConsoleKeyInfo key= Console.ReadKey();
            //Console.WriteLine('\n');
            //Console.WriteLine(key.KeyChar);

            //string str = Console.ReadLine();

            //int age = int.Parse(str);
            //Console.WriteLine(age+1);

            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine(age + 1);


            //bool isValid = int.TryParse(Console.ReadLine(), out int id);
            //Console.WriteLine(isValid);
            //Console.WriteLine(id);

            //int myId;
            //if (int.TryParse(Console.ReadLine(), out myId))
            //{
            //    Console.WriteLine(myId);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}


            #endregion

            #region Control Statements

            // 1. Conditional Statements
            // if 
            // if else
            // if else if .... else
            // Switch

            //int num = int.Parse(Console.ReadLine()!);

            //if(num == 100) 
            //    Console.WriteLine("awesome");

            //if (num >= 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else
            //{
            //    Console.WriteLine("Negative");
            //}

            //if (num < 0)
            //{
            //    Console.WriteLine("invalid number");
            //}
            //else if(num % 2 == 0)
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}


            //int month = int.Parse(Console.ReadLine()!);

            //switch (month)
            //{
            //    case 1:
            //    case 13:
            //        Console.WriteLine("January");
            //        break;
            //    case 2:
            //        Console.WriteLine("February");
            //        break;
            //    case 3:
            //        Console.WriteLine("March");
            //        break;
            //    case 4:
            //        Console.WriteLine("April");
            //        break;
            //    case 5:
            //        Console.WriteLine("May");
            //        break;
            //    case 6:
            //        Console.WriteLine("June");
            //        break;
            //    case 7:
            //        Console.WriteLine("July");
            //        break;
            //    case 8:
            //        Console.WriteLine("August");
            //        break;
            //    case 9:
            //        Console.WriteLine("September");
            //        break;
            //    case 10:
            //        Console.WriteLine("October");
            //        break;
            //    case 11:
            //        Console.WriteLine("November");
            //        break;
            //    case 12:
            //        Console.WriteLine("December");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Month");
            //        break;
            //}


            // 2. Looping Statements
            // for
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine(a + b); 

            //int c = int.Parse(Console.ReadLine());
            //int d = int.Parse(Console.ReadLine());
            //Console.WriteLine(c + d); 

            //int e = int.Parse(Console.ReadLine());
            //int f = int.Parse(Console.ReadLine());
            //Console.WriteLine(e + f); 


            //for (int i = 1; i <=3; i++)
            //{
            //    if (i == 2) continue;
            //    Console.WriteLine("Enter first Number");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second Number");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"sum = {a + b}");
            //    Console.WriteLine("-------------------------------");
            //}

            //int i = 1;
            //for (; ; )
            //{
            //    if (i > 3) break;

            //    Console.WriteLine("Enter first Number");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second Number");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"sum = {a + b}");
            //    Console.WriteLine("-------------------------------");


            //    i++;
            //}



            // while
            //int i = 1;
            //while (i<=3)
            //{
            //    Console.WriteLine("Enter first Number");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter second Number");
            //    int b = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"sum = {a + b}");
            //    Console.WriteLine("-------------------------------");
            //    i++;
            //}

            // do..while()
            //int num;
            //do
            //{
            //    Console.WriteLine("Enter number between 1:10");
            //    num = int.Parse(Console.ReadLine());
            //} while (num > 10 || num < 1);

            // foreach
            #endregion


            //string student1 = Console.ReadLine();
            //string student2 = Console.ReadLine();
            //string student3 = Console.ReadLine();
            //string student4 = Console.ReadLine();
            //string student5 = Console.ReadLine();
            //string student6 = Console.ReadLine();
            //string student7 = Console.ReadLine();


            //int[] arr = new int[5]; // int arr[5];
            //Console.WriteLine(arr[0]);
            //Console.WriteLine(arr[2]);
            //Console.WriteLine(arr[4]);

            //int age = new int();
            //Console.WriteLine(age);
            //double salary  = new double();
            //Console.WriteLine(salary);

            //int[] arr = new int[5];
            //for (int idx = 0; idx < arr.Length; idx++)
            //{
            //    Console.WriteLine($"enter value of the {idx+1} number");
            //    arr[idx] = int.Parse(Console.ReadLine());
            //}
            //for (int idx = 0; idx < arr.Length; idx++)
            //{
            //    Console.WriteLine(arr[idx]);
            //}
            //int[] arr2 = new int[5] { 1, 2, 3, 4, 5 };
            //int[] arr3 = new int[5] { 1, 2, 3}; // error
            //int[] arr4 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            //Console.WriteLine(arr4.Length);

            //int[] a = { 10, 20, 30 };
            //Console.WriteLine(a.Length);
            //for (int idx = 0; idx < a.Length; idx++)
            //{
            //    Console.WriteLine(a[idx]);
            //}

            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //for(int i=0;i<size; i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int sum = 0;
            //for(int i=0;i<size; i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine($"sum = {sum}");

            //int size = int.Parse(Console.ReadLine());
            //int[] arr = new int[size];
            //int sum = 0;
            //for(int i=0;i<size; i++)
            //{
            //    //arr[i] = Convert.ToInt32(Console.ReadLine());
            //    //sum += arr[i];
            //}
            //Console.WriteLine($"sum = {sum}");




            Console.WriteLine("enter size of array");
            int size = int.Parse(Console.ReadLine()!);
            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"enter number {i+1}");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int sum = 0;
            foreach (int x in arr)
            {
                Console.WriteLine(x);
                sum += x;
            }

            Console.WriteLine($"sum = {sum}");
        }
    }
}

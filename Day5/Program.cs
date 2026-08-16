namespace Day5
{
    internal class Program
    {
        public static void Display(Parent p)
        {
            p.Show();
        }
        static void Main(string[] args)
        {
            #region Static
            //Student s = new Student(1, "Men3m", 25);
            //Console.WriteLine(Student.Count);
            //Student s2 = new Student(22, "Ali", 22);
            //Console.WriteLine(Student.Count);
            //Student s3 = new Student(13, "Ola", 20);
            //Console.WriteLine(Student.Count);
            //Student s4 = new Student(17, "Omar", 21);
            //Console.WriteLine(Student.Count);
            //Student s5 = new Student();

            //s5.Name = "Mohamed";
            //s5.Age = 21;

            //Console.WriteLine(Student.Count);


            //Student s = new Student("Men3m", 25);
            //Console.WriteLine(s);
            //Student s2 = new Student("Ali", 22);
            //Console.WriteLine(s2);
            //Student s3 = new Student("Ola", 20);
            //Console.WriteLine(s3);
            //Student s4 = new Student("Omar", 21);
            //Console.WriteLine(s4);
            //Student s5 = new Student();
            //Console.WriteLine(s5);


            //Student s;
            //Student st = new Student();

            //Console.WriteLine( Student.Message);

            //Student s = new Student();
            //int sum = s.sum(1, 2);
            //Console.WriteLine(sum);

            //Console.WriteLine(Student.sum(1,24));

            //Student.Count = 100;
            //Console.WriteLine(Student.Count);

            //Math.Abs(-5);
            #endregion

            #region Class Relations

            // 4 relations
            // 1. IS_A = Generalization, Type_Of, Inheritance
            // e.g,   Parent P = new Parent();
            //        Parent P = new Child(); 
            //        Person P = new Student();
            //        Animal a = new Lion();
            //        Vehicle v = new Car();
            //  SOLID: L => LSP = Liskov Substitution Princple
            // A:Super, B:Sub   B take place A without modifiying anything

            // 2. USES_A = Dependency
            // ex: Student Uses a Laptop
            //     Employee uses a printer

            // 3. HAS_A = Association, Aggregation
            // Team has players
            // Room has chairs

            // 4. CONSISTS_OF = Composition
            // House consists of rooms

            #endregion

            #region USES_A
            //Printer p = new Printer();

            //Employee emp = new Employee();
            //emp.PrintWork(p);

            //EmailService emailService = new EmailService();

            //OrderService orderService = new OrderService();
            //orderService.CreateOrder(emailService);
            #endregion

            #region HAS_A
            //Subject[] subjects = new Subject[] 
            //{
            //    new Subject(12453, "C#", 42),
            //    new Subject(14231, "DB", 30),
            //    new Subject(14231, "MVC", 49),
            //};
            //Student s = new Student(1, "Men3m", 25, subjects);

            //Console.WriteLine(s);

            #endregion

            #region Consists_Of

            //Processor processor = new Processor(8, "RTX");
            //Computer computer = new Computer(processor);
            //Computer c2 = new Computer(processor);

            #endregion

            #region IS_A
            //Parent p1 = new Parent();
            //p1.X = 5;

            //Child c = new Child();
            //c.X = 52;
            ////c.X = "men3m";
            //Console.WriteLine(c.X);

            //Child c = new Child(23, 12);
            //Console.WriteLine(c);


            //Parent p = new Parent(10);
            //Parent p2 = new Child(5, 2);

            //p2.Show();
            //Child c = new Child(2, 3);

            //c.Show();

            //SubChild sc = new SubChild(1,2,3);

            //Parent p3 = new SubChild(1, 2, 3);
            //p3.Show();

            //Program.Display(p);
            //Program.Display(p2);
            //Program.Display(p3);

            #endregion

            #region Abstract Class
            //Person p = new Person();  xxx
            //Teacher t = new Teacher();
            //t.Id = 1;
            //t.Name = "Men3m";
            //t.Email = "men3m@iti.gov.eg";

            //Person.Show();
            #endregion

            #region Sealed Class

            //Processors p = new Processors();



            #endregion
        }
    }
}

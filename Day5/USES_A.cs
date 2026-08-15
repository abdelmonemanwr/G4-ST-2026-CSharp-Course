using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    class Printer
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }

    class Employee
    {
        public void PrintWork(Printer printer)
        {
            printer.Print("task");
        }
    }


    //class EmailInfo
    //{
    //    public string Email { get; set; }
    //    public string Subjects { get; set; }
    //    public string Body { get; set; }
    //}

    class EmailService
    {
        public void SendEmail(string Email, string Subject, string Body)
        {
            // send email
        }
    }

    class OrderService
    {
        public void CreateOrder(EmailService emailService)
        {
            // order creation steps
            emailService.SendEmail("men3m@gmail.com", "Order#123", "you purchased order, which contains blblblb");
        }
    }
}

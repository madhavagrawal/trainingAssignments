using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonstructor_Assignment
{
    internal class Ques1
    {
        public string first_name;
        public string last_name;
        public string email;
        public DateTime dob;

        public Ques1(string first_name, string last_name, string email, DateTime dob)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.dob = dob;
        }

        public Ques1(string first_name , string last_name, string email)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
        }

        public Ques1(string first_name, string last_name, DateTime dob)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.dob = dob;
        }

        public void display()
        {
            Console.WriteLine($"First Name : {first_name} \n Second name : {last_name} \n EMail : {email} \n DOB : {dob}");
        }
    }

    class Test
    {
        static void Main()
        {
            Console.WriteLine("Enter First name : ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter Email : ");
            string eMail = Console.ReadLine();
            Console.WriteLine("Enter DOB : ");
            DateTime dob = DateTime.Parse(Console.ReadLine());

            Ques1 Person = new Ques1(firstName, lastName, eMail, dob);
            Person.display();
        }
    }
}

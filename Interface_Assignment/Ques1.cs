using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Assignment
{

    interface iGovtRules
    {
        public double EmployeePF(double basicSalary);
        public string LeaveDetails();

        public double gratuityAmount(float serviceCompleted , double basicSalary);

    }

    class TCS : iGovtRules
    {
        int EmpId;
        string Name;
        string Dept;
        string Desg;
        int BasicSalary;

        public TCS(int empId, string name, string dept, string desg, int basicSalary)
        {
            this.EmpId = empId;
            this.Name = name;
            this.Dept = dept;
            this.Desg = desg;
            this.BasicSalary = basicSalary;
        }

        public int ID
        {
            get
            {
                return EmpId;
            }
        }
        public string getName
        {
            get
            {
                return Name;
            }
        }

        public string Department
        {
            get
            {
                return Dept;
            }
        }

        public string Designation
        {
            get
            {
                return Desg;
            }
        }

        public int Salary
        {
            get
            {
                return BasicSalary;
            }
        }

        public double EmployeePF(double BasicSalary)
        {
            double pf = ((12 * BasicSalary) / 100) + ((8.33 * BasicSalary) / 100) + ((3.67 * BasicSalary) / 100);
            return pf;
        }

        public string LeaveDetails()
        {
            return @"1 day of casual leave per month
12 days of sick leave per year
10 days of Previlage leave per year";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            double gratuity_Amount = 0;
            if (serviceCompleted < 5)
            {
                gratuity_Amount = 0;
            }

            else if (serviceCompleted > 5 && serviceCompleted < 10)
            {
                gratuity_Amount = basicSalary / 12;
            }

            else if (serviceCompleted > 10 && serviceCompleted < 20)
            {
                gratuity_Amount = basicSalary * 2;
            }
            else if (serviceCompleted > 20)
            {
                gratuity_Amount *= 3;
            }
            return gratuity_Amount;
        }
    }

    class Accenture : iGovtRules
    {
        int EmpId;
        string Name;
        string Dept;
        string Desg;
        int BasicSalary;

        public Accenture(int empId, string name, string dept, string desg, int basicSalary)
        {
            EmpId = empId;
            Name = name;
            Dept = dept;
            Desg = desg;
            BasicSalary = basicSalary;
        }

        public int ID
        {
            get
            {
                return EmpId;
            }
        }
        public string getName
        {
            get
            {
                return Name;
            }
        }

        public string Department
        {
            get
            {
                return Dept;
            }
        }

        public string Designation
        {
            get
            {
                return Desg;
            }
        }

        public int Salary
        {
            get
            {
                return BasicSalary;
            }
        }

        public double EmployeePF(double BasicSalary)
        {
            double pf = ((12 * BasicSalary) / 100) + ((12 * BasicSalary) / 100) ;
            return pf;
        }

        public string LeaveDetails()
        {
            return @"2 day of casual leave per month
5 days of sick leave per year
5 days of Previlage leave per year";
        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            return 0;
        }
    }

    internal class Ques1
    {
        static void Main()
        {
            Console.WriteLine("Enter Company Name = ");
            string CompanyName = Console.ReadLine();
            int EmpId;
            string Name;
            string Dept;
            string Desg;
            int BasicSalary;
            if (CompanyName == "TCS")
            {
                Console.WriteLine("Enter Emp ID");
                EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Emp Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Department");
                Dept = Console.ReadLine();
                Console.WriteLine("Enter Designation");
                Desg = Console.ReadLine() ;
                Console.WriteLine("Enter Basic Salary");
                BasicSalary = int.Parse(Console.ReadLine()) ;

                TCS tcsObj = new TCS(EmpId , Name , Dept, Desg , BasicSalary);

                Console.WriteLine($"EmpID : {tcsObj.ID} \nEmp Name : {tcsObj.getName}" +
                    $" \nDepartment : {tcsObj.Department} \nDesignation : {tcsObj.Designation} " +
                    $"\n Basic Salary :{tcsObj.Salary} \n PF Amount : {tcsObj.EmployeePF(BasicSalary)}" +
                    $" \n Leave Details : {tcsObj.LeaveDetails()} " +
                    $"\nGratuity Amount : {tcsObj.gratuityAmount(5,BasicSalary)}");


            }

            if (CompanyName == "Accenture")
            {
                Console.WriteLine("Enter Emp ID");
                EmpId = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Emp Name");
                Name = Console.ReadLine();
                Console.WriteLine("Enter Department");
                Dept = Console.ReadLine();
                Console.WriteLine("Enter Designatin");
                Desg = Console.ReadLine();
                Console.WriteLine("Enter Basic Salary");
                BasicSalary = int.Parse(Console.ReadLine());

                Accenture AObj = new Accenture(EmpId, Name, Dept, Desg, BasicSalary);

                Console.WriteLine($"EmpID : {AObj.ID} \nEmp Name : {AObj.getName}" +
                    $" \nDepartment : {AObj.Department} \nDesignation : {AObj.Designation} " +
                    $"\n Basic Salary :{AObj.Salary} \n PF Amount : {AObj.EmployeePF(BasicSalary)}" +
                    $" \n Leave Details : {AObj.LeaveDetails()} " +
                    $"\nGratuity Amount : {AObj.gratuityAmount(5, BasicSalary)}");

            }


        }
    }
}

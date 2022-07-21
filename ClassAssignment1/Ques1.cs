using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment1
{
    internal class Ques1
    {

        private int accountNo;
        string custName;
        string accType;
        int amount;

        public void accept()
        {
            Console.WriteLine("Enter Acc. no. = ");
            accountNo = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Customer name = ");
            custName = Console.ReadLine();

            Console.WriteLine("Enter Acc. type = ");
            accType = Console.ReadLine();

            amount = 0;
        }

        public int credit(int amount)
        {
            this.amount = amount+this.amount;
            return this.amount;
        }

        public int debit(int amount)
        {
            if(this.amount - amount < 0)
            {
                return -1;
            }

            this.amount -= amount;
            return this.amount;
        }

        public void dispplay()
        {
            Console.WriteLine($"Account no = {accountNo} \n CustName = {custName} \n Account type = {accType} \n Balance = {amount}");

        }

    }

    class Ques1Test
    {
        static void Main()
        {
            Console.WriteLine("enter no. of users = ");
            int noOfCust = int.Parse(Console.ReadLine());
            Ques1[] customers = new Ques1[noOfCust];
            for(int i = 0; i < customers.Length; i++)
            {
                customers[i] = new Ques1();
                Console.WriteLine("Enter details of {0} customer" , i+1);
                customers[i].accept();
            }
            Console.WriteLine("Enter no. of operations");

            int n= int.Parse(Console.ReadLine());

            while(n>0)
            {
                n--;
                Console.WriteLine("Enter account you want to perform operation on = ");
                int i=int.Parse(Console.ReadLine());
                Console.WriteLine("You want to deposit(c) or withdraw(d) or display details(t)");
                char ch = char.Parse(Console.ReadLine());
                if (ch == 'c')
                {
                    Console.WriteLine("Enter Amount to depost");
                    int am = int.Parse(Console.ReadLine());
                    int ans = customers[i].credit(am);
                    Console.WriteLine($"Updated Amount: {ans}");
                }

                if (ch == 'd')
                {
                    Console.WriteLine("Enter Amount to withdraw");
                    int am = int.Parse(Console.ReadLine());
                    int ans = customers[i].debit(am);
                    if (ans > 0)
                        Console.WriteLine($"Updated Amount: {ans}");
                    else
                        Console.WriteLine("Amount going negative");
                }
                if(ch== 't')
                {
                    customers[i].dispplay();
                }

            }

        }
    }
}

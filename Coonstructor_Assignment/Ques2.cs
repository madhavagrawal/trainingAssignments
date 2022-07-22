using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coonstructor_Assignment
{
    internal class Ques2
    {
        public string type;
        public string capacity;
        public string dimension;
        public string dateOfCompletion;
        public Ques2(string type, string capacity, string dimension, string dateOfCompletion)
        {
            this.type = type;
            this.capacity = capacity;
            this.dimension = dimension;
            this.dateOfCompletion = dateOfCompletion;
        }

        public void display()
        {
            Console.WriteLine($"Type : {type}, Capacity : {capacity}, Dimension : {dimension}, Date of Completion : {dateOfCompletion}");
        }
    }

    class testing
    {
        static void Main()
        {
            Console.WriteLine("Enter detail of house");
            Console.WriteLine("Enter Type Of House (flat or villa)");
            string type = Console.ReadLine();
            Console.WriteLine("Enter Capacity");
            string capacity = Console.ReadLine();
            string dimension = "";
            if (type == "flat")
            {
                Console.WriteLine("Enter floor no. =");
                dimension = Console.ReadLine();

            }
            else if(type == "villa")
            {
                Console.WriteLine("Enter dimension like(20*30) =");
                dimension = Console.ReadLine();
            }
            Console.WriteLine("Enter Date Of Completion = ");
            string dateOfCompletion = Console.ReadLine();

            Ques2 contractor = new Ques2(type, capacity, dimension , dateOfCompletion);

            contractor.display();

    }
    }
}

namespace Inheritance_Assignment
{

    class furniture
    {
        public int Orderid;
        public DateTime OrderDate;
        public string furnitureType;
        public int qty;
        public int totalAmt;
        public string paymentMode;


        public void getData()
        {
            Console.WriteLine("Enter OrderID :");
            Orderid=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Orderdate : ");
            OrderDate = DateTime.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Furniture Type : ");
            
        }

        public void showData()
        {
            Console.WriteLine($"OrderID :{Orderid}");
            Console.WriteLine($"Orderdate : {OrderDate}");
            Console.WriteLine($"Furniture Type : {furnitureType}");
            Console.WriteLine($"Qty : {qty}");
            Console.WriteLine($"Payment Mode : {paymentMode}");
        }
    }

    class chair : furniture
    {
        public string chairType;
        public string purpose;
        public int rate;
        public string subType;

        new public void getData(int rate)
        {
            base.getData();
            furnitureType = "Chair";
            Console.WriteLine("Enter Chair Type : ");
            chairType = Console.ReadLine();
            Console.WriteLine("Enter Purpose : ");
            purpose = Console.ReadLine();
            Console.WriteLine("Enter Sub Type of chair : ");
            subType = Console.ReadLine();
            Console.WriteLine("Enter Qty : ");
            qty = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Payment Mode : (Credit/Debit)");
            paymentMode = Console.ReadLine();
            this.rate = rate;
            
        }

        new public void showData()
        {
            base.showData();
            Console.WriteLine($"Chair Type : {chairType}");
            Console.WriteLine($"Purpose : {purpose}");
            Console.WriteLine($"Sub Type of chair : {subType}");
            Console.WriteLine($"Rate :{rate}");
            Console.WriteLine($"Total Amount : {totalAmt}");
        }

    }

    class cot : furniture
    {
        public string cotType;
        public string capacity;
        public int rate;

        new public void getData(int rate)
        {
            base.getData();

            furnitureType = "Cot";
            Console.WriteLine("Enter Cot Type : ");
            cotType = Console.ReadLine();
            Console.WriteLine("Enter Capacity : ");
            capacity = Console.ReadLine();
            Console.WriteLine("Enter Qty : ");
            qty =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Payment Mode : ");
            cotType = Console.ReadLine();
            this.rate = rate;

        }
        new public void showData()
        {
            base.showData();
            Console.WriteLine($"Cot type : {cotType}");
            Console.WriteLine($"Capacity : {capacity}");
            Console.WriteLine($"Rate :{rate}");
            Console.WriteLine($"Total Amount : {totalAmt}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Chair or Cot");
            string st = Console.ReadLine();
            if(st == "Chair")
            {
                chair ch = new chair();
                ch.getData(500);
                ch.totalAmt = ch.qty * ch.rate;
                ch.showData();
            }
            else if(st == "Cot")
            {
                cot co= new cot();
                co.getData(1000);
                co.totalAmt = co.qty * co.rate;
                co.showData();

            }
            
        }
    }
}
using System;

namespace Payment_Bill
{
    internal class Program
    {
        string client_name;
        string client_phone;
        string product_name;
        int rate;
        int quantity;
        double cost;
        double gst = 0;

        internal void input()
        {
            Console.WriteLine("Enter Customer Name:");
            client_name = Console.ReadLine();

            Console.WriteLine("Enter Phone Number:");
            client_phone = Console.ReadLine();

            Console.WriteLine("Enter Product Name:");
            product_name = Console.ReadLine();

            Console.WriteLine("Enter Quantity:");
            quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate per Item:");
            rate = Convert.ToInt32(Console.ReadLine());
        }

        internal void calculate()
        {
            cost = rate * quantity;

            if (cost > 100)
            {
                gst = cost * 0.18;  // 18% GST
                cost += gst;
            }
        }

        internal void display()
        {
            Console.WriteLine("\n---------- Invoice ----------");
            Console.WriteLine("Customer Name : " + client_name);
            Console.WriteLine("Phone Number  : " + client_phone);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Product Name  : " + product_name);
            Console.WriteLine("Quantity      : " + quantity);
            Console.WriteLine("Rate per Item : Rs." + rate);
            Console.WriteLine("-----------------------------");

            if (gst > 0)
                Console.WriteLine("GST (18%)     : Rs." + gst);

            Console.WriteLine("Total Cost    : Rs." + cost);
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Thank you for shopping with us!");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("====== Grocery Bill ======");
            Program p = new Program();
            p.input();
            p.calculate();
            p.display();
        }
    }
}

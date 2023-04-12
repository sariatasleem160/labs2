using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p2
{
    class Program
    {
        class product
        {
            
            public int ID;
            public string name;
            public int price;
            public int category;
            public string country;
            public string brandname;

       }
        
       
        static void Main(string[] args)
        {
            addProducts();
            product p1 = new product();
            int ID = 3;
            string name = "sana";
            int category = 3;
            string country = "asia";
            string brandname = "asa";
            Console.WriteLine("ID: {0} name: {1} category: {2} country:{3} brandname: {4} ", ID, name, category, country, brandname);
            Console.Read();



        }
        static void addProducts()
        {
            product p1 = new product();
            Console.WriteLine("Enter id: ");
            p1.ID =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter name: ");
            p1.name = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            p1.price =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter category: ");
            p1.category =int.Parse( Console.ReadLine());
            Console.WriteLine("Enter country: ");
            p1.country = Console.ReadLine();
            Console.WriteLine("Enter brandname: ");
            p1.brandname =Console.ReadLine();

            int add = p1.ID + p1.price + p1.category;
            Console.WriteLine(add);
            Console.Read();
        }
       
      
    }
}

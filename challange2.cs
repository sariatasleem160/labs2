using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cha2
{
    class Program
    {
        class credentials {
           public string username;
            public int password;


        }



        static void Main(string[] args)
        {

            Console.WriteLine("Enter username: ");
            Console.ReadLine();
            Console.WriteLine("Enter password: ");
            Console.ReadLine();
            string filename = "data.txt";
            string data;

            using (StreamReader sr = new StreamReader(filename))
            {
                data = sr.ReadToEnd();
            }
        }
    }
}

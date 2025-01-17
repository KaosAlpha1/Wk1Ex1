using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name? ");
            string Fname = Console.ReadLine();
            Console.Write("What is your last name? ");
            string Lname = Console.ReadLine();
            Console.Write("What is your age? ");
            string age = Console.ReadLine();
            Console.Write("What is your favorite color? ");
            string color = Console.ReadLine();
            Console.Write("Hello, "+Fname +" " + Lname +"!" + " You are " + age + " years old and your favorite color is " + color);
        }
    }
}

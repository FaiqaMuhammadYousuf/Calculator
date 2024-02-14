using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\r");
            Console.WriteLine("--------------------------------------------------------Calculator------------------------------------------------------");
            Console.WriteLine("\r");

            Console.WriteLine("Select the operator : " + '\n' + "+" + '\n' + "-" + '\n' + "/" + '\n' + "*");
            Console.WriteLine("---------------------");
            char op = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Your selected operator is : " + op);
            Console.WriteLine("---------------------");
            Console.WriteLine("\n");

            Console.WriteLine("Enter the first number");
            int Fnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Your first number is : " + Fnum);
            Console.WriteLine("---------------------");
            Console.WriteLine("\n");


            Console.WriteLine("Enter the second number");
            int Snum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("---------------------");
            Console.WriteLine("Your second number is : " + Snum);
            Console.WriteLine("---------------------");
            Console.WriteLine("\n");

            double result = 0;

            switch (op)
            {
                case '+':
                    result = Fnum + Snum;
                    Console.WriteLine("Addition : " + result);
                    break;
                case '-':
                    result = Fnum - Snum;
                    Console.WriteLine("Substraction : " + result);
                    break;
                case '/':
                    result = Fnum / Snum;
                    Console.WriteLine("Division : " + result);
                    break;
                case '*':
                    result = Fnum * Snum;
                    Console.WriteLine("Multiplication : " + result);
                    break;
                default : 
                    Console.WriteLine("Invalid operator selected by the user"); 
                    break;

            }
            Console.WriteLine("\r");
            Console.WriteLine("---------------------");
            Console.WriteLine("Result : " + Fnum + op + Snum + " = " + result);
            Console.WriteLine("---------------------");
            Console.WriteLine("\n");




        }
    }
}

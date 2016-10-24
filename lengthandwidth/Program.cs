using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lengthandwidth
{
    class Program
    {
        static void Main(string[] args)
        { 
            Double area;
        Double perimeter;
            string continuee;
            do
            {
                Console.WriteLine("enter the length of the room");
                string input = Console.ReadLine();
                double length = Convert.ToDouble(input);
                Console.WriteLine("enter the width of the room");
                string info = Console.ReadLine();
                double width = Convert.ToDouble(info);
                area = length * width;
                Console.WriteLine("the area is " + area);
                perimeter = (2 * length) + (2 * width);
                Console.WriteLine("the perimeter is " + perimeter);
              
                Console.WriteLine("you want to continue y/n ");
                 continuee = Console.ReadLine();
            }
            while( continuee =="y");





        }
    }
}

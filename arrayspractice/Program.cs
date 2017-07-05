using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayspractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring an array without initalizing
            int[] myFirstArray;
            //declare and initialize another array
            string[] myStringArray = { "First", "second", "third", "fourth" };
            //declare and init a char array with letters of your name
            char[] myName = { 's', 'a', 'k', 'i', 'e' };
            //i want my console to print three elements of my array
            Console.WriteLine(myName[0]);
            Console.WriteLine(myName[3]);
            Console.WriteLine(myName[1]);
            //create the following arrays and print using the correct index numbers
            //array of top 10 vac spots
            //print first and last vac spot
            //array of the ages of 3 childrem you know
            //print each childs age
            //array of gpa's on a 4.0 scale of 8 students- u dont have to print
            //array of first letter of 4 of your classmates names who are sitting near u
            //print all four on the same line

            string[] topVac = { "hawaii", "nantucket", "denver", "costarica", "melbourne", "yucatan", "keywest", "amsterdam", "thailand", "johanisberg" };
            Console.WriteLine(topVac[0]);
            Console.WriteLine(topVac[9]);

            int[] threeAges = { 1, 3, 1};
            Console.WriteLine(threeAges[0]);
            Console.WriteLine(threeAges[1]);
            Console.WriteLine(threeAges[2]);

            double[] gpa = { 3.4, 3.2, 4.0, 3.0, 2.5, 2.6, 3.3, 4.0, 3.9 };

            char[] classMatesnames = { 'b', 'a', 'p', 'h' };
            Console.WriteLine(classMatesnames);
        }
    }
}

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
            //int[] myFirstArray;
            ////declare and initialize another array
            //string[] myStringArray = { "First", "second", "third", "fourth" };
            ////declare and init a char array with letters of your name
            //char[] myName = { 's', 'a', 'k', 'i', 'e' };
            ////i want my console to print three elements of my array
            //Console.WriteLine(myName[0]);
            //Console.WriteLine(myName[3]);
            //Console.WriteLine(myName[1]);
            //create the following arrays and print using the correct index numbers
            //array of top 10 vac spots
            //print first and last vac spot

            //string[] topVac = { "hawaii", "nantucket", "denver", "costarica", "melbourne", "yucatan", "keywest", "amsterdam", "thailand", "johannesberg" };
            //Console.WriteLine(topVac[0]);
            //Console.WriteLine(topVac[9]);

            //array of the ages of 3 childrem you know
            //print each childs age
            //int[] threeAges = { 1, 3, 1};
            //Console.WriteLine(threeAges[0]);
            //Console.WriteLine(threeAges[1]);
            //Console.WriteLine(threeAges[2]);

            ////array of gpa's on a 4.0 scale of 8 students- u dont have to print
            //double[] gpa = { 3.4, 3.2, 4.0, 3.0, 2.5, 2.6, 3.3, 4.0, 3.9 };

            ////array of first letter of 4 of your classmates names who are sitting near u
            ////print all four on the same line
            //char[] classMatesnames = { 'b', 'a', 'p', 'h' };
            //Console.WriteLine(classMatesnames);

            //dataType[] nameOfArray = new dataType[#ofelemnets];
            int[] numberOfSeats = new int[21];
            string[] studentsInClass = new string[21];

            //nameofaaray{index] = element;
            studentsInClass[0] = "Jordan";

            Console.WriteLine("Please enter in the name of the next student");
            studentsInClass[1] = Console.ReadLine();
            Console.WriteLine("the student in the second seat is {0}.", studentsInClass[1]);

            //ask user for input
            Console.WriteLine("Please enter the age of the person in the first seat");
            //create a new int with 21 spots and call it ageOfStudentsInClass
            int[] ageOfStudentsInClass = new int[21];
            ///assign value of the int at the 0 index of ageOfStudentsInClass
            //...n the users input converted into an int
            ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            Console.WriteLine("the age of student in the first seat is " + ageOfStudentsInClass[0]);
            //create a new string variable and set it equal to teh int at the index 0...
            //and convert into a string
            string firstIndex = ageOfStudentsInClass[0].ToString();









        }
    }
}

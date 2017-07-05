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
            //int[] numberOfSeats = new int[21];
            //string[] studentsInClass = new string[21];

            ////nameofaaray{index] = element;
            //studentsInClass[0] = "Jordan";

            //Console.WriteLine("Please enter in the name of the next student");
            //studentsInClass[1] = Console.ReadLine();
            //Console.WriteLine("the student in the second seat is {0}.", studentsInClass[1]);

            ////ask user for input
            //Console.WriteLine("Please enter the age of the person in the first seat");
            ////create a new int with 21 spots and call it ageOfStudentsInClass
            //int[] ageOfStudentsInClass = new int[21];
            /////assign value of the int at the 0 index of ageOfStudentsInClass
            ////...n the users input converted into an int
            //ageOfStudentsInClass[0] = int.Parse(Console.ReadLine());
            //Console.WriteLine("the age of student in the first seat is " + ageOfStudentsInClass[0]);
            ////create a new string variable and set it equal to the int at the index 0...
            ////and convert into a string
            //string firstIndex = ageOfStudentsInClass[0].ToString();

            //string[] restaurantsInMall = { "Subway", "Saki", "Dunkin Donuts", "Red Lobster", "Chick fil-a" };
            //Console.WriteLine(restaurantsInMall.Length);

            ////for review
            ////declare and not intialize
            //int[] myIntArrayAgain;
            ////declare an array when i know elemnets
            //char[] lettersInFirstName = { 'D', 'A', 'N', 'I', 'E', 'L' };
            ////declare and intialize an aaray when i dont know the elements
            //string[] variableName = new string[42];

            //to practice using .length, creat a char array of the letters in your middle name
            //... and print the numbers of chars to the console

            //char[] MiddleName = { 'J', 'A', 'M', 'E', 'S' };
            //Console.WriteLine(MiddleName.Length);


            ////declare and initalize a string  array
            ////using the length property, print the second to last element in the array


            //string[] streetNames = { "holly", "cherokee", "carolyn", "bruce" };
            //int numStreets = streetNames.Length;
            //Console.WriteLine(streetNames[numStreets - 2]);
            //or
            //string[] streetNames = { "holly", "cherokee", "carolyn", "bruce" };
            //Console.WriteLine(streetNames[streetNames.Length - 2]);

            //index of is a method used to search for an array of specified value and returns
            // the index position of the first matching value found
            //int[] bestYearsEver = { 1985, 1999, 1991, 2000, 1985 };
            //Console.WriteLine(Array.IndexOf(bestYearsEver, 1985));
            ////LastIndexOf is a method used to search an array of specified vallue and returns
            //// the index position of the last matching value found
            //Console.WriteLine(Array.LastIndexOf(bestYearsEver, 1985));

            //reverse method
            //int[] palindromeNumbers = { 1, 2, 3, 4, 5, 6, 7 };
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);
            //Array.Reverse(palindromeNumbers);
            //Console.WriteLine(palindromeNumbers[0]);
            //Console.WriteLine(palindromeNumbers[2]);

            //sort 
            //will sort numbers in an array lowest to highest
            //will sort char's and strings in alphabetical order from a-z
            //string[] powerRangers = { "green", "Yellow", "Pink", "Blue", "Red", "Black" };
            //Console.WriteLine(powerRangers[0]);
            //Array.Sort(powerRangers);
            //Console.WriteLine(powerRangers[0]);

            //Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            string[] firstNames = { "Bob", "Mike", "Paige", "Jessica" };
            Console.WriteLine(firstNames[2]);

            //Create an array of lucky numbers. Each number should repeat at least once.
            //Choose a lucky number, find and print the last index of it.
            int[] luckyNumbers = { 45, 15, 22, 15, 22, 45 };
            Console.WriteLine(luckyNumbers[5]);

            //Create an array of alphabet characters. Print the first index of the array.
            //Now reverse the array and print the first index.
            char[] alphBet = { 's', 'b', 'a', 'g', 'r', 'q' };
            Console.WriteLine(alphBet[0]);
            Array.Reverse(alphBet);
            Console.WriteLine(alphBet[0]);

            //Create an array of student names in random order. Order the students’
            //names using the sort method. Print the first and last students’ names.

            string[] studentsNames = { "Bob", "Mike", "Paige", "Jessica" };
            Array.Sort(studentsNames);
            Console.WriteLine(studentsNames[0]);
            Console.WriteLine(studentsNames[3]);

            //Ask 10 people for their favorite numbers and create an array of those numbers.
            //Order the numbers using the sort method.
            //Print the first and last number

            int[] tenNumbers = { 3, 6, 7, 8, 2, 9, 1, 4, 5, 10 };
            Array.Sort(tenNumbers);
            Console.WriteLine(tenNumbers[0]);
            Console.WriteLine(tenNumbers[9]);



        }
    }
}

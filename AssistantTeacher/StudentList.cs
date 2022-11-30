using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssistantTeacher
{
    public class StudentList
    {

        public static void CreateStudentList(int studentNum)
        {
            Clear();
            WriteLine("Now, please enter the names of your students. ");
            Thread.Sleep(500);
            WriteLine("You may use formats like [ FirstName LastName ] or [ LastName, FirstName ]");
            WriteLine("\nPlease enter the student names below: ");

            string[] studentNames = new string[studentNum];

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = ReadLine();
            }

            // TODO MAKE A CONFIRMATION OF STUDENT LIST SCREEN

            WriteLine("\nGreat! That's all of your students.");
            Thread.Sleep(500);
            WriteLine("Please press any key and I will create an alphabatized list of their names on the following screen...");
            ReadKey();
            CreateSortedStudentList(studentNames);
        }

        private static void CreateSortedStudentList(string[] studentNames)
        {
            Array.Sort(studentNames);

            Clear();
            Console.WriteLine("Here are your students: \n");

            for (int i = 0; i < studentNames.Length; i++)
            {
                WriteLine(studentNames[i]);
            }

            // TODO MAKE A PRINT TO FILE SCREEN AS NEXT OPTION
            // MAKE AN EXIT METHOD
        }
    }
}

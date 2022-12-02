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
        public static void CreateStudentList(int studentNumber, string className, string teacherName)
        {
            Clear();
            WriteLine("Please enter the names of your students. ");
            Thread.Sleep(500);
            WriteLine("You may use formats like [ FirstName LastName ] or [ LastName, FirstName ].");
            WriteLine("\nPlease enter the student names below: ");

            string[] studentNames = new string[studentNumber];

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = UserInput.TeacherInput();
            }

            // TODO MAKE A CONFIRMATION OF STUDENT LIST SCREEN

            WriteLine("\nGreat! That's all of your students.");
            Thread.Sleep(500);
            WriteLine("Please press any key and I will compile your class information on the following screen...");
            ReadKey();
            CreateSortedStudentList(studentNames, className, teacherName);
        }

        public static void CreateSortedStudentList(string[] studentNames, string className, string teacherName)
        {
            Array.Sort(studentNames);

            Clear();
            Thread.Sleep(1000);
            WriteLine("Instructor: " + teacherName);
            WriteLine("Class: " + className + "\n");

            for (int i = 0; i < studentNames.Length; i++)
            {
                int studentOrder = i + 1;
                WriteLine(studentOrder + ". " + studentNames[i]);
            }

            StudentListTextFile.ConfirmCreateTextFile(studentNames, className, teacherName);
        }
    }
}

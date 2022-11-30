using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssistantTeacher
{
    public class StudentNumber
    {
        public static void GetTotalNumberOfStudents()
        {
            Clear();
            WriteLine("Next, please tell me the total number of students in your class: ");

            int studentNum = Convert.ToInt32(Console.ReadLine());

            Thread.Sleep(500);
            WriteLine("\nYou have " + studentNum + " students! Is that correct?");
            WriteLine("Press y and press enter to confirm. Or type n and press enter to start over.");
            ConfirmStudentNum(studentNum);
        }

        private static void ConfirmStudentNum(int studentNum)
        {
            string? confimStudentNum = ReadLine().ToLower();

            if (confimStudentNum == "y")
            {
                WriteLine("\nExcellent! Please press any key to continue...");
                ReadKey();
                StudentList.CreateStudentList(studentNum);
            }
            else if (confimStudentNum == "n")
            {
                WriteLine("\nOh No! Press any key to start over...");
                ReadKey();
                GetTotalNumberOfStudents();
            }
            else
            {
                WriteLine("\nI'm sorry, I don't recognize that input. Press any key to try again...");
                ReadKey();
                GetTotalNumberOfStudents();
            }
        }
    }
}

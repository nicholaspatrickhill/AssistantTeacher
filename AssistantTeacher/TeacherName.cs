using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssistantTeacher
{
    public class TeacherName
    {
        public static void GetTeacherName()
        {
            Clear();
            WriteLine("To get started, I'll need a bit of information.");
            Thread.Sleep(500);
            WriteLine("First, please tell me your first name: ");

            string firstName = UserInput.TeacherInput();

            WriteLine("\nAnd please tell me your last name: ");

            string lastName = UserInput.TeacherInput();

            string teacherName = firstName + " " + lastName;

            Thread.Sleep(500);
            WriteLine("\nIt's great to meet you, " + teacherName + "!");
            WriteLine("\nIf that looks correct, type y and press enter to confirm. Or type n and press enter to start over.");

            ConfirmTeacherName(teacherName);
        }

        private static void ConfirmTeacherName(string teacherName)
        {
            string? confirmTeacherName = UserInput.TeacherInput().ToLower();

            if (confirmTeacherName == "y")
            {
                WriteLine("\nPerfect. Please press any key to continue...");
                ReadKey();
                ClassName.GetClassName(teacherName);
            }
            else if (confirmTeacherName == "n")
            {
                WriteLine("\nOh no! Press any key to start over...");
                ReadKey();
                GetTeacherName();
            }
            else
            {
                WriteLine("\nI'm sorry, I don't recognize that input. Please press any key to try again...");
                ReadKey();
                GetTeacherName();
            }
        }
    }
}

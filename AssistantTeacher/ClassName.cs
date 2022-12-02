using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssistantTeacher
{
    public class ClassName
    {
        public static void GetClassName(string teacherName)
        {
            Clear();
            Thread.Sleep(500);
            WriteLine("Next, please tell me the name of the class that you're teaching: ");

            string className = UserInput.TeacherInput();

            Thread.Sleep(500);
            WriteLine("\nGreat! You're teaching " + className + ", is that correct?");
            WriteLine("\nType y and press enter to confirm. Or type n and press enter to start over.");

            ConfirmClassName(className, teacherName);
        }

        private static void ConfirmClassName(string className, string teacherName)
        {
            string? confirmClassName = UserInput.TeacherInput().ToLower();

            if (confirmClassName == "y")
            {
                WriteLine("\nAwesome. Please press any key to continue...");
                ReadKey();
                StudentNumber.GetTotalNumberOfStudents(className, teacherName);
            }
            else if (confirmClassName == "n")
            {
                WriteLine("\nOh no! Press any key to start over...");
                ReadKey();
                GetClassName(teacherName);
            }
            else
            {
                WriteLine("\nI'm sorry, I don't recognize that input. Please press any key to try again...");
                ReadKey();
                GetClassName(teacherName);
            }
        }
    }
}

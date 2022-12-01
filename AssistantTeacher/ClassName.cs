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
        public static void GetClassName()
        {
            Clear();
            WriteLine("To get started, I'll need a bit of information.");
            Thread.Sleep(500);
            WriteLine("First, please tell me the name of the class that you're teaching: ");

            string? className = ReadLine();

            Thread.Sleep(500);
            WriteLine("\nGreat! You're teaching " + className + " is that correct?");
            WriteLine("Type y and press enter to confirm. Or type n and press enter to start over.");

            ConfirmClassName();
        }

        private static void ConfirmClassName()
        {
            string? confirmClassName = ReadLine().ToLower();

            if (confirmClassName == "y")
            {
                WriteLine("\nAwesome. Please press any key to continue...");
                ReadKey();
                StudentNumber.GetTotalNumberOfStudents();
            }
            else if (confirmClassName == "n")
            {
                WriteLine("\nOh No! Press any key to start over...");
                ReadKey();
                GetClassName();
            }
            else
            {
                WriteLine("\nI'm sorry, I don't recognize that input. Please press any key to try again...");
                ReadKey();
                GetClassName();
            }
        }
    }
}

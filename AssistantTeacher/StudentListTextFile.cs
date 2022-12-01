using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssistantTeacher
{
    public class StudentListTextFile
    {
        public static void ConfirmCreateTextFile(string[] studentNames, string className)
        {
            Thread.Sleep(500);
            WriteLine("\nWould you like to save the list as a text file?");
            WriteLine("\nType y and press enter to confirm. Or type n and press enter to exit the program");

            string? confirmSaveToTextFile = UserInput.TeacherInput().ToLower();

            if (confirmSaveToTextFile == "y")
            {
                StreamWriter file = CreateTextFile(studentNames, className);

                Thread.Sleep(500);
                WriteLine("Your student list has been saved to a text file at C:\\temp\\MyStudentList.txt.");
                Thread.Sleep(500);
                WriteLine("\nWhen you're finished, press any key to exit the program.");
                ReadKey();
                Environment.Exit(0);
            }
            else if (confirmSaveToTextFile == "n")
            {
                Thread.Sleep(500);
                WriteLine("Okay! When you're finished, press any key to exit the program.");
                ReadKey();
                Environment.Exit(0);
            }
            else
            {
                WriteLine("\nI'm sorry, I don't recognize that input. Please press any key to try again...");
                ReadKey();
                Clear();
                ConfirmCreateTextFile(studentNames, className);
            }
        }

        private static StreamWriter CreateTextFile(string[] studentNames, string className)
        {
            string myStudentList = @"C:\temp\MyStudentList.txt";
            StreamWriter file = new StreamWriter(myStudentList);

            // TODO add teacher name
            file.WriteLine("Class: " + className + "\n");

            for (int i = 0; i < studentNames.Length; i++)
            {
                int studentOrder = i + 1;
                file.WriteLine(studentOrder + ". " + studentNames[i]);
            }
            file.Close();
            return file;
        }
    }
}

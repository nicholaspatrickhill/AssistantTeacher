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
        public static void CreateTextFile(string[] studentNames)
        {
            WriteLine("\nWould you like to save the list as a text file?");

            string? confirmSaveToTextFile = UserInput.TeacherInput().ToLower();

            if (confirmSaveToTextFile == "y")
            {

                string myStudentList = @"C:\temp\MyStudentList.txt";
                using StreamWriter file = new StreamWriter(myStudentList);

                for (int i = 0; i < studentNames.Length; i++)
                {
                    int studentOrder = i + 1;
                    file.WriteLine(studentOrder + ". " + studentNames[i]);
                }
                file.Close();

                Thread.Sleep(500);
                WriteLine("Your student list has been saved to a text file at C:\\temp\\MyStudentList.txt.");
                Thread.Sleep(500);
                WriteLine("\nWhen You're finished, press any key to exit the program.");
                ReadKey();
                Environment.Exit(0);
            }
            else if (confirmSaveToTextFile == "no")
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
                StudentList.CreateSortedStudentList(studentNames);
            }
        }
}

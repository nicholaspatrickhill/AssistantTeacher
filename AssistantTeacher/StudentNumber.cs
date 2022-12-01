﻿using System;
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

            string? teacherInput = ReadLine();
            int studentNumber;

            try
            {
                studentNumber = Int32.Parse(teacherInput);

                if (studentNumber > 30)
                {
                    Thread.Sleep(500);
                    WriteLine("\nThat's a lot of students! I'm sorry but I can only support classes of up to 30 students.");
                    WriteLine("Press any key to exit...");
                    ReadKey();
                    Environment.Exit(0);
                }
                else if (studentNumber < 30)
                {

                    Thread.Sleep(500);
                    WriteLine("\nYou have " + studentNumber + " students! Is that correct?");
                    WriteLine("Press y and press enter to confirm. Or type n and press enter to start over.");
                    ConfirmStudentNum(studentNumber);
                }
            }
            catch (FormatException)
            {
                Thread.Sleep(500);
                WriteLine("\n{0} does not appear to be a number", teacherInput);
                WriteLine("Press any key to try again...");
                ReadKey();
                GetTotalNumberOfStudents();
            }
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

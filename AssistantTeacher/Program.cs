using static System.Console;

namespace AssistantTeacher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Title = "AssistantTeacher";
            WriteLine("Hello, Teacher!");
            Thread.Sleep(500);
            WriteLine("I'll be your assistant today.");
            Thread.Sleep(500);
            WriteLine("\nPress any key to continue...");
            ReadKey();
            GetClassName();
        }

        private static void GetClassName()
        {
            Clear();
            WriteLine("To get started, I'll need a bit of information.");
            Thread.Sleep(500);
            WriteLine("First, please tell me the name of the class you're teaching: ");

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
                GetTotalNumberOfStudents();
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

        private static void GetTotalNumberOfStudents()
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
                CreateStudentList(studentNum);
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

        private static void CreateStudentList(int studentNum)
        {
            Clear();
            WriteLine("Now, please enter the names of your students: ");

            string[] studentNames = new string[studentNum];

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = ReadLine();
            }

            WriteLine("\nGreat! That's all of your students. Please press any key and I will create an alphabtized list of their names.");
            ReadKey();

            Array.Sort(studentNames);

            Console.WriteLine("\nHere is an alphabatized list of your students:");

            for (int i = 0; i < studentNames.Length; i++)
            {
                WriteLine(studentNames[i]);
            }
        }
    }
}
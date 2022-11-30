using static System.Console;

namespace AssistantTeacher
{
    public class Program
    {
        static void Main(string[] args)
        {
            Title = "AssistantTeacher";
            WriteLine("Hello, Teach!");
            Thread.Sleep(500);
            WriteLine("I'll be your assistant today.");
            Thread.Sleep(500);
            WriteLine("\n(Press any key to continue...)");
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
                WriteLine("\nOh no! Let's start over.");
                GetClassName();
            }
            else
            {
                WriteLine("\nI'm sorry, I don't recognize that input. Please press any key to try again.");
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
            WriteLine("Press y and press enter to confirm. Or type n and press enter to start over");
            ConfirmStudentNum(studentNum);
        }

        private static void ConfirmStudentNum(int studentNum)
        {
            string? confimStudentNum = ReadLine().ToLower();

            if (confimStudentNum == "y")
            {
                WriteLine("\nExcellent. Please press any key to continue...");
                ReadKey();
                CreateStudentList(studentNum);
            }
            else if (confimStudentNum == "n")
            {
                WriteLine("Oh No! Let's start over.");
                GetTotalNumberOfStudents();
            }
            else
            {
                WriteLine("I'm sorry, I don't recognize that input. Please try again.");
                ReadKey();
                GetTotalNumberOfStudents();
            }  
        }

        private static void CreateStudentList(int studentNum)
        {
            WriteLine("\nGreat! Enter Their names below: ");

            string[] studentNames = new string[studentNum];

            for (int i = 0; i < studentNames.Length; i++)
            {
                studentNames[i] = ReadLine();
            }

            Array.Sort(studentNames);

            Console.WriteLine("\nHere is an alphabatized list of your students:");

            for (int i = 0; i < studentNames.Length; i++)
            {
                WriteLine(studentNames[i]);
            }
        }
    }
}
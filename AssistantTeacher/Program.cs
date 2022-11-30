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
            GetClassName();
        }

        private static void GetClassName()
        {
            WriteLine("To get started, please tell me the name of the class you're teaching: ");

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
                WriteLine("Awesome. Now please tell me the total number of students in your class: ");
                GetTotalNumberOfStudents();
            }
            else if (confirmClassName == "n")
            {
                WriteLine("Oh no! Let's start over.");
                GetClassName();
            }
            else
            {
                WriteLine("I'm sorry, I don't recognize that input. Please try again.");
                ConfirmClassName();
            }
        }

        private static void GetTotalNumberOfStudents()
        {
            WriteLine("Please tell me the total number of students in your class: ");

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
                WriteLine("Great! Enter Their names below: ");
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
                ConfirmStudentNum(studentNum);
            }  
        }

        private static void CreateStudentList(int studentNum)
        {
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
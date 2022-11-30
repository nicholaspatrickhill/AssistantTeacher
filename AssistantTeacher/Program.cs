using static System.Console;

namespace AssistantTeacher
{
    class Program
    {
        static void Main(string[] args)
        {
            Title = "AssistantTeacher";

            WriteLine("Hello, Teacher!");
            Thread.Sleep(500);
            WriteLine("I'm happy to be your assistant today.");
            Thread.Sleep(500);
            WriteLine("\nPress any key to continue...");
            ReadKey();

            ClassName.GetClassName();
        }
    }
}
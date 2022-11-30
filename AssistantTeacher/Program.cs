using static System.Console;

namespace AssistantTeacher
{
    public class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Hello, Teach! How many students are in your class?");

            int studentNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nYou have " + studentNum + " students! Now please enter their names: ");

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
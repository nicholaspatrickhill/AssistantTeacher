using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AssistantTeacher
{
    public class UserInput
    {
        public static string TeacherInput()
        {
            string? input = ReadLine() ?? string.Empty;
            return input;
        }
    }
}

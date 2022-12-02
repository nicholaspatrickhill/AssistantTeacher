**AssistantTeacher** is a console application designed to help instructors compile information about their classes.

##NOTES
**PROGRAM START:** The program begins by introducing itself on the first screen by calling WriteLine.
The user is asked to continue by calling ReadKey to check for their response.

**GETTING THE INSTRUCTOR'S NAME/USER INPUT & IF-ELSE:** The GetTeacherName method is then called.
GetTeacherName calls TeacherInput from the UserInput class to get the Instructor's First and Last names.
The program then returns those names in as a concatanated string called teacherName.
And If-Else block in ConfirmTeacherName asks the user to confirm that the name is correct to continue.
If the name is not correct, GetTeacherName is called so the user may start over.
If the name is correct, GetClassName is called.

**GETTING THE INSTRUCTOR'S CLASS NAME:** GetClassName functions similarly to GetTeacherName.
TeacherInput is called to get the name of the class from the user.
An If-Else block in ConfirmClassName asks the user to confirm that the class name is correct to continue.
If the name is not correct GetClassName is called so the user may start over.
If the name is correct, GetTotalNumberOfStudents is called.

**SETTING THE NUMBER OF STUDENTS/EXCEPTION HANDLING:** GetTotalNumberOfStudents calls TeacherInput to get the total number of students in the class.
The user's input is thrown into a Try block.
In the try block, the user's input is converted from a string to the studentNumber integer by calling ToInt32.Parse on the input.
An If-Else block caps the number of students at 30.
AssistantTeacher supports class sizes of up to 30 students only.
If the user's input is not a number, it is thrown into a Catch block where FormatException is called.
The user is notified that their input was invalid and GetTotalNumberOfStudents is called so that the user may start over.
Otherwise, ConfirmStudentNum is called so that the user may confirm that the number of students they've inputted is correct.
If the number is not correct, GetTotalNumberOfStudents is called so that the user may start over.
If the number is correct, CreateStudentList is called.

**CREATING THE STUDENT LIST/ARRAYS, FOR LOOPS & ITERATIONS:** CreateStudentList calls TeacherInput in a For loop to allow the user to input the names of the students in their class.
The studentNames array is declared using the studentNumber integer from GetTotalNumberOfStudents to set the array's size.
The user inputs the student names inside the For loop until they have iterated up to the value of the studentNumber integer.
Upon the user's confirmation, the CreateSortedStudentList method is called.
CreateSortedStudentList calls Array.Sort to alphabatize the names of the students in the studentNames array.
The teacherName and className strings are passed into CreateSortedStudentList as arguments.
Those values are displayed on the console by calling WriteLine.
Then, another For loop iterates over the elements in the studentNames array.
The studentOrder integer numbers the students beginning at 1 and ending in the value of the studentNumber integer.
Those elements are then displayed by calling WriteLine.
ConfirmCreateTextFile is then called.

**SAVING TO TEXT FILE** ConfirmCreateTextFile asks the user if they wish to save the information that AssistantTeacher just compiled for them to a text file.
If the user confirms that they do wish to create a text file, StreamWriter is called.
The teacherName and className strings are passed into ConfirmCreateTextFile as arguments.
Those values are displayed in the text file by calling file.WriteLine.
Then, a For loop iterates over the elements in the studentNames array.
The studentOrder integer numbers the students beginning at 1 and ending in the value of the studentNumber integer.
Those elements are then displayed by calling file.WriteLine.
If the user does not wish to save the information to a text file, they are asked to confirm that they wish to terminate the program.

##INSTRUCTIONS
Follow the on-screen prompts to input your name, your class name and size, and the names of your students.
Please note that AssistantTeacher supports classes of up to 30 students.

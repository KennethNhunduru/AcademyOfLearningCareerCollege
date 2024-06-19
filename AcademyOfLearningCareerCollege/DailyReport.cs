//C# program to create daily report for students of Academy of Learning Career College.

//directive that references the library in the System namespace.  
using System;

//declaring container for classes and other namespaces.
namespace AcademyOfLearningCareerCollege
{
    //container for data and methods that bring functionality to the this program.
    class DailyReport
    {
        //declaring the Main() method with the static modifier.
        static void Main(string[] args)
        {
            //printing the front page of the daily report.
            string frontPage1 = "Academy of Learning Career College.";
            Console.WriteLine(frontPage1);
            string frontPage2 = "Student Daily Report.";
            Console.WriteLine(frontPage2);
           
            //getting the student's full name.
            Console.WriteLine("What is your name?");

            /*creating a string variable, getting the student first name from the keyboard
              and storing the student first name.*/
            Console.WriteLine("Enter your first name: ");
            string firstName = Console.ReadLine();

            /*creating a string variable, getting the student last name from the keyboard
              and storing the student last name.*/
            Console.WriteLine("Enter your last name: ");
            string lastName = Console.ReadLine();

            //displaying the student full name.
            Console.WriteLine("Your full name is: " + firstName + " " + lastName);

            //obtaining the student course details.
            Console.WriteLine("What course are you on?");

            /*creating a string variable, getting the student's course from the keyboard
              and storing the student course.*/
            string courseTitle = Console.ReadLine();

            //displaying the student course.
            Console.WriteLine("You are studying: " + courseTitle);

            //logging the student course progress.
            Console.WriteLine("What page number?");

            /*creating a string variable, logging the student's page number from the keyboard
              and storing the page number.*/
            int pageNumber = Convert.ToInt32(Console.ReadLine());

            //displaying the student's page number.
            Console.WriteLine("You are up to page: " + pageNumber);

            //checking if help is needed.
            Console.WriteLine("Do you need any help with anything?\nPlease answer \"true\" or \"false\" :");

            /*creating a boolean variable, getting the help response from the keyboard
              and storing the response as a boolean variable.*/
            bool needHelp = Convert.ToBoolean(Console.ReadLine());

            //displaying the converted string as a Boolean value.
            Console.WriteLine(needHelp);

            //enlisting student positive experiences.
            Console.WriteLine("Were there any positive experiences you'd like to share?\nPlease give specifics.");

            /*creating a string variable, getting the positive experiences feedback from the keyboard
              and storing the feedback.*/
            string positiveExperiences = Console.ReadLine();

            //displaying the positive experiences feedback string.
            Console.WriteLine(positiveExperiences);

            //enlisting any other feedback.
            Console.WriteLine("Is there any other feedback you'd like to provide?\nPlease be specific.");

            /*creating a string variable, getting any other feedback from the keyboard
              and storing the feedback.*/
            string anyOtherFeedback = Console.ReadLine();

            //displaying the any other feedback string.
            Console.WriteLine(anyOtherFeedback);

            //enquiry about hours of study for the day.
            Console.WriteLine("How many hours did you study today?");
            
            /*creating a string variable, logging the student's hours of study from the keyboard
              and storing the input.*/
            int studyHours = Convert.ToInt32(Console.ReadLine());

            //displaying the hours of study for the day.
            Console.WriteLine("Today you studied for: " + studyHours + "hrs");

            //closing statement.
            Console.WriteLine("Thank you for your answers.\nAn instructor will respond shortly.\nHave a great day!");
            Console.ReadLine();
        }
    }
}

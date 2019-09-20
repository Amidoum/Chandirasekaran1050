//Lesson4

/* line 1
 * line 2
*/

using System;

namespace Lesson4
{
    class MyProgram
    {
        static void Main(string[] args)
        {
            string userInput;//define a variable

            Console.WriteLine("Hello");
            Console.WriteLine("Type something");
            userInput = Console.ReadLine();//store in a variable
            Console.WriteLine("You said "+ userInput);//string concatenation

            //Get first name, last name
            Console.WriteLine("please enter your firstname");
            string firstName = Console.ReadLine();
            Console.WriteLine("please enter your lastname");
            string lastName = Console.ReadLine();

            //Get age and income from user
            Console.WriteLine("please enter your age");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter your income");
            int income = int.Parse(Console.ReadLine());

            if (age > 65)
            {
                Console.WriteLine("You are a senior citizen");
            }
            //Write code for income more than 45000

            Console.ReadKey();
        }
    }
}

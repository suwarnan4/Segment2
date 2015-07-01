using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Segment2
{
    class Program
    {
        static void Main(string[] args)
        {
            string answer, message;

            Console.WriteLine("Guess the answer please");

            GetAnswer:
            Console.Write("Answer :- ");

            answer = Console.ReadLine();

            int result;
            if (!(int.TryParse(answer, out result)))
            {
                Console.WriteLine("The answer should be a number between 1 and 100");
                Console.WriteLine("");
                Console.WriteLine("Please try again");

                goto GetAnswer;
            }

            CheckAnswer cheAnswer=new CheckAnswer();
            message =cheAnswer.Check(Convert.ToInt32(answer));

            Console.WriteLine(message);
            Console.WriteLine("");

            if (message != "Correct")
            {
                Console.WriteLine("Please try again");
                goto GetAnswer;
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}

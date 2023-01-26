using System.Threading.Tasks;

namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite school subject?");
            var favSubject = Console.ReadLine();

            switch (favSubject.ToLower())
            {
                case "math":
                    Console.WriteLine($"What a good pick. I enjoy {favSubject}.");
                    break;
                case "science":
                    Console.WriteLine($"That's impressive. I didn't do well with {favSubject}.");
                    break;
                case "history":
                    Console.WriteLine($"Good choice. {favSubject} is fun.");
                    break;
                case "english":
                    Console.WriteLine($"{favSubject} is hard. You must be very smart.");
                    break;
                default:
                    Console.WriteLine($"Ah. I've never studied {favSubject} before.");
                    break;
            }
        }
    }
}

//Ask the user for their favorite school subject.
//Store their answer in a variable
//Pass the variable as the expression in a switch statement.
//Create 5 different cases for different subjects. Each case will print the subject chosen and a custom message of your choosing.
//Create a default case to handle any case not handled.
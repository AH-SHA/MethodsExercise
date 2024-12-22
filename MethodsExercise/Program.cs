namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            // prompt user to enter several elements of information

            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();   //user input

            Console.WriteLine("What is your favorite color?");
            string userColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string userAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string userBand = Console.ReadLine();

            Console.WriteLine($"My name is {userName}.The color of my favorite shirt is {userColor}. I like {userAnimal}. {userBand} is my favorite band.");

        }
    }
}
